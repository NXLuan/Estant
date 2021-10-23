import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Exercise';

export function getExercisesByTopic(topic) {
  return axios.get(baseURL + `/GetByTopic?topic=${topic}`);
}
export function getExercisesByGrammar(code) {
  return axios.get(baseURL + `/GetByGrammar?code=${code}`);
}
