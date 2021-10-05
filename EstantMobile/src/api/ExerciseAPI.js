import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Exercise';

export function getExercisesByTopic(topic) {
  return axios.get(baseURL + `/GetByTopic?topic=${topic}`);
}
