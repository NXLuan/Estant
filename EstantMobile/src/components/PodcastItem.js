import React from 'react';
import { Text, StyleSheet, TouchableOpacity, View, Image } from 'react-native';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const PodcastItem = ({ title, description, imgURL, onPressPodcastsItem }) => {
  return (
    <TouchableOpacity style={styles.container} onPress={onPressPodcastsItem}>
      <View
        style={{
          flex: 1,
          justifyContent: 'space-between',
        }}>
        <Text style={styles.title} numberOfLines={1}>
          {title}
        </Text>
        <Text style={styles.source} numberOfLines={4}>
          {description}
        </Text>
      </View>
      <Image
        style={styles.img}
        source={{
          uri: imgURL,
        }}
      />
    </TouchableOpacity>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    flexDirection: 'row',
    padding: 10,
    backgroundColor: 'white',
    borderRadius: 15,
    elevation: 5,
    marginBottom: 10,
  },
  img: {
    width: 80,
    height: 80,
    borderRadius: 15,
    marginLeft: 10,
  },
  title: {
    fontWeight: '600',
    fontSize: 16,
  },
  source: {
    fontSize: 12,
    marginRight: 15,
  },
});

export default PodcastItem;
