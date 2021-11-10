import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  Image,
  TextInput,
  TouchableOpacity,
} from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
const ResetPasswordScreen = () => {
  const [email, setEmail] = useState('');
  return (
    <View
      style={{
        flex: 1,
        justifyContent: 'center',
        backgroundColor: 'white',
        paddingHorizontal: 30,
      }}>
      <Text
        style={{
          fontWeight: 'bold',
          fontSize: 32,
          marginBottom: 40,
        }}>
        Reset Password
      </Text>
      <Text style={styles.label}>Email Address</Text>
      <TextInput
        style={styles.input}
        textContentType="emailAddress"
        value={email}
        onChangeText={setEmail}
      />
      <View style={{ alignItems: 'center' }}>
        <Button
          mode="contained"
          color={Colors.primary}
          uppercase={false}
          dark
          style={{
            width: '50%',
            borderRadius: 18,
            marginTop: 50,
          }}
          onPress={() => console.log('123')}>
          Reset Password
        </Button>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  label: {
    fontSize: 18,
    marginBottom: 10,
    marginTop: 20,
  },
  input: {
    borderColor: Colors.primary,
    borderWidth: 2,
    backgroundColor: 'white',
    paddingHorizontal: 15,
    fontSize: 16,
    borderRadius: 25,
    elevation: 5,
    fontSize: 20,
  },
});
export default ResetPasswordScreen;
