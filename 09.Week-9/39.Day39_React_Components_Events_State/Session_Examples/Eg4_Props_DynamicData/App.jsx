import Greeting from "./components/Greeting";

 
function App() {

  let user1 = "Scott";
  let user2 = "Narasimha";
  let user3 = "Smith";

  let usersArray = ["Ravi", "Raju", "Ramu", "Narasimha", "Scott", "Smith"];

  let usersList = usersArray.map( (user, index) => <Greeting key={index} uname={user} textColor="Cyan" /> );  

  return (
     <>        
        <h1>Working with Props in React</h1>
        <hr/> 
        <Greeting  uname="Ravi" textColor="Green"  />
        <Greeting  uname="Raju" textColor="Blue"  />
        <Greeting  uname="Ramu" textColor="Red"  />
        <hr/>

        <Greeting  uname={user1} textColor="Orange"  />
        <Greeting  uname={user2} textColor="Purple"  />
        <Greeting  uname={user3} textColor="Brown"  />
        <hr/>


       { usersList  }


 

      </>
    
  );
}


export default App;