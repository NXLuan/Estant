import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  TouchableOpacity,
  Keyboard,
  TouchableWithoutFeedback,
  TextInput,
  ActivityIndicator,
  ScrollView,
} from 'react-native';
import { Colors } from '../styles/colors';
import MainHeader from '../components/MainHeader';
import { getAllLessons, checkSpellAndGrammar } from '../api/GrammarAPI';
import Loader from '../components/Loader';
import { Button } from 'react-native-paper';

const GrammarScreen = ({ navigation }) => {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const [isShowResult, setIsShowResult] = useState(false);
  const [text, setText] = useState('');
  const [isChecking, setIsChecking] = useState(false);
  const [result, setResult] = useState([]);
  useEffect(() => {
    getAllLessons()
      .then(res => {
        setIsLoading(false);
        setData(res.data.data);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);

  const handleCheckGrammar = () => {
    console.log(text);
    if (text === '') return;
    setIsChecking(true);
    checkSpellAndGrammar(text)
      .then(res => {
        setIsChecking(false);
        if (res.data.data != null) {
          setResult(res.data.data);
          setIsShowResult(true);
        } else {
          setText('');
        }
      })
      .catch(error => {
        console.log(error);
      });
  };

  function getCorrectSentence() {
    let newSentence = text;

    for (let i = result.length - 1; i > 0; i--) {
      newSentence =
        newSentence.slice(0, result[i].offset) +
        result[i].replacement +
        newSentence.slice(
          result[i].offset + result[i].length,
          newSentence.length,
        );
    }
    return newSentence.charAt(0).toUpperCase() + newSentence.slice(1);
  }

  const handleResetGrammarCheck = () => {
    setText('');
    setIsShowResult(false);
  };
  return (
    <>
      <MainHeader />
      {isLoading ? (
        <View style={{ flex: 1 }}>
          <Loader />
        </View>
      ) : (
        <TouchableWithoutFeedback onPress={() => Keyboard.dismiss()}>
          <ScrollView>
            <View style={styles.container}>
              <Text style={styles.title}>Grammar Check</Text>
              <TextInput
                style={styles.input}
                numberOfLines={3}
                elevation={3}
                value={text}
                onChangeText={setText}
                editable={!isShowResult}
              />
              {!isShowResult ? (
                <Button
                  loading={isChecking}
                  uppercase={false}
                  mode="contained"
                  onPress={handleCheckGrammar}
                  style={{
                    alignSelf: 'center',
                    width: '35%',
                    backgroundColor: Colors.primary,
                    marginTop: 20,
                    marginBottom: 10,
                    borderRadius: 20,
                  }}>
                  Check
                </Button>
              ) : (
                <View style={{ marginTop: 15 }}>
                  <Text
                    style={{
                      color: 'red',
                      fontWeight: 'bold',
                      fontSize: 16,
                      alignSelf: 'center',
                    }}>
                    Error
                  </Text>
                  {result.map((error, index) => (
                    <View key={index}>
                      <Text
                        style={{
                          color: 'red',
                          fontWeight: 'bold',
                          fontSize: 16,
                        }}>
                        {index + 1}.{' "'}
                        {text.slice(error.offset, error.offset + error.length)}"
                      </Text>
                      <Text>{error.message}</Text>
                    </View>
                  ))}
                  <Text
                    style={{
                      color: 'green',
                      fontWeight: 'bold',
                      fontSize: 16,
                      alignSelf: 'center',
                      marginVertical: 5,
                    }}>
                    Correct sentence
                  </Text>
                  <Text
                    style={{
                      alignSelf: 'center',
                      fontSize: 16,
                      fontWeight: 'bold',
                    }}>
                    {getCorrectSentence()}
                  </Text>
                  <Button
                    loading={isChecking}
                    mode="contained"
                    onPress={handleResetGrammarCheck}
                    style={{
                      alignSelf: 'center',
                      width: '35%',
                      backgroundColor: Colors.primary,
                      marginTop: 20,
                      marginBottom: 10,
                      borderRadius: 20,
                    }}>
                    got it
                  </Button>
                </View>
              )}
            </View>
            <View style={styles.container}>
              <Text style={styles.title}>Lessons</Text>
              {data != null &&
                data.length > 0 &&
                data.map((item, index) => (
                  <View style={styles.subContainer} key={index}>
                    <Text style={styles.subHeader}>{item.title}</Text>
                    {item.lessons != null &&
                      item.lessons.length > 0 &&
                      item.lessons.map((lesson, index) => (
                        <TouchableOpacity
                          style={styles.lessonItem}
                          key={index}
                          onPress={() =>
                            navigation.navigate('Lesson', { code: lesson.code })
                          }>
                          <View style={styles.circleNumber}>
                            <Text
                              style={{ color: 'white', fontWeight: 'bold' }}>
                              {index + 1}
                            </Text>
                          </View>
                          <Text style={styles.lessonTitle}>{lesson.name}</Text>
                        </TouchableOpacity>
                      ))}
                  </View>
                ))}
            </View>
          </ScrollView>
        </TouchableWithoutFeedback>
      )}
    </>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#fff',
    paddingHorizontal: 15,
    paddingVertical: 10,
    marginBottom: 10,
  },
  title: {
    fontSize: 20,
    fontWeight: '700',
    marginBottom: 20,
  },
  subContainer: {
    alignItems: 'center',
    marginBottom: 30,
  },
  subHeader: {
    color: Colors.primary,
    fontSize: 18,
    fontWeight: 'bold',
    marginBottom: 10,
  },
  lessonItem: {
    flexDirection: 'row',
    elevation: 5,
    backgroundColor: 'white',
    width: '90%',
    padding: 10,
    borderRadius: 10,
    marginVertical: 5,
    alignItems: 'center',
  },
  lessonTitle: {
    fontSize: 16,
    marginLeft: 10,
    fontWeight: '500',
  },
  circleNumber: {
    backgroundColor: Colors.primary,
    borderRadius: 15,
    color: 'white',
    width: 30,
    height: 30,
    alignItems: 'center',
    justifyContent: 'center',
  },
  input: {
    backgroundColor: 'white',
    paddingHorizontal: 10,
    borderRadius: 5,
    height: 70,
    textAlignVertical: 'top',
  },
});
export default GrammarScreen;
