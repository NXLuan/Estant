import React, { useEffect, useState } from 'react';
import { ScrollView, StyleSheet, View, TouchableOpacity } from 'react-native';
import { Searchbar } from 'react-native-paper';
import SquareButton from '../components/SquareButton';
import WordCard from '../components/WordCard';
import { getByTopic } from '../api/VocabularyAPI';
import Loader from '../components/Loader';

const TopicScreen = ({ route, navigation }) => {
  const [data, setData] = useState([]);
  const [filterData, setFilterData] = useState([]);
  const [keyword, setKeyword] = useState('');

  const [isLoading, setIsLoading] = useState(true);

  const { name } = route.params;
  useEffect(() => {
    getByTopic(name)
      .then(res => {
        setIsLoading(false);
        setData(res.data.data);
        setFilterData(res.data.data);
      })
      .catch(error => console.log(error));
  }, []);

  function handleOnPressMore({ item }) {
    navigation.navigate('Meanings', { dataWord: item });
  }
  const handleSearchWord = query => {
    setKeyword(query);
    if (query === '') {
      setFilterData(data);
    } else {
      let newData = [...data];
      setFilterData(newData.filter(item => item.word.includes(query)));
    }
  };
  const handleOpenFlashCard = () => {
    navigation.navigate('Flashcards', { data: data });
  };
  const handleOpenPractice = () => {
    navigation.navigate('Practice', { topic: name });
  };
  return (
    <>
      {isLoading ? (
        <Loader />
      ) : (
        <ScrollView style={styles.container}>
          <View style={styles.rowButton}>
            <SquareButton
              iconName="cards"
              text="Flashcards"
              handleOnPress={handleOpenFlashCard}
            />
            <SquareButton
              iconName="head-question"
              text="Practice"
              handleOnPress={handleOpenPractice}
              style={{ marginHorizontal: 10 }}
            />
            <SquareButton iconName="clipboard-list" text="Result" />
          </View>
          <Searchbar
            placeholder="Search"
            style={styles.searchBar}
            onChangeText={handleSearchWord}
            value={keyword}
          />
          {filterData != null &&
            filterData.length > 0 &&
            filterData.map((item, index) => (
              <WordCard
                key={index}
                word={item.word}
                phonetic={item.phonetic}
                audio={item.audio}
                definition={item.meanings[0].definitions[0].definition}
                onPressMore={() => handleOnPressMore({ item })}
              />
            ))}
        </ScrollView>
      )}
    </>
  );
};

const styles = StyleSheet.create({
  container: {
    padding: 15,
  },
  rowButton: {
    marginVertical: 10,
    flexDirection: 'row',
  },
  searchBar: {
    borderRadius: 10,
    marginTop: 10,
    marginBottom: 15,
  },
});

export default TopicScreen;
