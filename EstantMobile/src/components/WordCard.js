import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Sound from 'react-native-sound';

const WordCard = ({ word, phonetic, audio, definition, onPressMore }) => {
  const sound = new Sound(audio);

  return (
    <View style={styles.container}>
      <View style={{ flexDirection: 'row', justifyContent: 'center' }}>
        <Text style={[styles.word, { flex: 1 }]}>{word}</Text>
      </View>
      <View style={styles.rowPronouce}>
        <IconButton
          icon="volume-high"
          size={16}
          color="black"
          onPress={() => sound.play()}
        />
        <Text style={styles.phonetic}>/ {phonetic} /</Text>
      </View>
      <Text numberOfLines={2} style={{ marginLeft: 10, marginRight: 15 }}>
        {definition}
      </Text>
      <View
        style={{
          flexDirection: 'row',
          justifyContent: 'flex-end',
        }}>
        <IconButton
          icon="dots-horizontal-circle"
          size={20}
          color={Colors.blue}
          style={{ margin: 0 }}
          onPress={onPressMore}
        />
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: 'white',
    borderRadius: 10,
    paddingTop: 10,
    paddingBottom: 5,
    paddingHorizontal: 15,
    marginBottom: 15,
    elevation: 3,
  },
  word: {
    fontSize: 20,
    fontWeight: 'bold',
    color: Colors.blue,
    marginLeft: 10,
  },
  rowPronouce: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  phonetic: {
    fontSize: 16,
  },
});
export default WordCard;
