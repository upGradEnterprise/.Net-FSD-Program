import axios from 'axios';
import React, { useState } from 'react';

function Products() {

  const [productsArray, setProducts] = useState([]);


  function button_click() {
      let url  = "https://localhost:7026/api/Products";

      axios.get(url).then( (resData) => {          
        let resultObj  = resData.data;  
        setProducts(resultObj);
      });
  }


  let resultsArray  = productsArray.map( item =>  
    <tr>
      <td>  {item.id} </td>
      <td>  {item.name} </td>
      <td>  {item.price} </td>
      <td>  {item.category} </td>
    </tr>);
   


  return <div>  

            <h3>Server Communication in React using Axios Library</h3>        
            <hr/>

             <input type="button" onClick={button_click}  value="Get Products"  />
             <br/> 
             <br/> 
             <table border="2"> 
                <tr>
                  <th>Product Id</th>
                  <th>Product Name</th>
                  <th>Unit Price</th>
                  <th>Category</th>               
                </tr>

                {resultsArray}  
            </table> 

        </div>;
}

export default Products;

