import React from 'react';
import { ScrollView, StyleSheet, View, Text } from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';
import WordMeaning from '../components/WordMeaning';
import Sound from 'react-native-sound';

const WordScreen = ({ route }) => {
  const { dataWord } = route.params;
  const { word, phonetic, audio, meanings } = dataWord;

  const sound = new Sound(audio);
  return (
    <>
      <IconButton
        icon="bookmark-plus"
        color="white"
        size={30}
        style={styles.saveBtn}
        onPress={() => console.log('123')}
      />
      <ScrollView style={styles.container}>
        <View style={styles.header}>
          <IconButton
            icon="volume-high"
            size={28}
            color="white"
            style={{ backgroundColor: Colors.primary, marginRight: 15 }}
            onPress={() => sound.play()}
          />
          <View>
            <Text style={styles.word}>{word}</Text>
            <Text style={styles.phonetic}>/ {phonetic} /</Text>
          </View>
        </View>
        <View style={{ marginLeft: 10 }}>
          {meanings.length > 0 &&
            meanings.map((item, index) => (
              <WordMeaning meaning={item} id={index + 1} key={index} />
            ))}
        </View>
      </ScrollView>
    </>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'white',
    padding: 10,
  },
  header: {
    flexDirection: 'row',
    alignItems: 'center',
    flex: 1,
    paddingBottom: 15,
    borderBottomWidth: 0.2,
    marginBottom: 15,
  },
  word: {
    fontSize: 28,
    fontWeight: 'bold',
    color: Colors.blue,
  },
  phonetic: {
    fontSize: 20,
  },
  saveBtn: {
    position: 'absolute',
    top: -55,
    right: 10,
    zIndex: 100,
  },
});
export default WordScreen;
