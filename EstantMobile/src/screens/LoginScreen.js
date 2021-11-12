import React, { useState, useEffect, useContext } from 'react';
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
import { AuthContext } from '../navigation/context';

import { login } from '../api/AuthAPI';
const LoginScreen = ({ navigation }) => {
  const { signIn } = useContext(AuthContext);

  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isHidden, setIsHidden] = useState(true);
  const [isLoading, setIsLoading] = useState(false);
  const [message, setMessage] = useState('');

  function handleLogin() {
    setIsLoading(true);
    login({ email, password })
      .then(res => {
        setIsLoading(false);
        if (res.data.code !== 0) {
          setMessage(res.data.message);
        } else {
          signIn(res.data.data.token);
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
        Login
      </Text>
      <Text style={styles.label}>Email Address</Text>
      <TextInput
        style={styles.input}
        textContentType="emailAddress"
        value={email}
        onChangeText={setEmail}
      />
      <Text style={styles.label}>Password</Text>
      <View style={styles.passwordContainer}>
        <TextInput
          style={styles.inputStyle}
          autoCorrect={false}
          secureTextEntry={isHidden}
          value={password}
          onChangeText={setPassword}
        />
        <TouchableOpacity
          style={{ marginRight: 20 }}
          onPress={() => setIsHidden(isHidden => !isHidden)}>
          <Icon
            name={isHidden ? 'eye-off' : 'eye'}
            color={Colors.primary}
            size={24}
          />
        </TouchableOpacity>
      </View>
      <View style={{ alignItems: 'center' }}>
        <Text style={{ color: 'red', marginTop: 15 }}>{message}</Text>
        <Button
          mode="contained"
          color={Colors.primary}
          uppercase={false}
          dark
          loading={isLoading}
          style={{
            width: '50%',
            borderRadius: 18,
            marginTop: 20,
          }}
          onPress={() => handleLogin()}>
          Login
        </Button>
        <TouchableOpacity
          style={{ marginTop: 20 }}
          onPress={() => navigation.navigate('ResetPassword')}>
          <Text style={{ fontSize: 16, fontWeight: '600' }}>
            Forgot Password?
          </Text>
        </TouchableOpacity>

        <Text style={{ fontSize: 16, marginTop: 40 }}>
          Don't have an account?
        </Text>
        <TouchableOpacity
          style={{ marginTop: 10 }}
          onPress={() => navigation.navigate('CreateAccount')}>
          <Text
            style={{ fontSize: 16, fontWeight: '600', color: Colors.primary }}>
            Create Account
          </Text>
        </TouchableOpacity>
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
  passwordContainer: {
    flexDirection: 'row',
    borderWidth: 2,
    backgroundColor: 'white',
    borderColor: Colors.primary,
    alignItems: 'center',
    borderRadius: 25,
    elevation: 5,
  },
  inputStyle: {
    flex: 1,
    paddingHorizontal: 15,
    fontSize: 20,
  },
});
export default LoginScreen;
