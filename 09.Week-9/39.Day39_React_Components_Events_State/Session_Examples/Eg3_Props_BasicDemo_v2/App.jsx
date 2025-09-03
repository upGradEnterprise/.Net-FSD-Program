import Greeting from "./components/Greeting";

 
function App() {

  return (
     <>        
        <h1>Working with Props in React</h1>
        <hr/>

        <Greeting  uname="Scott" textColor="Green"  />
        <Greeting  uname="Narasimha" textColor="Blue"  />
        <Greeting  uname="Smith" textColor="Red"  />
        <hr/>
         <Greeting  uname="Ravi" textColor="Green"  />
        <Greeting  uname="Raju" textColor="Blue"  />
        <Greeting  uname="Ramu" textColor="Red"  />
 

      </>
    
  );
}


export default App;