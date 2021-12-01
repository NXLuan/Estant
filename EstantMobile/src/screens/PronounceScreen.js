import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  ScrollView,
  PermissionsAndroid,
  ActivityIndicator,
} from 'react-native';
import { Button, IconButton } from 'react-native-paper';
import AudioRecord from 'react-native-audio-record';
import { Colors } from '../styles/colors';
import Sound from 'react-native-sound';
import { checkPronounce } from '../api/VocabularyAPI';
import { readFile } from 'react-native-fs';

const PronounceScreen = ({ route }) => {
  const [isRecord, setIsRecord] = useState(false);
  const [isLoading, setIsLoading] = useState(false);
  const [result, setResult] = useState(null);
  const { dataWord } = route.params;
  const { word, phonetic, audio, meanings } = dataWord;
  const [replay, setReplay] = useState(null);
  const [scoreColor, setScoreColor] = useState('green');
  const sound = new Sound(audio);

  // const result = {
  //   score: 58,
  //   accent_predictions: {
  //     en_US: 1,
  //     en_UK: 88,
  //     en_AU: 1,
  //   },
  //   score_estimates: {
  //     ielts: '6.5',
  //     toefl: '20-22',
  //     cefr: 'B2',
  //     pte_general: '3',
  //   },
  // };

  useEffect(() => {
    if (!PermissionsAndroid.check('RECORD_AUDIO')) {
      requestAudioPermission();
    }
  }, []);
  const handleRecord = () => {
    setIsRecord(true);
    const options = {
      sampleRate: 16000, // default 44100
      channels: 1, // 1 or 2, default 1
      bitsPerSample: 16, // 8 or 16, default 16
      audioSource: 6, // android only (see below)
      wavFile: 'audio.wav', // default 'audio.wav'
    };
    AudioRecord.init(options);
    AudioRecord.start();
  };
  const handleStopAndSubmit = async () => {
    setIsRecord(false);
    setIsLoading(true);
    const audioFile = await AudioRecord.stop();
    setReplay(new Sound(audioFile));
    const base64String = await readFile(audioFile, 'base64');
    checkPronounce({
      audio_base64: base64String,
      audio_format: 'wav',
      text: word,
    })
      .then(res => {
        setIsLoading(false);
        setResult(res.data.data);
        if (res.data.data != null) {
          if (res.data.data.score > 50) setScoreColor('green');
          else setScoreColor('red');
        }
      })
      .catch(err => console.log(err));
  };
  const requestAudioPermission = async () => {
    try {
      const granted = await PermissionsAndroid.request(
        PermissionsAndroid.PERMISSIONS.RECORD_AUDIO,
        {
          title: 'Cool Photo App Camera Permission',
          message:
            'Cool Photo App needs access to your camera ' +
            'so you can take awesome pictures.',
          buttonNeutral: 'Ask Me Later',
          buttonNegative: 'Cancel',
          buttonPositive: 'OK',
        },
      );
      if (granted === PermissionsAndroid.RESULTS.GRANTED) {
        console.log('You can use the camera');
      } else {
        console.log('Camera permission denied');
      }
    } catch (err) {
      console.warn(err);
    }
  };
  return (
    <View
      style={{
        flex: 1,
        backgroundColor: 'white',
        padding: 10,
      }}>
      <View style={styles.header}>
        <IconButton
          icon="volume-high"
          size={28}
          color="white"
          style={{ backgroundColor: Colors.primary, marginRight: 15 }}
          onPress={() => {
            sound.play();
          }}
        />
        <View>
          <Text style={styles.word}>{word}</Text>
          <Text style={styles.phonetic}>/ {phonetic} /</Text>
        </View>
      </View>
      <View style={{ flex: 1 }}>
        {isLoading ? (
          <View
            style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
            <ActivityIndicator size="large" color={Colors.primary} />
          </View>
        ) : result != null ? (
          <>
            <Text
              style={{
                fontSize: 20,
                fontWeight: 'bold',
                textAlign: 'center',
                color: Colors.darkGray,
              }}>
              Your Pronunciation Score
            </Text>
            <View
              style={{
                width: 180,
                height: 180,
                borderRadius: 100,
                alignItems: 'center',
                justifyContent: 'center',
                alignSelf: 'center',
                backgroundColor: scoreColor,
                marginVertical: 30,
              }}>
              <View
                style={{
                  width: 170,
                  height: 170,
                  borderRadius: 100,
                  alignItems: 'center',
                  justifyContent: 'center',
                  alignSelf: 'center',
                  backgroundColor: 'white',
                  marginVertical: 30,
                }}>
                <Text
                  style={{
                    fontSize: 64,
                    fontWeight: 'bold',
                    color: scoreColor,
                  }}>
                  {result.score}
                </Text>
              </View>
            </View>
            <Text
              style={{
                fontSize: 20,
                fontWeight: 'bold',
                textAlign: 'center',
                color: Colors.darkGray,
              }}>
              Accent Predictions
            </Text>
            <View style={{ flex: 1, flexDirection: 'row' }}>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.accent_predictions.en_US}%
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>US</Text>
              </View>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.accent_predictions.en_UK}%
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>UK</Text>
              </View>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.accent_predictions.en_AU}%
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>AU</Text>
              </View>
            </View>
            <Text
              style={{
                fontSize: 20,
                fontWeight: 'bold',
                textAlign: 'center',
                color: Colors.darkGray,
              }}>
              Score Estimates
            </Text>
            <View style={{ flex: 1, flexDirection: 'row' }}>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.score_estimates.ielts}
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>IELTS</Text>
              </View>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.score_estimates.toefl}
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>TOEFL</Text>
              </View>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.score_estimates.cefr}
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>CEFR</Text>
              </View>
              <View style={{ flex: 1, alignItems: 'center' }}>
                <Text
                  style={{ fontWeight: '700', fontSize: 28, color: '#575757' }}>
                  {result.score_estimates.pte_general}
                </Text>
                <Text style={{ fontSize: 16, color: '#575757' }}>PTE</Text>
              </View>
            </View>
          </>
        ) : (
          <></>
        )}
      </View>

      <View
        style={{
          flexDirection: 'row',
          alignItems: 'center',
          justifyContent: 'center',
          marginBottom: 30,
        }}>
        {replay != null && (
          <IconButton
            icon="volume-high"
            size={28}
            color="white"
            style={{ backgroundColor: Colors.yellow }}
            onPress={() => {
              replay.play();
            }}
          />
        )}

        {!isRecord ? (
          <View
            style={{
              backgroundColor: Colors.lightBlue,
              justifyContent: 'center',
              alignItems: 'center',
              borderRadius: 45,
              marginHorizontal: 10,
            }}>
            <IconButton
              icon="microphone"
              size={36}
              color={Colors.lightBlue}
              style={{
                backgroundColor: 'white',
              }}
              onPress={handleRecord}
            />
          </View>
        ) : (
          <View
            style={{
              backgroundColor: 'red',
              justifyContent: 'center',
              alignItems: 'center',
              borderRadius: 45,
              marginHorizontal: 10,
            }}>
            <IconButton
              icon="stop"
              size={36}
              color="white"
              style={{
                backgroundColor: 'red',
              }}
              onPress={handleStopAndSubmit}
            />
          </View>
        )}
        {replay != null && (
          <IconButton
            icon="reload"
            size={28}
            color="white"
            style={{ backgroundColor: Colors.darkGray }}
            onPress={() => {
              setReplay(null);
              setResult(null);
            }}
          />
        )}
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  header: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingBottom: 15,
    borderBottomWidth: 0.2,
    marginBottom: 15,
  },
  word: {
    fontSize: 28,
    fontWeight: 'bold',
    color: Colors.blue,
  },
  phonetic: {
    fontSize: 20,
  },
});

export default PronounceScreen;
