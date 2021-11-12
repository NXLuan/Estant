import React, { useState, useEffect } from 'react';
import {
  Text,
  View,
  StyleSheet,
  Image,
  TextInput,
  TouchableOpacity,
  ScrollView,
  Alert,
} from 'react-native';
import { Button } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import { createAccount } from '../api/AuthAPI';
const CreateAccountScreen = ({ navigation }) => {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [isHidden, setIsHidden] = useState(true);
  const [isLoading, setIsLoading] = useState(false);
  const [message, setMessage] = useState('');

  function handleCreateAccount() {
    setIsLoading(true);
    createAccount({ name, email, password, confirmPassword })
      .then(res => {
        setIsLoading(false);
        if (res.data.code !== 0) {
          setMessage(res.data.message);
        } else {
          Alert.alert('', res.data.message, [
            { text: 'OK', onPress: () => navigation.navigate('Login') },
          ]);
        }
      })
      .catch(err => console.log(err));
  }
  return (
    <ScrollView
      style={{
        flex: 1,
        backgroundColor: 'white',
        paddingHorizontal: 30,
      }}>
      <Text
        style={{
          fontWeight: 'bold',
          fontSize: 32,
          marginVertical: 40,
        }}>
        Create Account
      </Text>
      <Text style={styles.label}>Name</Text>
      <TextInput
        style={styles.input}
        textContentType="givenName"
        value={name}
        onChangeText={setName}
      />
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
      <Text style={{ marginTop: 15, color: 'red' }}>
        *Password must use at least 8 characters and contain on upper case
        letter, one lower case letter and one numeric character.
      </Text>
      <Text style={styles.label}>Confirmed Password</Text>
      <View style={styles.passwordContainer}>
        <TextInput
          style={styles.inputStyle}
          autoCorrect={false}
          secureTextEntry
          value={confirmPassword}
          onChangeText={setConfirmPassword}
        />
      </View>
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
          onPress={() => handleCreateAccount()}>
          Create Account
        </Button>
        <Text style={{ fontSize: 16, marginTop: 40 }}>
          Already have an account?
        </Text>
        <TouchableOpacity
          style={{ marginTop: 10 }}
          onPress={() => navigation.navigate('Login')}>
          <Text
            style={{ fontSize: 16, fontWeight: '600', color: Colors.primary }}>
            Login
          </Text>
        </TouchableOpacity>
      </View>
    </ScrollView>
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
export default CreateAccountScreen;
