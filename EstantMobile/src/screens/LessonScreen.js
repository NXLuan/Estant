import React, { useEffect, useState } from 'react';
import { Text, View, StyleSheet } from 'react-native';
import { IconButton } from 'react-native-paper';
import { getLessonContent } from '../api/GrammarAPI';
import { WebView } from 'react-native-webview';
import Loader from '../components/Loader';
import SquareButton from '../components/SquareButton';

const LessonScreen = ({ route }) => {
  const { code } = route.params;
  const [content, setContent] = useState('');
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    getLessonContent(code)
      .then(res => {
        setIsLoading(false);
        setContent(res.data.data);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);
  return (
    <>
      {isLoading ? (
        <View style={{ flex: 1 }}>
          <Loader />
        </View>
      ) : (
        <>
          <IconButton
            icon="head-question"
            color="white"
            size={30}
            style={styles.practiceBtn}
            onPress={() => console.log('123')}
          />
          <IconButton
            icon="clipboard-list"
            color="white"
            size={30}
            style={styles.resultBtn}
            onPress={() => console.log('123')}
          />
          <WebView
            style={{ paddingHorizontal: 15 }}
            source={{ html: content }}
          />
        </>
      )}
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
export default LessonScreen;
