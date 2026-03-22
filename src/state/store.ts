import { configureStore } from '@reduxjs/toolkit';
import authReducer from './authSlice';
import duaReducer from './duaSlice';

export const store = configureStore({
  reducer: {
    auth: authReducer,
    dua: duaReducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
