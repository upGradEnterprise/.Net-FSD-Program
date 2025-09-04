import axios from "axios";
import {  useEffect, useState } from "react";

function Counter() {

    let  [count,  setCount]  =  useState(0);
    const [customersArray, setCustomers] = useState([]);

   useEffect(() => {  
      // api call on component load : load products    
      console.log("api call on component loading / mount : customers data");   

      let url  = "https://www.w3schools.com/angular/customers.php";
      axios.get(url).then( (resData) => {          
        setCustomers(resData.data.records)  ;
      });   

   }, []);  //  empty dependency array : useEffect will be called only once : on component load


    useEffect(() => {
         document.title = `You clicked ${count} times`;
     }, [count]);  //  useEffect will be called when count variable is updated


    useEffect(() => {
         const timer = setInterval(() => {  
                          console.log('Timer tick');
                      }, 2000);

        return () => clearInterval(timer);  // cleanup function to clear the timer
    }, []); 
  

     function handleClick() {
        
        count = count + 1;
        setCount(count  );    //  use set method to update the state variable
    }


    let resultsArray  = customersArray.map( (item,index) =>  
        <tr key={index}>
          <td>  {item.Name} </td>
          <td>  {item.City} </td>
          <td>  {item.Country} </td>
        </tr>);
   
  return (
    <>  
         <h1>Demonstrate useEffect Hook in React </h1>
          <hr/>

        <button onClick={handleClick}>Click Me</button>
        <h2>Counter Value: {count}</h2>   
        <hr/>

          <table border="2"> 
                <thead>
                <tr>
                  <th>Customer Name</th>
                  <th>City Name</th>
                  <th>Country Name</th>
                </tr>
                </thead>

                <tbody>
                {resultsArray}  

                </tbody>
            </table> 

    </>
  );
}

export default Counter;