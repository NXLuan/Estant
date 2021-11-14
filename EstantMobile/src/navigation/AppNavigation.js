import * as React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import { Text } from 'react-native';
import AsyncStorage from '@react-native-community/async-storage';
import { Colors } from '../styles/colors';
import VocabularyScreen from '../screens/VocabularyScreen';
import GrammarScreen from '../screens/GrammarScreen';
import NewsScreen from '../screens/NewsScreen';
import ListeningScreen from '../screens/ListeningScreen';
import AccountScreen from '../screens/AccountScreen';
import TopicScreen from '../screens/TopicScreen';
import WordScreen from '../screens/WordScreen';
import FlashCardScreen from '../screens/FlashCardScreen';
import PracticeScreen from '../screens/PracticeScreen';
import LessonScreen from '../screens/LessonScreen';
import NewsContentScreen from '../screens/NewsContentScreen';

import SplashScreen from '../screens/SplashScreen';
import LoginScreen from '../screens/LoginScreen';
import CreateAccountScreen from '../screens/CreateAccountScreen';
import ResetPasswordScreen from '../screens/ResetPasswordScreen';

import { AuthContext } from './context';
const Tab = createBottomTabNavigator();

const Stack = createStackNavigator();

const AppNavigator = () => {
  const [state, dispatch] = React.useReducer(
    (prevState, action) => {
      switch (action.type) {
        case 'RESTORE_TOKEN':
          return {
            ...prevState,
            userToken: action.token,
            isLoading: false,
          };
        case 'SIGN_IN':
          return {
            ...prevState,
            isSignout: false,
            userToken: action.token,
          };
        case 'SIGN_OUT':
          return {
            ...prevState,
            isSignout: true,
            userToken: null,
          };
      }
    },
    {
      isLoading: true,
      isSignout: false,
      userToken: null,
    },
  );

  React.useEffect(() => {
    // Fetch the token from storage then navigate to our appropriate place
    const bootstrapAsync = async () => {
      let userToken;

      try {
        userToken = await AsyncStorage.getItem('userToken');
      } catch (e) {
        // Restoring token failed
        console.log(e);
      }

      // After restoring token, we may need to validate it in production apps

      // This will switch to the App screen or Auth screen and this loading
      // screen will be unmounted and thrown away.
      dispatch({ type: 'RESTORE_TOKEN', token: userToken });
    };

    bootstrapAsync();
  }, []);

  const authContext = React.useMemo(
    () => ({
      signIn: token => {
        AsyncStorage.setItem('userToken', token);
        dispatch({ type: 'SIGN_IN', token: token });
      },
      signOut: () => {
        AsyncStorage.removeItem('userToken');
        dispatch({ type: 'SIGN_OUT' });
      },
    }),
    [],
  );

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
            } else if (route.name === 'News') {
              iconName = 'newspaper-variant';
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
        <Tab.Screen name="News" component={NewsScreen} />
        <Tab.Screen name="Listening" component={ListeningScreen} />
        <Tab.Screen name="Account" component={AccountScreen} />
      </Tab.Navigator>
    );
  }

  return (
    <AuthContext.Provider value={authContext}>
      {state.userToken == null ? (
        <Stack.Navigator>
          <Stack.Screen
            options={{ headerShown: false }}
            name="Splash"
            component={SplashScreen}
          />
          <Stack.Screen
            options={{ headerShown: false }}
            name="Login"
            component={LoginScreen}
          />
          <Stack.Screen
            options={{ headerShown: false }}
            name="ResetPassword"
            component={ResetPasswordScreen}
          />
          <Stack.Screen
            options={{ headerShown: false }}
            name="CreateAccount"
            component={CreateAccountScreen}
          />
        </Stack.Navigator>
      ) : (
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
          <Stack.Screen
            name="Lesson"
            component={LessonScreen}
            options={{
              headerTintColor: 'white',
              headerStyle: { backgroundColor: Colors.primary },
            }}
          />
          <Stack.Screen
            name="NewsContent"
            component={NewsContentScreen}
            options={{
              title: 'News',
              headerTintColor: Colors.primary,
            }}
          />
        </Stack.Navigator>
      )}
    </AuthContext.Provider>
  );
};

export default AppNavigator;
