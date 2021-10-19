import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Grammar';

export function getAllLessons() {
  return axios.get(baseURL + `/GetAll`);
}

export function getLessonContent(html) {
  return axios.get(baseURL + `/GetHtmlContent?path=${html}`);
}
