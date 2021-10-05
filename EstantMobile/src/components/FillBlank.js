import React, { useState } from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const FillBlank = ({
  dataQuestion,
  id,
  setData,
  setCurrentIndex,
  setIsFinish,
  isFinish,
}) => {
  const { missingWord, definition, question, correctAnswer, userAnswer } =
    dataQuestion;
  const [letters, setLetters] = useState(
    missingWord.split('').map(letter => (letter === '_' ? '' : letter)),
  );

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = letters;
      return newData;
    });
    setCurrentIndex(id + 1);
    if (id === 9) setIsFinish(true);
  };
  function renderColorText(index) {
    if (isFinish) {
      if (userAnswer[index] === correctAnswer[index])
        return { color: Colors.green };
      return { color: 'red' };
    }
    return {};
  }
  return (
    <>
      <Text style={styles.questionHeader}>{question}</Text>
      <View style={styles.questionBody}>
        {missingWord.split('').map((letter, index) =>
          letter !== '_' ? (
            <Text style={styles.letter} key={index}>
              {letter}
            </Text>
          ) : (
            <TextInput
              editable={!isFinish}
              key={index}
              maxLength={1}
              style={[styles.letter, styles.blank, renderColorText(index)]}
              value={isFinish ? userAnswer[index] : letters[index]}
              onChangeText={e => {
                let newLetters = [...letters];
                newLetters[index] = e;
                setLetters(newLetters);
              }}
            />
          ),
        )}
      </View>

      {isFinish && (
        <View style={styles.questionBody}>
          <Text style={styles.answerText}>{correctAnswer}</Text>
        </View>
      )}
      <Text style={styles.definition}>{definition}</Text>
      {!isFinish && (
        <Button
          style={styles.button}
          mode="contained"
          dark={true}
          color={Colors.primary}
          onPress={handleSubmit}>
          {id < 9 ? 'Next' : 'Submit'}
        </Button>
      )}
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
  answerText: {
    fontSize: 28,
    fontWeight: 'bold',
    color: Colors.blue,
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
    marginBottom: 20,
  },
});
export default FillBlank;
