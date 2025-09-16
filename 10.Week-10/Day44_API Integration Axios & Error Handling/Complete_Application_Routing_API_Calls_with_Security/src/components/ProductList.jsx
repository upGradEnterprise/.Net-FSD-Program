// src/components/ProductList.js
import { useEffect, useState } from "react";
import productService from "../services/ProductService";
import "./ProductList.css";

function ProductList() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = async () => {
    try {
      const response = await productService.getAll();
      setProducts(response.data);
    } catch (err) {
      console.error("Error fetching products", err);
    }
  };


   async function  handleDelete(id) {

    if (window.confirm("Are you sure you want to delete this product?") === false) {
      return;
    } 

    try {
      await productService.delete(id);
      fetchProducts();
    } catch (err) {
      console.error("Error deleting product", err);
    }
  };

  

  return (
    <div className="container">
      <h1>Product Management</h1>
  

      <table className="product-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price ($)</th>
            <th>Category</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {products.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>{p.category}</td>
              <td>
                <button className="edit-btn"  >
                  Edit
                </button>
                <button className="delete-btn"  onClick={() => handleDelete(p.id)} >
                  Delete
                </button>
              </td>
            </tr>
          ))}
          {products.length === 0 && (
            <tr>
              <td colSpan="5" className="no-data">
                No products found.
              </td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
}


export default ProductList;