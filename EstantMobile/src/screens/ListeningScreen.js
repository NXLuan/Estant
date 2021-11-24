import React, { useState, useEffect } from 'react';
import { Text, View, ScrollView, StyleSheet, TextInput } from 'react-native';
import { Colors } from '../styles/colors';
import MainHeader from '../components/MainHeader';
import Loader from '../components/Loader';
import PodcastItem from '../components/PodcastItem';
import { getAllPodcasts, searchPodcast } from '../api/ListenAPI';

import { IconButton, Button, ActivityIndicator } from 'react-native-paper';

const ListeningScreen = ({ navigation }) => {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  const [isReloading, setIsReloading] = useState(false);
  const [isSearching, setIsSearching] = useState(false);
  const [word, setWord] = useState('');

  useEffect(() => {
    getAllPodcasts()
      .then(res => {
        setIsLoading(false);
        setData(res.data.data.results);
        console.log(data);
      })
      .catch(error => console.log(error));
  }, []);

  function handlePressPodcastsItem(index) {
    const { audio, image, title_original } = data[index];
    const newData = {
      url: audio,
      title: title_original,
      artwork: image,
    };

    navigation.navigate('Podcast', {
      data: newData,
    });
  }

  const handleSearchPodcasts = () => {
    if (word === '') return;
    setIsSearching(true);
    searchPodcast(word)
      .then(res => {
        setIsSearching(false);
        setWord('');
        setData(res.data.data.results);
      })
      .catch(error => {
        console.log(error);
      });
  };

  const handleReloadPodcasts = () => {
    setIsLoading(true);
    setWord('');
    getAllPodcasts()
      .then(res => {
        setIsLoading(false);
        setData(res.data.data.results);
      })
      .catch(error => console.log(error));
  };

  return (
    <>
      <MainHeader />
      {isLoading ? (
        <View style={{ flex: 1 }}>
          <Loader />
        </View>
      ) : (
        <ScrollView>
          <View style={styles.subContainer}>
            <Text style={styles.title}>Search</Text>
            <View
              style={{
                flexDirection: 'row',
                alignItems: 'center',
              }}>
              <TextInput
                value={word}
                onChangeText={setWord}
                style={styles.searchInput}
                placeholder="Enter keyword"
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
                    onPress={handleSearchPodcasts}
                  />
                )}
              </View>
            </View>
          </View>
          <View style={styles.subContainer}>
            <View
              style={{
                flexDirection: 'row',
                alignItems: 'center',
                paddingRight: 7,
              }}>
              <Text style={[styles.title, { marginBottom: 15, flex: 1 }]}>
                Podcasts
              </Text>
              <IconButton
                icon="autorenew"
                color={Colors.primary}
                size={24}
                onPress={handleReloadPodcasts}
              />
            </View>

            {data != null &&
              data.map((item, index) => (
                <PodcastItem
                  key={index}
                  title={item.title_original}
                  description={item.description_original}
                  imgURL={item.image}
                  onPressPodcastsItem={() => handlePressPodcastsItem(index)}
                />
              ))}
          </View>
        </ScrollView>
      )}
    </>
  );
};

const styles = StyleSheet.create({
  title: {
    fontSize: 20,
    fontWeight: '700',
    marginBottom: 10,
  },
  subContainer: {
    backgroundColor: '#fff',
    paddingHorizontal: 15,
    paddingVertical: 10,
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
});

export default ListeningScreen;
