import React, { useState, useEffect } from 'react';
import { Text, View, StyleSheet, TouchableOpacity } from 'react-native';
import { Colors } from '../styles/colors';
import MainHeader from '../components/MainHeader';
import { getAllLessons } from '../api/GrammarAPI';
import Loader from '../components/Loader';

const GrammarScreen = ({ navigation }) => {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

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
  return (
    <>
      <MainHeader />
      {isLoading ? (
        <View style={{ flex: 1 }}>
          <Loader />
        </View>
      ) : (
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
                        <Text style={{ color: 'white', fontWeight: 'bold' }}>
                          {index + 1}
                        </Text>
                      </View>
                      <Text style={styles.lessonTitle}>{lesson.name}</Text>
                    </TouchableOpacity>
                  ))}
              </View>
            ))}
        </View>
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
});
export default GrammarScreen;
