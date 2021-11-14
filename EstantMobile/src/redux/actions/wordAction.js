import { FETCH_LIST_WORD } from '../constants/wordConstants';

export const fetchListWord = wordList => ({
  type: FETCH_LIST_WORD,
  data: wordList,
});
