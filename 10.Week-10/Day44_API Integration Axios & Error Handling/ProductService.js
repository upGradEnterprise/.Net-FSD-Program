import axios from "axios";



const API_URL = "https://localhost:7026/api/Products"; 


function getAuthHeader() {
   //  const token = sessionStorage.getItem("jwtToken");
       const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZSI6IkFkbWluIiwianRpIjoiN2ZmOWJlNWUtYzI2YS00YjM3LTlhMTEtZmQzYTBmNDExYzcxIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJleHAiOjE3NTgwMDU5MjgsImlzcyI6IllvdXJJc3N1ZXIiLCJhdWQiOiJZb3VyQXVkaWVuY2UifQ.Q1lHkMtzRb0cP76s5p30y5hmE9_mAW_CDK_bHNQ3xWE";
       return { Authorization: `Bearer ${token}` };
}
 

class ProductService {

  async getAll() {
      console.log("Message from ProductService");
        return axios.get(API_URL, { headers: getAuthHeader() });   
  }

  async getById(id) {
    return axios.get(`${API_URL}/${id}`, { headers: getAuthHeader() });
  }

  async create(product) {
    return axios.post(API_URL, product, { headers: getAuthHeader() });
  }

   async update(id, product) {
    return axios.put(`${API_URL}/${id}`, product, { headers: getAuthHeader() });
  }

  async delete(id) {
    return axios.delete(`${API_URL}/${id}`, { headers: getAuthHeader() });
  }

}

let productService = new ProductService();

export default productService;