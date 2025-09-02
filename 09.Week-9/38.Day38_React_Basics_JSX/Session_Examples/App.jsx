import React from "react";
import UserInfo from "./UserInfo";
import SkillSet from "./SkillSet";
import EmpDetails from "./EmpDetails";
import EmpList from "./EmpList";


function App() {

  return (
     <>        
        <h1>Welcome to my React application.</h1>
        <hr/>

        <UserInfo />
        <hr/>

        <SkillSet/>
        <hr/>

        <EmpDetails/>
        <hr/>

      <EmpList />

      </>
    
  );
}


export default App;