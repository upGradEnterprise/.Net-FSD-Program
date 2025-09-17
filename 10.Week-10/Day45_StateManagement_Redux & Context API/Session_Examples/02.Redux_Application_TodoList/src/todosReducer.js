// Action Types
const ADD_TODO = 'todos/ADD_TODO';
const REMOVE_TODO = 'todos/REMOVE_TODO';

// Action Creators
export const addTodo = (text) => ({
  type: ADD_TODO,
  payload: { id: Date.now(), text }
});

export const removeTodo = (id) => ({
  type: REMOVE_TODO,
  payload: id
});

// Reducer
const initialState = { todos: [] };

export const todosReducer = (state = initialState, action) => {

  //console.log("Action Received:", action); // Debugging line to check actions

  switch (action.type) {
    case ADD_TODO:
      return { ...state, todos: [...state.todos, action.payload] };
    case REMOVE_TODO:
      return { ...state, todos: state.todos.filter(todo => todo.id !== action.payload) };
    default:
      return state;
  }
};