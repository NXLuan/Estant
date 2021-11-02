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
import { IconButton, Button, ActivityIndicator } from 'react-native-paper';
import { getAllTopic, searchWord } from '../api/VocabularyAPI';
import Loader from '../components/Loader';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const VocabularyScreen = ({ navigation }) => {
  const [topics, setTopics] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  const [isSearching, setIsSearching] = useState(false);
  const [word, setWord] = useState('');
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

  const handleSearchWord = () => {
    setIsSearching(true);
    console.log(word);
    searchWord(word)
      .then(res => {
        setIsSearching(false);
        const { data } = res.data;
        if (data != null) {
          navigation.navigate('Meanings', { dataWord: data });
        } else {
          setWord('');
        }
      })
      .catch(error => {
        console.log(error);
      });
  };

  return (
    <>
      <MainHeader />
      {isLoading ? (
        <View style={{ flex: 1 }}>
          <Loader />
        </View>
      ) : (
        <View style={{ flex: 1 }}>
          <View style={styles.subContainer}>
            <Text style={styles.title}>Dictionary</Text>
            <View
              style={{
                flexDirection: 'row',
                alignItems: 'center',
              }}>
              <TextInput
                value={word}
                onChangeText={setWord}
                style={styles.searchInput}
                placeholder="Search"
              />
              <View
                style={{
                  flex: 1,
                  height: 50,
                  justifyContent: 'center',
                }}>
                {isSearching ? (
                  <ActivityIndicator size="small" color={Colors.primary} />
                ) : (
                  <IconButton
                    icon="magnify"
                    color={Colors.primary}
                    size={24}
                    onPress={handleSearchWord}
                  />
                )}
              </View>
            </View>
          </View>

          <View style={styles.subContainer}>
            <View
              style={{
                flexDirection: 'row',
                justifyContent: 'space-between',
                alignItems: 'center',
                marginRight: 10,
                marginBottom: 10,
              }}>
              <View style={{ flexDirection: 'row', alignItems: 'center' }}>
                <Text
                  style={[styles.title, { marginRight: 15, marginBottom: 0 }]}>
                  Saved words
                </Text>
                <View style={styles.circleNumber}>
                  <Text style={{ color: 'white', fontWeight: 'bold' }}>0</Text>
                </View>
              </View>
              <TouchableOpacity
                style={{ flexDirection: 'row', alignItems: 'center' }}>
                <Text
                  style={{
                    fontSize: 16,
                    color: Colors.darkGray,
                    fontWeight: 'bold',
                  }}>
                  more
                </Text>
                <Icon
                  name="chevron-right"
                  size={16}
                  color={Colors.darkGray}
                  style={{ marginTop: 3 }}
                />
              </TouchableOpacity>
            </View>
            {/* <View style={{ flexDirection: 'row', alignItems: 'center' }}>

            </View> */}
            <View
              style={{
                paddingHorizontal: 20,
                alignItems: 'center',
              }}>
              <Image
                style={{ width: 60, height: 60, marginVertical: 15 }}
                source={{
                  uri: 'https://www.pngrepo.com/download/179100/sad-sad.png',
                }}
              />
              <Text style={{ color: Colors.darkGray, textAlign: 'center' }}>
                You haven't saved any words. Save words while you learn to
                review them later here.
              </Text>
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
      )}
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
    width: '85%',
    height: 40,
    backgroundColor: Colors.lightGray,
    paddingVertical: 10,
    paddingHorizontal: 15,
    fontSize: 16,
    borderRadius: 20,
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
export default VocabularyScreen;
