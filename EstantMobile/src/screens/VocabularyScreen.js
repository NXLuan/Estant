import React from 'react';
import { Text, View } from 'react-native';
import MainHeader from '../components/MainHeader';

const VocabularyScreen = () => {
  return (
    <>
      <MainHeader />
      <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
        <Text>Vocab!</Text>
      </View>
    </>
  );
};

export default VocabularyScreen;
