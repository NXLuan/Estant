import React from 'react';
import { ActivityIndicator } from 'react-native-paper';
import { StyleSheet, View } from 'react-native';
import { Colors } from '../styles/colors';

const Loader = () => {
  return (
    <View style={styles.loading}>
      <ActivityIndicator size="large" color={Colors.primary} />
    </View>
  );
};

const styles = StyleSheet.create({
  loading: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: '#F5FCFF88',
    zIndex: 10,
  },
});

export default Loader;
