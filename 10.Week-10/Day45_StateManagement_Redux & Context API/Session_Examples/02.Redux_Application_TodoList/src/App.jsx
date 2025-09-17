// App.js (React Component)
import { Provider } from 'react-redux';
import { appStore } from './store';
import TodoList from './TodoList';


function App() {
  return (
    <>
    <h3>Application Level State Management using Redux</h3>
    <hr/>
    
    <Provider store={appStore}>
      <TodoList />
    </Provider>

    </>
  );
}

export default App;