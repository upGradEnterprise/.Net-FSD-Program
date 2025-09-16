import React, { useEffect, useState } from 'react';
import productService from '../services/ProductService';

function ProductList() {

  const [productsArray, setProducts] = useState([]);


  useEffect( () => {
      fetchProducts();
  }, [] );


 async function fetchProducts() {    
        const response = await productService.getAll();
        setProducts(response.data);   
  };


  let resultsArray  = productsArray.map( item =>  
    <tr>
      <td>  {item.id} </td>
      <td>  {item.name} </td>
      <td>  {item.price} </td>
      <td>  {item.category} </td>
    </tr>);
   


  return <div>  

            <h3>Server Communication in React using Axios Library</h3>        
        

        
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

export default ProductList;

