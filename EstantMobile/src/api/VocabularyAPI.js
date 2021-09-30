import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Vocabulary';

export function getAllTopic() {
  return axios.get(baseURL + '/GetAllTopic');
}
