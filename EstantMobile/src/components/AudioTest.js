import React, { useState } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Button, IconButton, TextInput } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import Sound from 'react-native-sound';

const AudioTest = ({
  dataQuestion,
  id,
  setData,
  setCurrentIndex,
  setIsFinish,
  isFinish,
}) => {
  const { audio, question, correctAnswer, userAnswer } = dataQuestion;

  const sound = new Sound(audio);

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
      <IconButton
        icon="volume-high"
        size={36}
        color={Colors.lightBlue}
        style={styles.iconButton}
        onPress={() => sound.play()}
      />
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
      {isFinish && <Text style={styles.answerText}>{correctAnswer}</Text>}
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
  answerText: {
    fontSize: 28,
    fontWeight: 'bold',
    color: Colors.blue,
    marginBottom: 20,
  },
  questionHeader: {
    fontSize: 22,
    marginVertical: 20,
    fontWeight: '600',
  },
  button: {
    marginTop: 10,
    borderRadius: 20,
    marginBottom: 20,
  },
  iconButton: {
    backgroundColor: 'white',
    elevation: 5,
  },
  input: {
    width: '80%',
    textAlign: 'center',
    fontSize: 20,
    marginVertical: 20,
  },
});
export default AudioTest;
