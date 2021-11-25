import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Listen';

export function searchPodcast(title) {
  return axios.get(baseURL + `/Search?title=${title}`);
}

export function getAllPodcasts() {
  return axios.get(baseURL + `/GetList`);
}
