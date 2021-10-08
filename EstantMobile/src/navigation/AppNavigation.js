import * as React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import { Text } from 'react-native';
import { Colors } from '../styles/colors';
import VocabularyScreen from '../screens/VocabularyScreen';
import GrammarScreen from '../screens/GrammarScreen';
import ListeningScreen from '../screens/ListeningScreen';
import AccountScreen from '../screens/AccountScreen';
import TopicScreen from '../screens/TopicScreen';
import WordScreen from '../screens/WordScreen';
import FlashCardScreen from '../screens/FlashCardScreen';
import PracticeScreen from '../screens/PracticeScreen';

const Tab = createBottomTabNavigator();

const Stack = createStackNavigator();

const AppNavigator = () => {
  function MainTabs() {
    return (
      <Tab.Navigator
        screenOptions={({ route }) => ({
          tabBarIcon: ({ focused, color, size }) => {
            let iconName;
            if (route.name === 'Vocabulary') {
              iconName = focused ? 'notebook' : 'notebook-outline';
            } else if (route.name === 'Grammar') {
              iconName = focused ? 'script-text' : 'script-text-outline';
            } else if (route.name === 'Listening') {
              iconName = 'headphones';
            } else if (route.name === 'Account') {
              iconName = focused ? 'account-circle' : 'account-circle-outline';
            }
            return <Icon name={iconName} size={size} color={color} />;
          },
          tabBarActiveTintColor: Colors.primary,
          tabBarInactiveTintColor: Colors.darkGray,
          headerShown: false,
          tabBarHideOnKeyboard: true,
        })}>
        <Tab.Screen name="Vocabulary" component={VocabularyScreen} />
        <Tab.Screen name="Grammar" component={GrammarScreen} />
        <Tab.Screen name="Listening" component={ListeningScreen} />
        <Tab.Screen name="Account" component={AccountScreen} />
      </Tab.Navigator>
    );
  }

  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen
          name="MainTabs"
          options={{ headerShown: false }}
          component={MainTabs}
        />
        <Stack.Screen
          name="Topic"
          component={TopicScreen}
          options={({ route }) => ({
            title: route.params.name,
            headerTintColor: Colors.primary,
          })}
        />
        <Stack.Screen
          name="Meanings"
          component={WordScreen}
          options={{
            headerTintColor: 'white',
            headerStyle: { backgroundColor: Colors.primary },
          }}
        />
        <Stack.Screen
          name="Flashcards"
          component={FlashCardScreen}
          options={{
            headerTintColor: Colors.primary,
          }}
        />
        <Stack.Screen
          name="Practice"
          component={PracticeScreen}
          options={{
            headerTintColor: Colors.primary,
          }}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

export default AppNavigator;
