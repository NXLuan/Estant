import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Grammar';

export function getAllLessons() {
  return axios.get(baseURL + `/GetAll`);
}

export function getLessonContent(code) {
  return axios.get(baseURL + `/GetHtmlContent?code=${code}`);
}

export function checkSpellAndGrammar(text) {
  return axios.post(baseURL + `/CheckSpellAndGrammar`, text, {
    headers: { 'Content-Type': 'application/json' },
  });
}
