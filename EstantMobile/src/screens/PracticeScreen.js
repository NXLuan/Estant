import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  TextInput,
  StyleSheet,
  ScrollView,
  FlatList,
} from 'react-native';
import { ProgressBar, Button } from 'react-native-paper';
import FillBlank from '../components/FillBlank';
import MultipleChoice from '../components/MultipleChoice';
import AudioTest from '../components/AudioTest';
import { Colors } from '../styles/colors';

const PracticeScreen = () => {
  const [data, setData] = useState([]);
  const [currentIndex, setCurrentIndex] = useState(0);
  const [isFinish, setIsFinish] = useState(false);
  useEffect(() => {
    setData([
      {
        choices: [
          'an act of giving one thing and receiving another (especially of the same kind) in return.',
          'a person who manages or owns a bank or group of banks.',
          'having or relating to the role of observing and directing an activity or a person.',
          'relating to finance.',
        ],
        word: 'financial',
        type: 3,
        question: 'Choose the meaning of this word',
        correctAnswer: 3,
      },
      {
        audio:
          'https://ssl.gstatic.com/dictionary/static/sounds/20200429/exchange--_gb_1.mp3',
        type: 4,
        question: 'Write the correct word',
        correctAnswer: 'exchange',
      },
      {
        choices: ['accumulation', 'interbank', 'finance', 'exchange'],
        example: 'the ____________ of wealth',
        type: 2,
        question: 'Choose the most suitable word',
        correctAnswer: 0,
      },
      {
        missingWord: 'f_na__e',
        definition:
          'the management of large amounts of money, especially by governments or large companies.',
        type: 1,
        question: 'Fill in the blanks',
        correctAnswer: 'finance',
      },
      {
        missingWord: 's_p__v_so_y',
        definition:
          'having or relating to the role of observing and directing an activity or a person.',
        type: 1,
        question: 'Fill in the blanks',
        correctAnswer: 'supervisory',
      },
      {
        audio:
          'https://ssl.gstatic.com/dictionary/static/sounds/20200429/banker--_gb_1.mp3',
        type: 4,
        question: 'Write the correct word',
        correctAnswer: 'banker',
      },
      {
        choices: ['banker', 'interbank', 'credit', 'accumulation'],
        example: 'an _________ transfer',
        type: 2,
        question: 'Choose the most suitable word',
        correctAnswer: 1,
      },
      {
        audio:
          'https://ssl.gstatic.com/dictionary/static/sounds/20200429/monetary--_gb_1.mp3',
        type: 4,
        question: 'Write the correct word',
        correctAnswer: 'monetary',
      },
      {
        choices: ['banker', 'financial', 'credit', 'deposit'],
        example: "I've got unlimited ______",
        type: 2,
        question: 'Choose the most suitable word',
        correctAnswer: 2,
      },
      {
        choices: [
          'a sum of money paid into a bank or building society account.',
          'the ability of a customer to obtain goods or services before payment, based on the trust that payment will be made in the future.',
          'an act of giving one thing and receiving another (especially of the same kind) in return.',
          'the management of large amounts of money, especially by governments or large companies.',
        ],
        word: 'deposit',
        type: 3,
        question: 'Choose the meaning of this word',
        correctAnswer: 0,
      },
    ]);
  }, []);

  function checkResult(item) {
    let result = false;
    if (item.userAnswer != null) {
      if (item.type === 1) {
        if (item.userAnswer.join('') === item.correctAnswer) result = true;
      } else if (item.userAnswer === item.correctAnswer) result = true;
    }
    return result;
  }
  function calculateScore() {
    let score = 0;
    for (let i = 0; i < data.length; i++) {
      if (checkResult(data[i])) score++;
    }
    return score;
  }
  function renderResultItem(item, index) {
    let result = checkResult(item);
    return (
      <View
        style={{ flexDirection: 'row', alignItems: 'center', marginBottom: 5 }}
        key={index}>
        <View
          style={[
            styles.circleNumber,
            { backgroundColor: result ? Colors.green : 'red' },
          ]}>
          <Text style={styles.number}>{index + 1}</Text>
        </View>
        <Text
          style={[styles.resultItem, { color: result ? Colors.green : 'red' }]}>
          {result ? 'Correct' : 'Incorrect'}
        </Text>
      </View>
    );
  }

  const handleReview = () => {
    setCurrentIndex(0);
  };

  return (
    <ScrollView
      contentContainerStyle={{
        flexGrow: 1,
        backgroundColor: Colors.primary,
        padding: 15,
        paddingBottom: 0,
      }}>
      <View
        style={{
          flexDirection: 'row',
          alignItems: 'flex-end',
          marginBottom: 15,
        }}>
        <Text style={[styles.bigHeader, { fontSize: 28 }]}>
          {isFinish ? 'Test result' : 'Question ' + (currentIndex + 1)}
        </Text>
        {!isFinish && (
          <Text style={[styles.bigHeader, { fontSize: 24 }]}>/10</Text>
        )}
      </View>
      <View style={styles.subContainer}>
        {data.length > 0 &&
          currentIndex < 10 &&
          (data[currentIndex].type === 1 ? (
            <FillBlank
              dataQuestion={data[currentIndex]}
              id={currentIndex}
              key={currentIndex + 1}
              setData={setData}
              setCurrentIndex={setCurrentIndex}
              setIsFinish={setIsFinish}
              isFinish={isFinish}
            />
          ) : data[currentIndex].type === 2 || data[currentIndex].type === 3 ? (
            <MultipleChoice
              dataQuestion={data[currentIndex]}
              id={currentIndex}
              key={currentIndex + 1}
              setData={setData}
              setCurrentIndex={setCurrentIndex}
              setIsFinish={setIsFinish}
              isFinish={isFinish}
            />
          ) : (
            <AudioTest
              dataQuestion={data[currentIndex]}
              id={currentIndex}
              key={currentIndex + 1}
              setData={setData}
              setCurrentIndex={setCurrentIndex}
              setIsFinish={setIsFinish}
              isFinish={isFinish}
            />
          ))}
        {currentIndex === 10 && (
          <>
            <Text style={styles.scoreText}>YOUR SCORE</Text>
            <View style={{ marginBottom: 20, flexDirection: 'row' }}>
              <Text style={[styles.score, { color: Colors.green }]}>
                {calculateScore()}
              </Text>
              <Text style={[styles.score, { color: Colors.blue }]}> / 10</Text>
            </View>
            <View style={{ alignSelf: 'flex-start', marginLeft: '35%' }}>
              {data.map((item, index) => renderResultItem(item, index))}
            </View>
            <Button
              mode="contained"
              style={{ borderRadius: 10, marginTop: 20 }}
              dark={true}
              color={Colors.primary}
              onPress={handleReview}>
              Review
            </Button>
          </>
        )}
      </View>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  bigHeader: {
    fontWeight: 'bold',
    color: 'white',
  },
  question: {
    fontSize: 20,
  },
  subContainer: {
    flex: 1,
    borderRadius: 15,
    backgroundColor: 'white',
    alignSelf: 'center',
    width: '100%',
    alignItems: 'center',
  },
  scoreText: {
    marginTop: 10,
    fontSize: 16,
    letterSpacing: 4,
    fontWeight: '500',
  },
  score: {
    fontWeight: 'bold',
    fontSize: 52,
  },
  resultItem: {
    fontSize: 20,
    fontWeight: '600',
    marginLeft: 10,
  },
  circleNumber: {
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
    fontSize: 16,
  },
});
export default PracticeScreen;
