import React, { useEffect, useState } from 'react';
import { Text, View, StyleSheet } from 'react-native';
import { WebView } from 'react-native-webview';
import Loader from '../components/Loader';

const NewsContentScreen = ({ route, navigation }) => {
  const { newsURL } = route.params;
  const [content, setContent] = useState('');
  const [isLoading, setIsLoading] = useState(true);
  return (
    <>
      <>
        <WebView
          style={{ paddingHorizontal: 15 }}
          source={{
            uri: newsURL,
          }}
        />
      </>
    </>
  );
};

const styles = StyleSheet.create({
  practiceBtn: {
    position: 'absolute',
    top: -55,
    right: 60,
    zIndex: 100,
  },
  resultBtn: {
    position: 'absolute',
    top: -55,
    right: 10,
    zIndex: 100,
  },
});
export default NewsContentScreen;
