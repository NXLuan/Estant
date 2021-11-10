import React from 'react';
import { Text, View, StyleSheet, Image } from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';

const SplashScreen = () => {
  return (
    <View
      style={{
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: 'white',
      }}>
      <Image source={require('../assets/logo.png')} style={styles.logo} />
      <Text style={{ fontWeight: 'bold', fontSize: 32 }}>Estant</Text>
      <Text
        style={{
          fontWeight: 'bold',
          fontSize: 20,
          marginBottom: 50,
          marginTop: 10,
        }}>
        Improve your English instantly
      </Text>
      <Button
        mode="contained"
        color={Colors.primary}
        uppercase={false}
        dark
        style={{ width: '70%', borderRadius: 20 }}
        onPress={() => console.log('123')}>
        Get started
      </Button>
    </View>
  );
};

const styles = StyleSheet.create({
  logo: {
    width: 296,
    height: 260,
  },
});
export default SplashScreen;
