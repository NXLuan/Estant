import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/News';

export function getNewsToday() {
  return axios.get(baseURL + '/GetNewsToday');
}

export function searchNewsByKeyword(word) {
  return axios.get(baseURL + `/GetNewsByKeyWord?keyword=${word}`);
}
