import Greeting from "./components/Greeting";

 
function App() {

  return (
     <>        
        <h1>Working with Props in React</h1>
        <hr/>

        <Greeting  uname="Scott" textColor="Green"  />
        <Greeting  uname="Narasimha" textColor="Blue"  />
        <Greeting  uname="Smith" textColor="Red"  />
 

      </>
    
  );
}


export default App;