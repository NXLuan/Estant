import React from 'react';
import { Text, StyleSheet, TouchableOpacity } from 'react-native';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

const SquareButton = ({ iconName, text, style, handleOnPress }) => {
  return (
    <TouchableOpacity
      style={[styles.squareButton, style]}
      onPress={handleOnPress}>
      <Icon name={iconName} size={30} style={{ color: 'white' }} />
      <Text style={styles.textButton}>{text}</Text>
    </TouchableOpacity>
  );
};

const styles = StyleSheet.create({
  squareButton: {
    flex: 1,
    paddingVertical: 10,
    borderRadius: 10,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: Colors.primary,
  },
  textButton: {
    color: 'white',
    fontWeight: '600',
  },
});

export default SquareButton;
