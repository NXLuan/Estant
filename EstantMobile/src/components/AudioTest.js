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
}) => {
  const { audio, question, correctAnswer } = dataQuestion;

  const sound = new Sound(audio);

  const [userAnswer, setUserAnswer] = useState('');

  const handleSubmit = () => {
    setData(data => {
      let newData = [...data];
      newData[id].userAnswer = userAnswer;
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
        maxLength={15}
        mode="outlined"
        multiline={false}
        style={styles.input}
        value={userAnswer}
        onChangeText={setUserAnswer}
        label="Your answer"
      />

      <Button
        style={styles.button}
        mode="contained"
        dark={true}
        color={Colors.primary}
        onPress={handleSubmit}>
        {id < 9 ? 'Next' : 'Submit'}
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
