import axios from "axios";



const API_URL = "https://localhost:7026/api/Products"; 
const AUTH_URL = "https://localhost:7026/api/Authenticate"; 


function getAuthHeader() {
          const token = sessionStorage.getItem("AUTH_TOKEN");
   //    const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZSI6IkFkbWluIiwianRpIjoiZjY1NGI1MTQtM2EwMC00MGU1LWJmMTYtODdmZDNiYTM1ZDM3IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJleHAiOjE3NTgwMDgwNjYsImlzcyI6IllvdXJJc3N1ZXIiLCJhdWQiOiJZb3VyQXVkaWVuY2UifQ.wfuGrw3DCyqa6Z_gGOF_0_G7yWv1-T8xfc4XNMjsZBM";
       return { Authorization: `Bearer ${token}` };
}
 

class ProductService {

 
    async login(userName, password) {
        try {
                const response = await axios.post(AUTH_URL, { userName, password });
                const token = response.data.token; // adjust key if API uses "accessToken" or similar
                if (token) {
                    sessionStorage.setItem("AUTH_TOKEN", token);
                }
                return response;
        } catch (err) {
            console.error("Login failed:", err);
            throw err;
        }
  }


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