import React from 'react';
import {
  ScrollView,
  StyleSheet,
  View,
  Text,
  Alert,
  ToastAndroid,
} from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';
import WordMeaning from '../components/WordMeaning';
import Sound from 'react-native-sound';

import { useDispatch } from 'react-redux';
import { saveWord, deleteWord } from '../api/UserAPI';
import { fetchListWord } from '../redux/actions/wordAction';

import AsyncStorage from '@react-native-community/async-storage';

const WordScreen = ({ route, navigation }) => {
  const { dataWord, isSavedWord } = route.params;
  const { word, phonetic, audio, meanings } = dataWord;

  const dispatch = useDispatch();

  const sound = new Sound(audio);

  const handleSaveWord = async () => {
    let token = await AsyncStorage.getItem('userToken');
    saveWord(word, token)
      .then(res => {
        dispatch(fetchListWord(res.data.data));
        ToastAndroid.show('Saved successfully!', ToastAndroid.SHORT);
      })
      .catch(err => console.log(err));
  };

  const handleDeleteWord = async () => {
    let token = await AsyncStorage.getItem('userToken');
    deleteWord(word, token)
      .then(res => {
        dispatch(fetchListWord(res.data.data));
        ToastAndroid.show('Deleted successfully!', ToastAndroid.SHORT);
        navigation.goBack();
      })
      .catch(err => console.log(err));
  };

  const showSaveWordAlert = () => {
    Alert.alert(
      '',
      'Do you want to save this word?',
      [
        {
          text: 'No',
          style: 'cancel',
        },
        { text: 'Yes', onPress: handleSaveWord },
      ],
      { cancelable: true },
    );
  };

  const showDeleteWordAlert = () => {
    Alert.alert(
      '',
      'Do you want to delete this word?',
      [
        {
          text: 'No',
          style: 'cancel',
        },
        { text: 'Yes', onPress: handleDeleteWord },
      ],
      { cancelable: true },
    );
  };

  return (
    <>
      {isSavedWord ? (
        <IconButton
          icon="trash-can"
          color="white"
          size={30}
          style={styles.saveBtn}
          onPress={showDeleteWordAlert}
        />
      ) : (
        <IconButton
          icon="bookmark-plus"
          color="white"
          size={30}
          style={styles.saveBtn}
          onPress={showSaveWordAlert}
        />
      )}
      <IconButton
        icon="microphone"
        color="white"
        size={30}
        style={styles.microBtn}
        onPress={() => navigation.navigate('Pronounce', { dataWord })}
      />
      <ScrollView style={styles.container}>
        <View style={styles.header}>
          <IconButton
            icon="volume-high"
            size={28}
            color="white"
            style={{ backgroundColor: Colors.primary, marginRight: 15 }}
            onPress={() => sound.play()}
          />
          <View>
            <Text style={styles.word}>{word}</Text>
            <Text style={styles.phonetic}>/ {phonetic} /</Text>
          </View>
        </View>
        <View style={{ marginLeft: 10 }}>
          {meanings.length > 0 &&
            meanings.map((item, index) => (
              <WordMeaning meaning={item} id={index + 1} key={index} />
            ))}
        </View>
      </ScrollView>
    </>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'white',
    padding: 10,
  },
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
  saveBtn: {
    position: 'absolute',
    top: -55,
    right: 10,
    zIndex: 100,
  },
  microBtn: {
    position: 'absolute',
    top: -55,
    right: 60,
    zIndex: 100,
  },
});
export default WordScreen;
