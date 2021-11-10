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
const CreateAccountScreen = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isHidden, setIsHidden] = useState(true);
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
        Create Account
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
          Create Account
        </Button>
        <Text style={{ fontSize: 16, marginTop: 40 }}>
          Already have an account?
        </Text>
        <TouchableOpacity style={{ marginTop: 10 }}>
          <Text
            style={{ fontSize: 16, fontWeight: '600', color: Colors.primary }}>
            Login
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
export default CreateAccountScreen;
