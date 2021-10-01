import React from 'react';
import { View, StyleSheet, Text } from 'react-native';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const WordMeaning = ({ meaning, id }) => {
  const { definitions, partOfSpeech } = meaning;
  const Definition = ({ data }) => {
    const { definition, example } = data;
    return (
      <View style={styles.definitionContainer}>
        <Icon name="circle-small" size={36} />
        <View style={styles.detail}>
          <Text style={styles.meaning}>{definition}</Text>
          {example != null && (
            <Text style={styles.example}>E.g. {example}</Text>
          )}
        </View>
      </View>
    );
  };

  return (
    <View style={{ marginBottom: 10 }}>
      <View style={{ flexDirection: 'row', alignItems: 'center' }}>
        <View style={styles.circleNumber}>
          <Text style={styles.number}>{id}</Text>
        </View>
        <Text style={styles.partOfSpeech}>{partOfSpeech}</Text>
      </View>
      {definitions != null &&
        definitions.length > 0 &&
        definitions.map((item, index) => (
          <Definition data={item} key={index} />
        ))}
    </View>
  );
};

const styles = StyleSheet.create({
  circleNumber: {
    backgroundColor: Colors.blue,
    borderRadius: 15,
    color: 'white',
    width: 30,
    height: 30,
    alignItems: 'center',
    justifyContent: 'center',
  },
  number: {
    fontWeight: 'bold',
    color: 'white',
  },
  partOfSpeech: {
    fontWeight: 'bold',
    fontStyle: 'italic',
    color: Colors.blue,
    fontSize: 18,
    marginLeft: 10,
  },
  definitionContainer: {
    flexDirection: 'row',
    marginBottom: 10,
  },
  detail: {
    paddingRight: 35,
    paddingTop: 4,
  },
  meaning: {
    fontSize: 18,
    fontWeight: 'bold',
    marginBottom: 5,
  },
  example: {
    fontSize: 18,
    fontStyle: 'italic',
  },
});

export default WordMeaning;
