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
import { getExercisesByGrammar, getExercisesByTopic } from '../api/ExerciseAPI';
import FillBlankGrammar from '../components/FillBankGrammar';

const PracticeScreen = ({ navigation, route }) => {
  const [data, setData] = useState([]);
  const [currentIndex, setCurrentIndex] = useState(0);
  const [isFinish, setIsFinish] = useState(false);
  useEffect(() => {
    if (route.params.topic != null) {
      getExercisesByTopic(route.params.topic)
        .then(res => setData(res.data.data))
        .catch(error => console.log(error));
    } else {
      getExercisesByGrammar(route.params.code)
        .then(res => setData(res.data.data))
        .catch(error => console.log(error));
    }
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

  const handlePrevQuestion = () => {
    setCurrentIndex(currentIndex - 1);
  };
  const handleNextQuestion = () => {
    if (currentIndex !== 9) {
      setCurrentIndex(currentIndex + 1);
    } else {
      navigation.goBack();
    }
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
          ) : data[currentIndex].type === 4 ? (
            <AudioTest
              dataQuestion={data[currentIndex]}
              id={currentIndex}
              key={currentIndex + 1}
              setData={setData}
              setCurrentIndex={setCurrentIndex}
              setIsFinish={setIsFinish}
              isFinish={isFinish}
            />
          ) : data[currentIndex].type === 6 ? (
            <FillBlankGrammar
              dataQuestion={data[currentIndex]}
              id={currentIndex}
              key={currentIndex + 1}
              setData={setData}
              setCurrentIndex={setCurrentIndex}
              setIsFinish={setIsFinish}
              isFinish={isFinish}
            />
          ) : (
            <MultipleChoice
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
        {currentIndex !== 10 && isFinish && (
          <View style={{ flexDirection: 'row', marginTop: 20 }}>
            <Button
              disabled={currentIndex === 0}
              mode="contained"
              style={{ borderRadius: 20, marginRight: 40 }}
              dark={true}
              color={Colors.primary}
              onPress={handlePrevQuestion}>
              Prev
            </Button>
            <Button
              mode="contained"
              style={{ borderRadius: 20 }}
              dark={true}
              color={Colors.primary}
              onPress={handleNextQuestion}>
              {currentIndex !== 9 ? 'Next' : 'Done'}
            </Button>
          </View>
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
