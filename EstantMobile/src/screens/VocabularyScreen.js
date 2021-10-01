import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  TextInput,
  FlatList,
  Image,
  TouchableOpacity,
} from 'react-native';
import MainHeader from '../components/MainHeader';
import { Colors } from '../styles/colors';
import {
  IconButton,
  Button,
  Card,
  ActivityIndicator,
} from 'react-native-paper';
import axios from 'axios';
import { getAllTopic } from '../api/VocabularyAPI';
import Loader from '../components/Loader';

const VocabularyScreen = ({ navigation }) => {
  const [topics, setTopics] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  useEffect(() => {
    getAllTopic()
      .then(res => {
        setIsLoading(false);
        setTopics(res.data.data);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);

  function handleOnPressTopic(title) {
    navigation.navigate('Topic', { name: title });
  }

  const renderTopicItem = ({ item }) => {
    return (
      <TouchableOpacity
        style={styles.topicItem}
        onPress={() => handleOnPressTopic(item.title)}>
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
          {isLoading ? (
            <Loader />
          ) : (
            <FlatList
              data={topics}
              keyExtractor={item => item.title}
              renderItem={renderTopicItem}
              numColumns={4}
            />
          )}
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
