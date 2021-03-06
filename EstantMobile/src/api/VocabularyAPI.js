import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Vocabulary';

export function getAllTopic() {
  return axios.get(baseURL + '/GetAllTopic');
}

export function getByTopic(topic) {
  return axios.get(baseURL + `/GetByTopic?topic=${topic}`);
}

export function searchWord(word) {
  return axios.get(baseURL + `/LookupDictionary?word=${word}`);
}

export function checkPronounce(data) {
  return axios.post(baseURL + `/PronunciationAssessment`, data, {
    headers: { 'Content-Type': 'application/json' },
  });
}
