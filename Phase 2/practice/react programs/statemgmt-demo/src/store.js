import { configureStore } from '@reduxjs/toolkit';
import counterReducer from './reducer';
import { decrementAction, incrementAction } from './action';

const store = configureStore({
    reducer: counterReducer
});

store.subscribe(() => {
    console.log('Current State: ',store.getState());
});

store.dispatch(incrementAction);
store.dispatch(incrementAction);
store.dispatch(decrementAction);

export default store;