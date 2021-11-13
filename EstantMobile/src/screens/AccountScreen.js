import React from 'react';
import { Text, View } from 'react-native';
import { Button } from 'react-native-paper';

import { AuthContext } from '../navigation/context';

const AccountScreen = () => {
  const { signOut } = React.useContext(AuthContext);
  return (
    <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
      <Text>Account!</Text>
      <Button onPress={() => signOut()}>Logout</Button>
    </View>
  );
};

export default AccountScreen;
