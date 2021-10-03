import React, { useState, useEffect } from 'react';
import { Text, View, TextInput, StyleSheet, ScrollView } from 'react-native';
import { ProgressBar } from 'react-native-paper';
import FillBlank from '../components/FillBlank';
import MultipleChoice from '../components/MultipleChoice';
import AudioTest from '../components/AudioTest';
import { Colors } from '../styles/colors';

const AccountScreen = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    setData([
      {
        missingWord: 'f___nci_l',
        definition: 'relating to finance.',
        partOfSpeech: 'adjective',
        type: 1,
        question: 'Fill in the blanks',
        correctAnswer: 'financial',
      },
      {
        choices: ['accumulation', 'deposit', 'financial', 'monetary'],
        example: 'documents with little or no ________ value',
        type: 2,
        question: 'Choose the most suitable word',
        correctAnswer: 3,
      },
      {
        choices: [
          'arranged or operating between banks.',
          'a sum of money paid into a bank or building society account.',
          'the management of large amounts of money, especially by governments or large companies.',
          'a person who manages or owns a bank or group of banks.',
        ],
        word: 'interbank',
        type: 3,
        question: 'Choose the meaning of this word',
        correctAnswer: 0,
      },
      {
        audio:
          'https://ssl.gstatic.com/dictionary/static/sounds/20200429/accumulation--_gb_1.8.mp3',
        type: 4,
        question: 'Write the correct word',
        correctAnswer: 'accumulation',
      },
    ]);
  }, []);
  return (
    <ScrollView
      contentContainerStyle={{
        flex: 1,
        backgroundColor: Colors.primary,
        padding: 15,
      }}>
      <View
        style={{
          flexDirection: 'row',
          alignItems: 'flex-end',
          marginBottom: 15,
        }}>
        <Text style={[styles.bigHeader, { fontSize: 28 }]}>Question 1</Text>
        <Text style={[styles.bigHeader, { fontSize: 24 }]}>/10</Text>
      </View>
      <View style={styles.subContainer}>
        {data.length > 0 && (
          //<FillBlank dataQuestion={data[0]} id={0} setData={setData} />
          //<MultipleChoice dataQuestion={data[2]} id={2} setData={setData} />
          <AudioTest dataQuestion={data[3]} id={3} setData={setData} />
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
});
export default AccountScreen;
