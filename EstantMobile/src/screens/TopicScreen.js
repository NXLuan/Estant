import React, { useEffect, useState } from 'react';
import { ScrollView, StyleSheet, View, TouchableOpacity } from 'react-native';
import { Searchbar } from 'react-native-paper';
import SquareButton from '../components/SquareButton';
import WordCard from '../components/WordCard';
import { getByTopic } from '../api/VocabularyAPI';

const TopicScreen = ({ route }) => {
  const [data, setData] = useState([]);

  const { name } = route.params;
  useEffect(() => {
    getByTopic(name)
      .then(res => {
        setData(res.data.data);
      })
      .catch(error => console.log(error));
  }, []);

  return (
    <ScrollView style={styles.container}>
      <View style={styles.rowButton}>
        <SquareButton iconName="cards" text="Flashcards" />
        <SquareButton
          iconName="head-question"
          text="Practice"
          style={{ marginHorizontal: 10 }}
        />
        <SquareButton iconName="clipboard-list" text="Result" />
      </View>
      <Searchbar placeholder="Search" style={styles.searchBar} />
      {data.length > 0 &&
        data.map(item => (
          <WordCard
            key={item.word}
            word={item.word}
            phonetic={item.phonetic}
            audio={'https:' + item.audio}
            definition={item.meanings[0].definitions[0].definition}
          />
        ))}
    </ScrollView>
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
