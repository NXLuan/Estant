import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  TextInput,
  FlatList,
  Image,
  ScrollView,
  TouchableWithoutFeedback,
  TouchableHighlight,
  TouchableOpacity,
} from 'react-native';
import MainHeader from '../components/MainHeader';
import { Colors } from '../styles/colors';
import { IconButton, Button, Card } from 'react-native-paper';
import axios from 'axios';
import { getAllTopic } from '../api/VocabularyAPI';

const VocabularyScreen = () => {
  // const topics = [
  //   {
  //     title: 'Airline',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/airlines.png',
  //   },
  //   {
  //     title: 'Banking',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/banking.png',
  //   },
  //   {
  //     title: 'Computers',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/computers.png',
  //   },
  //   {
  //     title: 'Financial',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/financial_statements.png',
  //   },
  //   {
  //     title: 'Interview',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/applying.png',
  //   },
  //   {
  //     title: 'Marketing',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/marketing.png',
  //   },
  //   {
  //     title: 'Media',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/media.png',
  //   },
  //   {
  //     title: 'Museum',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/museums.png',
  //   },
  //   {
  //     title: 'Shopping',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/shopping.png',
  //   },
  //   {
  //     title: 'Travel',
  //     imageUrl:
  //       'https://tienganhmoingay.com/static/Vocabulary/images/topic_images/travel.png',
  //   },
  // ];

  const [topics, setTopics] = useState([]);

  useEffect(() => {
    getAllTopic()
      .then(res => {
        setTopics(res.data.data);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);

  const handleOnPressTopic = () => {
    console.log(123);
  };

  const renderTopicItem = ({ item }) => {
    return (
      <TouchableOpacity style={styles.topicItem} onPress={handleOnPressTopic}>
        <Image style={styles.imgSize} source={{ uri: item.imageUrl }} />
        <Text style={{ fontWeight: '500' }}>{item.title}</Text>
      </TouchableOpacity>
    );
  };

  return (
    <>
      <MainHeader />
      <View style={{ flex: 1 }}>
        <View style={styles.subContainer}>
          <Text style={styles.title}>Dictionary</Text>
          <View style={{ flexDirection: 'row', alignItems: 'center' }}>
            <TextInput style={styles.searchInput} placeholder="Search" />
            <IconButton
              icon="magnify"
              color={Colors.primary}
              size={24}
              style={{ marginLeft: 10 }}
              onPress={() => console.log('123')}
            />
          </View>
        </View>

        <View style={styles.subContainer}>
          <Text style={styles.title}>My vocabulary</Text>
          <View style={{ flexDirection: 'row', alignItems: 'center' }}>
            <Button
              style={styles.btn}
              icon="bookmark-multiple"
              mode="contained"
              uppercase={false}
              color={Colors.blue}
              onPress={() => console.log('Pressed')}>
              Saved Words
            </Button>
            <Button
              style={styles.btn}
              icon="text-box-search-outline"
              mode="contained"
              uppercase={false}
              color={Colors.green}
              onPress={() => console.log('Pressed')}>
              Searched Words
            </Button>
          </View>
        </View>

        <View style={[styles.subContainer, { flex: 1, marginBottom: 0 }]}>
          <Text style={styles.title}>Topics</Text>
          <FlatList
            data={topics}
            keyExtractor={item => item.title}
            renderItem={renderTopicItem}
            numColumns={4}
          />
        </View>
      </View>
    </>
  );
};

const styles = StyleSheet.create({
  subContainer: {
    backgroundColor: '#fff',
    paddingHorizontal: 15,
    paddingVertical: 10,
    marginBottom: 10,
  },
  title: {
    fontSize: 20,
    fontWeight: '700',
    marginBottom: 10,
  },
  searchInput: {
    flex: 1,
    height: 40,
    backgroundColor: Colors.lightGray,
    paddingVertical: 10,
    paddingHorizontal: 15,
    fontSize: 16,
    borderRadius: 20,
    marginBottom: 10,
  },
  btn: {
    flex: 1,
    paddingVertical: 5,
    marginHorizontal: 5,
    marginBottom: 10,
    borderRadius: 10,
  },
  imgSize: {
    width: 70,
    height: 70,
  },
  topicItem: {
    alignItems: 'center',
    margin: 10,
  },
});
export default VocabularyScreen;
