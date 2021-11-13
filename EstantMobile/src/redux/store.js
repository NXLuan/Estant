import { createStore, combineReducers } from 'redux';

import wordReducer from './reducers/wordReducer';

const rootReducer = combineReducers({
  wordReducer,
});

const configureStore = () => createStore(rootReducer);

export default configureStore;
