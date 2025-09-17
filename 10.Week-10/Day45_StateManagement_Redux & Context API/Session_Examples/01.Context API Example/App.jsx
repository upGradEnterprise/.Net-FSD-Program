import React, { useState } from 'react'
import Parent from './Components/Parent'
 

export const userContext  = React.createContext(null);

function App() {

    let [userObj, setUserObj] = useState({ name : "Scott", age : 25, email : "scott@gmail.com"});

  return (
    <>
      <h3>State Management in React using Context API</h3>
      <hr/>

      <userContext.Provider value={userObj}>
          <Parent />  
      </userContext.Provider>

      
 
    </>
  )
}

export default App
