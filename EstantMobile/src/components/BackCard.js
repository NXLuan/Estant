import React from 'react';
import { StyleSheet, View, Text } from 'react-native';
import { Colors } from '../styles/colors';

const BackCard = ({ definition, partOfSpeech, example }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.partOfSpeech}>({partOfSpeech})</Text>
      <Text style={styles.definition}>{definition}</Text>
      {example && <Text style={styles.example}>E.g. {example}</Text>}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: 'white',
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 10,
    width: 300,
    height: 300,
    elevation: 5,
    padding: 20,
  },
  partOfSpeech: {
    fontSize: 20,
  },
  definition: {
    fontSize: 20,
    fontWeight: '500',
    marginVertical: 10,
  },
  example: {
    fontSize: 16,
    fontStyle: 'italic',
  },
});

export default BackCard;
