import React from 'react';
import { ScrollView, StyleSheet, View, TouchableOpacity } from 'react-native';
import { Searchbar } from 'react-native-paper';
import SquareButton from '../components/SquareButton';
import WordCard from '../components/WordCard';

const TopicScreen = () => {
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
      <WordCard
        word="airway"
        phonetic="ˈɛːweɪ"
        audio="https://ssl.gstatic.com/dictionary/static/sounds/20200429/airway--_gb_2.mp3"
        definition="the passage by which air reaches a person's lungs"
      />
      <WordCard
        word="airway"
        phonetic="ˈɛːweɪ"
        audio="https://ssl.gstatic.com/dictionary/static/sounds/20200429/airway--_gb_2.mp3"
        definition="the passage by which air reaches a person's lungs"
      />
      <WordCard
        word="airway"
        phonetic="ˈɛːweɪ"
        audio="https://ssl.gstatic.com/dictionary/static/sounds/20200429/airway--_gb_2.mp3"
        definition="the passage by which air reaches a person's lungs"
      />
      <WordCard
        word="airway"
        phonetic="ˈɛːweɪ"
        audio="https://ssl.gstatic.com/dictionary/static/sounds/20200429/airway--_gb_2.mp3"
        definition="the passage by which air reaches a person's lungs"
      />
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
