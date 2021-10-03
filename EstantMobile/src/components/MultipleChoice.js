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

const MultipleChoice = ({ dataQuestion, id, setData }) => {
  const { choices, example, question, correctAnswer, word } = dataQuestion;

  const [userAnswer, setUserAnswer] = useState(null);

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = userAnswer;
      console.log(newData);
      return newData;
    });
  };
  return (
    <>
      <Text style={styles.questionHeader}>Listen and type the word</Text>
      {example != null && <Text style={styles.questionBody}>"{example}"</Text>}
      {word != null && <Text style={styles.word}>{word}</Text>}
      <View style={styles.choiceContainer}>
        {choices.map((choice, index) => (
          <TouchableOpacity
            key={index}
            style={[styles.choice]}
            onPress={() => setUserAnswer(index)}>
            <Icon
              name={userAnswer === index ? 'circle-slice-8' : 'circle-outline'}
              size={24}
              color={Colors.primary}
            />
            <Text style={styles.choiceText}>{choice}</Text>
          </TouchableOpacity>
        ))}
        {/* <TouchableOpacity
          style={[styles.choice, styles.correct]}
          onPress={() => setUserAnswer(index)}>
          <Icon
            name={userAnswer === 0 ? 'circle-slice-8' : 'circle-outline'}
            size={24}
            color={Colors.primary}
          />
          <Text style={styles.choiceText}>banker</Text>
          <Icon name="checkbox-marked-circle" size={24} color={Colors.green} />
        </TouchableOpacity>
        <TouchableOpacity
          style={[styles.choice, styles.incorrect]}
          onPress={() => setUserAnswer(index)}>
          <Icon
            name={userAnswer === 0 ? 'circle-slice-8' : 'circle-outline'}
            size={24}
            color={Colors.primary}
          />
          <Text style={styles.choiceText}>banker</Text>
          <Icon name="close-circle" size={24} color="red" />
        </TouchableOpacity> */}
      </View>

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
    borderRadius: 20,
  },
});
export default MultipleChoice;
