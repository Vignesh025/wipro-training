import store from './store';
import { incrementAction, decrementAction } from './action';

store.subscribe(() => {
    console.log('Current State: ',store.getState());
});

store.dispatch(incrementAction);
store.dispatch(incrementAction);
store.dispatch(decrementAction);