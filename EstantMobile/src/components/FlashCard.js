import React, { useState, useRef } from 'react';
import FrontCard from './FrontCard';
import BackCard from './BackCard';
import {
  View,
  Text,
  StyleSheet,
  Animated,
  Alert,
  ToastAndroid,
} from 'react-native';
import { Button, IconButton } from 'react-native-paper';

import { Colors } from '../styles/colors';
import Sound from 'react-native-sound';

import { useDispatch } from 'react-redux';
import { saveWord, deleteWord } from '../api/UserAPI';
import { fetchListWord } from '../redux/actions/wordAction';

import AsyncStorage from '@react-native-community/async-storage';

const FlashCard = ({ data }) => {
  const { word, audio, phonetic } = data;
  const { partOfSpeech, definitions } = data.meanings[0];
  const { definition, example } = definitions[0];
  const sound = new Sound(audio);
  const animate = useRef(new Animated.Value(0));
  const [isFlipped, setIsFlipped] = useState(false);

  const dispatch = useDispatch();

  const handleSaveWord = async () => {
    let token = await AsyncStorage.getItem('userToken');
    saveWord(word, token)
      .then(res => {
        dispatch(fetchListWord(res.data.data));
        ToastAndroid.show('Saved successfully!', ToastAndroid.SHORT);
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

  const interpolateFront = animate.current.interpolate({
    inputRange: [0, 180],
    outputRange: ['0deg', '180deg'],
  });

  const interpolateBack = animate.current.interpolate({
    inputRange: [0, 180],
    outputRange: ['180deg', '360deg'],
  });

  const handleFlip = () => {
    Animated.timing(animate.current, {
      duration: 300,
      toValue: isFlipped ? 0 : 180,
      useNativeDriver: true,
    }).start(() => {
      setIsFlipped(!isFlipped);
    });
  };
  return (
    <View>
      <Animated.View style={[{ transform: [{ rotateY: interpolateFront }] }]}>
        <FrontCard word={word} phonetic={phonetic} />
      </Animated.View>
      <Animated.View
        style={[
          styles.back,
          styles.hidden,
          { transform: [{ rotateY: interpolateBack }] },
        ]}>
        <BackCard
          definition={definition}
          example={example}
          partOfSpeech={partOfSpeech}
        />
      </Animated.View>
      <View style={styles.rowContainer}>
        <IconButton
          icon="bookmark-plus"
          size={36}
          color={Colors.yellow}
          style={styles.iconButton}
          onPress={showSaveWordAlert}
        />
        <IconButton
          icon="rotate-3d-variant"
          size={36}
          color="red"
          style={styles.iconButton}
          onPress={handleFlip}
        />
        <IconButton
          icon="volume-high"
          size={36}
          color={Colors.lightBlue}
          style={styles.iconButton}
          onPress={() => sound.play()}
        />
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  hidden: {
    backfaceVisibility: 'hidden',
  },
  back: {
    position: 'absolute',
    top: 0,
  },
  rowContainer: {
    marginTop: 15,
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
  },
  iconButton: {
    backgroundColor: 'white',
    elevation: 5,
  },
});

export default FlashCard;
