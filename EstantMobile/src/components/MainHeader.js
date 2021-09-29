import React from 'react';
import { View, Image, StyleSheet, Text } from 'react-native';
import { Colors } from '../styles/colors';

const MainHeader = () => {
  return (
    <View style={styles.container} elevation={5}>
      <Image source={require('../assets/logo.png')} style={styles.logo} />
      <Text style={styles.name}>Estant</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#fff',
    height: 50,
    flexDirection: 'row',
    alignItems: 'center',
  },
  logo: {
    width: 46,
    height: 41,
    marginLeft: 10,
  },
  name: {
    fontSize: 24,
    fontWeight: '700',
    color: Colors.primary,
  },
});

export default MainHeader;
