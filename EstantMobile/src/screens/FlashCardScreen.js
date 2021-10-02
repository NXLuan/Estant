import React, { useEffect, useState } from 'react';
import FlipCard from '../components/FrontCard';
import { View, Text, StyleSheet, Animated } from 'react-native';
import { Button, IconButton, ProgressBar } from 'react-native-paper';
import FlashCard from '../components/FlashCard';
import { Colors } from '../styles/colors';

const FlashCardScreen = ({ route }) => {
  const { data } = route.params;
  const [indexCard, setIndexCard] = useState(0);

  const handlePressLeft = () => {
    if (indexCard === 0) {
      setIndexCard(data.length - 1);
    } else {
      setIndexCard(indexCard => indexCard - 1);
    }
  };
  const handlePressRight = () => {
    if (indexCard === data.length - 1) {
      setIndexCard(0);
    } else {
      setIndexCard(indexCard => indexCard + 1);
    }
  };
  return (
    <View style={styles.container}>
      <ProgressBar
        progress={indexCard / (data.length - 1)}
        color="red"
        style={styles.bar}
      />
      <View style={{ flexDirection: 'row' }}>
        <IconButton
          icon="chevron-left"
          size={36}
          color={Colors.primary}
          style={styles.iconButton}
          onPress={handlePressLeft}
        />
        <FlashCard data={data[indexCard]} key={indexCard} />
        <IconButton
          icon="chevron-right"
          size={36}
          color={Colors.primary}
          style={styles.iconButton}
          onPress={handlePressRight}
        />
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  iconButton: {
    marginTop: 125,
  },
  cardNumber: {
    fontSize: 20,
    marginBottom: 15,
    fontWeight: '600',
  },
  bar: {
    width: 250,
    height: 8,
    borderRadius: 4,
    marginBottom: 30,
  },
});

export default FlashCardScreen;
