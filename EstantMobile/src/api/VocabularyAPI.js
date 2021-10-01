import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Vocabulary';

export function getAllTopic() {
  return axios.get(baseURL + '/GetAllTopic');
}

export function getByTopic(topic) {
  return axios.get(baseURL + `/GetByTopic?topic=${topic}`);
}
