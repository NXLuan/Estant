import React from 'react';
import { StyleSheet, View, Text } from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';

const FrontCard = ({ word, phonetic }) => {
  return (
    <View style={styles.container} onPress={() => console.log(123)}>
      <Text style={styles.word}>{word}</Text>
      <Text style={styles.phonetic}>/ {phonetic} /</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: Colors.primary,
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 10,
    width: 300,
    height: 300,
    elevation: 10,
  },
  word: {
    fontSize: 28,
    fontWeight: 'bold',
    color: 'white',
  },
  phonetic: {
    fontSize: 20,
    color: 'white',
  },
});

export default FrontCard;
