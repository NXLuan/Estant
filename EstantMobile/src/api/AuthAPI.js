import axios from 'axios';
import { BASE_URL } from './constants';

const baseURL = BASE_URL + '/Auth';

export function createAccount(data) {
  return axios.post(baseURL + `/SignUp`, {
    email: data.email,
    displayName: data.name,
    password: data.password,
    confirmPassword: data.confirmPassword,
  });
}

export function login(data) {
  return axios.post(baseURL + '/SignIn', {
    email: data.email,
    password: data.password,
  });
}

export function resetAccount(email) {
  return axios.post(baseURL + '/ResetAccount', email, {
    headers: { 'Content-Type': 'application/json' },
  });
}
