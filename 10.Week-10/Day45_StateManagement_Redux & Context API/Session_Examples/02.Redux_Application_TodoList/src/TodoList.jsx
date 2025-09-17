// App.js (React Component)
import { useSelector, useDispatch } from 'react-redux';
import {  addTodo, removeTodo } from './todosReducer';
import { useState } from 'react';
import  './TodoList.css';

const TodoList = () => {

 const [task,setTask] = useState("");

  const todos = useSelector((state) => state.todos); // Access state.todos, not state.list
  const dispatch = useDispatch();

 
  function addTodoHandler()
  {
    if(task.trim() !== "")
    {
      dispatch(addTodo(task));
      setTask("");  // Clear input after adding
    }
 }

  return (
    <div>
      <h3>Todo List</h3>
      Enter Task : <input type="text" value={task} onChange={(e) => setTask(e.target.value)} />

      <button className="edit-btn" onClick={addTodoHandler}>Add Todo</button>
      <ul>
        {todos.map(todo => (
          <li key={todo.id}>
            {todo.text} 
            <button className="delete-btn" onClick={() => dispatch(removeTodo(todo.id))}>Delete</button>
          </li>
        ))}
      </ul>
    </div>
  );
};

 

export default TodoList;