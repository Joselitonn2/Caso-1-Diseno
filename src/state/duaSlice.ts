import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { DuaData } from '../models/DuaData';

interface DuaState {
  current: DuaData | null;
  status: 'idle' | 'loading' | 'error' | 'complete';
  error: string | null;
}

const initialState: DuaState = { current: null, status: 'idle', error: null };

const duaSlice = createSlice({
  name: 'dua',
  initialState,
  reducers: {
    start(state) {
      state.status = 'loading';
      state.error = null;
    },
    setDua(state, action: PayloadAction<DuaData>) {
      state.current = action.payload;
      state.status = 'complete';
    },
    setError(state, action: PayloadAction<string>) {
      state.status = 'error';
      state.error = action.payload;
    },
  },
});

export const { start, setDua, setError } = duaSlice.actions;
export default duaSlice.reducer;
