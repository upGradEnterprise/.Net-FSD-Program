// Store Configuration (store.js)
import { todosReducer } from './todosReducer';
import { configureStore } from '@reduxjs/toolkit';

export const appStore = configureStore({ reducer : todosReducer});