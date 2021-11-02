import React from 'react';
import { Text, StyleSheet, TouchableOpacity, View, Image } from 'react-native';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const NewsItem = ({
  title,
  author,
  name,
  publishAt,
  imgURL,
  onPressNewsItem,
}) => {
  function convertDate() {
    let strDate = new Date(publishAt).toString();
    return strDate.slice(0, strDate.indexOf('GMT'));
  }
  return (
    <TouchableOpacity style={styles.container} onPress={onPressNewsItem}>
      <View
        style={{
          flex: 1,
          justifyContent: 'space-between',
        }}>
        <Text style={styles.title} numberOfLines={2}>
          {title}
        </Text>
        <Text style={styles.source}>{name}</Text>
        <Text style={{ color: Colors.darkGray }}>{convertDate()}</Text>
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
    fontSize: 14,
  },
  source: {
    fontWeight: 'bold',
    marginRight: 15,
  },
});

export default NewsItem;
