import axios from "axios";
import { useState } from "react";


function Customers() 
{

    const [customers, setCustomers] = useState([]);


    function handleClick() {
        // Logic to fetch and set customers can be added here

    //    let url  = "https://northwind.vercel.app/api/customers";
        let url  = "https://www.w3schools.com/angular/customers.php";
        

        axios.get(url).then( (resData) => {       

            // console.log( resData.data.records );

             setCustomers(resData.data.records);
        });
    }

    let customersRows  = customers.map( (item,index) =>  
                <tr key={index}>
                    <td>  {item.Name} </td>
                    <td>  {item.City} </td>
                    <td>  {item.Country} </td>
            </tr>)
        ;

  return (
    <div>   
        <h3>Customers Component</h3>
        <hr/>

        <input type="button" onClick={handleClick}  value="Get Customers"  />
        <br/> 
        <br/> 
        <table border="2">
            <thead>
                <tr>
                    <th>Customer Name</th>
                    <th>City</th>
                    <th>Country</th>               
                </tr>
            </thead>
            <tbody>
                {customersRows}  
            </tbody>
        </table>
        
    </div>
  );
}

export default Customers;