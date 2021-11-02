import React, { useState } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Button, TextInput } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const FillBlankGrammar = ({
  dataQuestion,
  id,
  setData,
  setCurrentIndex,
  setIsFinish,
  isFinish,
}) => {
  const { sentence, question, correctAnswer, userAnswer } = dataQuestion;
  const [answer, setAnswer] = useState('');

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = answer;
      return newData;
    });
    setCurrentIndex(id + 1);
    if (id === 9) setIsFinish(true);
  };

  return (
    <>
      <Text style={styles.questionHeader}>{question}</Text>
      <View style={styles.questionBody}>
        <Text style={styles.sentence}>{sentence}</Text>
        <TextInput
          editable={!isFinish}
          maxLength={15}
          mode="outlined"
          multiline={false}
          style={styles.input}
          value={isFinish ? userAnswer : answer}
          onChangeText={setAnswer}
          label="Your answer"
        />
      </View>

      {isFinish && (
        <View style={styles.questionBody}>
          <Text style={styles.answerText}>{correctAnswer}</Text>
        </View>
      )}
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
  sentence: {
    fontSize: 20,
    alignItems: 'center',
    textAlign: 'center',
    marginBottom: 30,
    fontStyle: 'italic',
    paddingHorizontal: 10,
  },
  input: {
    width: '80%',
    textAlign: 'center',
    fontSize: 20,
    marginVertical: 20,
  },
  questionHeader: {
    fontSize: 24,
    marginVertical: 20,
    fontWeight: '600',
  },
  questionBody: {
    alignItems: 'center',
    marginBottom: 30,
    width: '100%',
  },
  button: {
    marginTop: 30,
    borderRadius: 20,
    marginBottom: 20,
  },
  answerText: {
    fontSize: 28,
    fontWeight: 'bold',
    color: Colors.blue,
  },
});
export default FillBlankGrammar;
