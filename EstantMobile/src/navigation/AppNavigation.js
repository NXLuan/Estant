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

const Tab = createBottomTabNavigator();

const Vocabulary = createStackNavigator();
const Grammar = createStackNavigator();
const Listening = createStackNavigator();
const Account = createStackNavigator();

const AppNavigator = () => {
  function VocabularyStack() {
    return (
      <Vocabulary.Navigator
        screenOptions={{
          headerShown: false,
        }}>
        <Vocabulary.Screen
          name="VocabularyScreen"
          component={VocabularyScreen}
        />
      </Vocabulary.Navigator>
    );
  }

  function GrammarStack() {
    return (
      <Grammar.Navigator
        screenOptions={{
          headerShown: false,
        }}>
        <Grammar.Screen name="GrammarScreen" component={GrammarScreen} />
      </Grammar.Navigator>
    );
  }

  function ListeningStack() {
    return (
      <Listening.Navigator
        screenOptions={{
          headerShown: false,
        }}>
        <Listening.Screen name="ListeningScreen" component={ListeningScreen} />
      </Listening.Navigator>
    );
  }

  function AccountStack() {
    return (
      <Account.Navigator
        screenOptions={{
          headerShown: false,
        }}>
        <Account.Screen name="AccountScreen" component={AccountScreen} />
      </Account.Navigator>
    );
  }

  return (
    <NavigationContainer>
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
        })}>
        <Tab.Screen name="Vocabulary" component={VocabularyStack} />
        <Tab.Screen name="Grammar" component={GrammarStack} />
        <Tab.Screen name="Listening" component={ListeningStack} />
        <Tab.Screen name="Account" component={AccountStack} />
      </Tab.Navigator>
    </NavigationContainer>
  );
};

export default AppNavigator;
