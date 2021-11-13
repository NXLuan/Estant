import axios from 'axios';
import { BASE_URL } from './constants';
import AsyncStorage from '@react-native-community/async-storage';

const baseURL = BASE_URL + '/User';

export function saveWord(word, token) {
  return axios.get(baseURL + `/SaveWord?word=${word}`, {
    headers: { Authorization: `Bearer ${token}` },
  });
}
export function deleteWord(word, token) {
  return axios.get(baseURL + `/UnSaveWord?word=${word}`, {
    headers: { Authorization: `Bearer ${token}` },
  });
}
