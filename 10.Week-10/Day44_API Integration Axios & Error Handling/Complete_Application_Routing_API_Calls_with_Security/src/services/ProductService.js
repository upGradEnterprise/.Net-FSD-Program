import axios from "axios";

const API_URL = "https://localhost:7026/api/Products"; 
// const API_URL = "http://localhost:3000/products";    // JSON Server URL
const AUTH_URL = "https://localhost:7026/api/Authenticate"; 


const axiosObj = axios.create();

// Function to get the auth header with the token from session storage -- to configure axios requests
// Attach token before each request
axiosObj.interceptors.request.use(
  (config) => {
    const token = sessionStorage.getItem("AUTH_TOKEN");
    console.log("Attaching token to request: " + token);
    if (token) {
      config.headers["Authorization"] = `Bearer ${token}`;
    }
    return config;
  },
  (error) => Promise.reject(error)
);

// Function to configure axios responses
// Handle expired/invalid token responses globally
axiosObj.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response && error.response.status === 401) {
      console.warn("JWT expired or invalid. Logging out...");
      sessionStorage.removeItem("AUTH_TOKEN");

      // Optionally trigger a full reload or redirect
      window.location.href = "/Login"; 
    }
    return Promise.reject(error);
  }
);

/*
function getAuthHeader() {
          const token = sessionStorage.getItem("AUTH_TOKEN");
   //    const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IkFkbWluIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZSI6IkFkbWluIiwianRpIjoiZjY1NGI1MTQtM2EwMC00MGU1LWJmMTYtODdmZDNiYTM1ZDM3IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJleHAiOjE3NTgwMDgwNjYsImlzcyI6IllvdXJJc3N1ZXIiLCJhdWQiOiJZb3VyQXVkaWVuY2UifQ.wfuGrw3DCyqa6Z_gGOF_0_G7yWv1-T8xfc4XNMjsZBM";
       return { Authorization: `Bearer ${token}` };
}
*/
 

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
        return axiosObj.get(API_URL);   
  }

  async getById(id) {
    return axiosObj.get(`${API_URL}/${id}`);
  }

  async create(product) {
    return axiosObj.post(API_URL, product);
  }

   async update(id, product) {
    return axiosObj.put(`${API_URL}/${id}`, product);
  }

  async delete(id) {
    return axios.delete(`${API_URL}/${id}`);
  }

}

let productService = new ProductService();

export default productService;
