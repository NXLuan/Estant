import React, { useState } from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const FillBlank = ({ dataQuestion, id, setData }) => {
  const { missingWord, definition, question, correctAnswer } = dataQuestion;
  const [letters, setLetters] = useState(
    missingWord.split('').map(letter => (letter === '_' ? '' : letter)),
  );

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = letters;
      console.log(newData);
      return newData;
    });
  };
  return (
    <>
      <Text style={styles.questionHeader}>{question}</Text>
      {/* <View style={{ flexDirection: 'row', alignItems: 'center' }}>
        <Icon name="checkbox-marked-circle" size={24} color={Colors.green} />
        <Text style={styles.resultText}>Correct</Text>
      </View> */}
      <View style={styles.questionBody}>
        {missingWord.split('').map((letter, index) =>
          letter !== '_' ? (
            <Text style={styles.letter} key={index}>
              {letter}
            </Text>
          ) : (
            <TextInput
              key={index}
              maxLength={1}
              style={[styles.letter, styles.blank, { color: 'red' }]}
              value={letters[index]}
              onChangeText={e => {
                let newLetters = [...letters];
                newLetters[index] = e;
                setLetters(newLetters);
              }}
            />
          ),
        )}
      </View>
      <Text style={styles.definition}>{definition}</Text>
      <Button
        style={styles.button}
        mode="contained"
        dark={true}
        color={Colors.primary}
        onPress={handleSubmit}>
        Submit
      </Button>
    </>
  );
};

const styles = StyleSheet.create({
  letter: {
    width: 25,
    fontSize: 28,
    fontWeight: 'bold',
    textAlign: 'center',
    marginHorizontal: 2,
  },
  blank: {
    color: Colors.primary,
    borderBottomWidth: 1,
    marginTop: 1,
  },
  questionHeader: {
    fontSize: 24,
    marginVertical: 20,
    fontWeight: '600',
  },
  questionBody: {
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 30,
  },
  partOfSpeech: {
    fontSize: 20,
    fontStyle: 'italic',
  },
  definition: {
    fontSize: 20,
    paddingHorizontal: 20,
    textAlign: 'justify',
  },
  button: {
    marginTop: 30,
    borderRadius: 20,
  },
  resultText: {
    fontSize: 20,
    fontWeight: 'bold',
    marginLeft: 5,
    color: Colors.green,
  },
});
export default FillBlank;
