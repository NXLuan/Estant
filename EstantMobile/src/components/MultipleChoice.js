import React, { useState } from 'react';
import {
  StyleSheet,
  Text,
  View,
  TextInput,
  TouchableOpacity,
} from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const MultipleChoice = ({
  dataQuestion,
  id,
  setData,
  setCurrentIndex,
  setIsFinish,
  isFinish,
}) => {
  const { choices, example, question, correctAnswer, word, userAnswer } =
    dataQuestion;

  const [answer, setAnswer] = useState(userAnswer);

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = answer;
      return newData;
    });
    setCurrentIndex(id + 1);
    if (id === 9) setIsFinish(true);
  };

  function renderStyleAnswer(index) {
    if (isFinish) {
      if (index === correctAnswer) return styles.correct;
      if (userAnswer === index && index !== correctAnswer)
        return styles.incorrect;
    }
    return {};
  }
  function renderIconAnswer(index) {
    if (isFinish) {
      if (index === correctAnswer)
        return (
          <Icon name="checkbox-marked-circle" size={24} color={Colors.green} />
        );
      if (userAnswer === index && index !== correctAnswer)
        return <Icon name="close-circle" size={24} color="red" />;
    }
    return <></>;
  }
  return (
    <>
      <Text style={styles.questionHeader}>{question}</Text>
      {example != null && <Text style={styles.questionBody}>"{example}"</Text>}
      {word != null && <Text style={styles.word}>{word}</Text>}
      <View style={styles.choiceContainer}>
        {choices.map((choice, index) => (
          <TouchableOpacity
            disabled={isFinish}
            key={index}
            style={[styles.choice, renderStyleAnswer(index)]}
            onPress={() => setAnswer(index)}>
            <Icon
              name={answer === index ? 'circle-slice-8' : 'circle-outline'}
              size={24}
              color={Colors.primary}
            />
            <Text style={styles.choiceText}>{choice}</Text>
            {renderIconAnswer(index)}
          </TouchableOpacity>
        ))}
      </View>
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
  questionHeader: {
    fontSize: 22,
    marginVertical: 20,
    fontWeight: '600',
  },
  questionBody: {
    fontSize: 20,
    alignItems: 'center',
    textAlign: 'center',
    marginBottom: 30,
    fontStyle: 'italic',
    paddingHorizontal: 10,
  },
  word: {
    fontSize: 28,
    alignItems: 'center',
    textAlign: 'center',
    marginBottom: 30,
    color: Colors.blue,
    fontWeight: 'bold',
  },
  choiceContainer: {
    width: '100%',
    paddingHorizontal: 20,
    justifyContent: 'flex-start',
  },
  choice: {
    flexDirection: 'row',
    alignItems: 'center',
    borderRadius: 20,
    elevation: 5,
    backgroundColor: 'white',
    padding: 15,
    marginBottom: 20,
  },
  choiceText: {
    marginLeft: 10,
    fontSize: 16,
    paddingRight: 10,
    flex: 1,
  },
  correct: {
    backgroundColor: Colors.lightGreen,
    borderWidth: 1,
    borderColor: Colors.green,
  },
  incorrect: {
    backgroundColor: Colors.lightRed,
    borderWidth: 1,
    borderColor: 'red',
  },
  button: {
    marginTop: 10,
    marginBottom: 20,
    borderRadius: 20,
  },
});
export default MultipleChoice;
