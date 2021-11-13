import { FETCH_LIST_WORD } from '../constants/wordConstants';
import { fetchListWord } from '../actions/wordAction';

const initialState = {
  wordList: [],
};

const wordReducer = (state = initialState, action) => {
  switch (action.type) {
    case FETCH_LIST_WORD:
      return {
        ...state,
        wordList: action.data,
      };
    default:
      return state;
  }
};

export default wordReducer;
