import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Sound from 'react-native-sound';

const WordCard = ({ word, phonetic, audioURL }) => {
  const sound = new Sound(audioURL);
  return (
    <View style={styles.container}>
      <Text style={styles.word}>{word}</Text>
      <View style={styles.rowPronouce}>
        <IconButton
          icon="volume-high"
          size={16}
          color="black"
          onPress={() => sound.play()}
        />
        <Text style={styles.phonetic}>/ {phonetic} /</Text>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: 'white',
    borderRadius: 10,
    paddingVertical: 10,
    paddingHorizontal: 15,
  },
  word: {
    fontSize: 20,
    fontWeight: 'bold',
    color: Colors.blue,
    marginLeft: 10,
  },
  rowPronouce: {
    marginBottom: 15,
    flexDirection: 'row',
    alignItems: 'center',
  },
  phonetic: {
    fontSize: 16,
  },
});
export default WordCard;
