import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  Image,
  TextInput,
  TouchableOpacity,
  Alert,
} from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';

import { resetAccount } from '../api/AuthAPI';
const ResetPasswordScreen = ({ navigation }) => {
  const [email, setEmail] = useState('');
  const [message, setMessage] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  function handleResetAccount() {
    setIsLoading(true);
    resetAccount(email)
      .then(res => {
        setIsLoading(false);
        if (res.data.code === 0) {
          Alert.alert('', res.data.message, [
            { text: 'OK', onPress: () => navigation.navigate('Login') },
          ]);
        } else {
          setMessage(res.data.message);
        }
      })
      .catch(err => console.log(err));
  }
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
        <Text style={{ color: 'red', marginTop: 15 }}>{message}</Text>
        <Button
          mode="contained"
          color={Colors.primary}
          uppercase={false}
          loading={isLoading}
          dark
          style={{
            width: '50%',
            borderRadius: 18,
            marginTop: 20,
          }}
          onPress={() => handleResetAccount()}>
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
