import { useState } from "react";
import { useLocation, useNavigate } from "react-router-dom";
import productService from "../services/ProductService";

function Login() {

    const [uid, setUserId]  = useState("Admin");
    const [pwd, setPassword]  = useState("Admin123");
    const [result, setResult]  = useState(""); 

    let navigate = useNavigate(); // for navigation using code
    let location = useLocation(); // for reading query string params

    async function loginButton_click()
    {
       const queryString = location.search; // returns the query string from the current url
       let strReturnUrl  =  new URLSearchParams(queryString).get('returnUrl');


    try {
                await productService.login(uid, pwd);     
                navigate(strReturnUrl ? strReturnUrl : '/');            
        } 
        catch {
            setResult("Invalid username or password");
        }
        
    }


    return (
         <fieldset>
                <legend>User Login</legend>

                <label>User Id  : </label>
                <input type="text" value={uid} onChange={(event) => setUserId(event.target.value)} />
                <br/><br/>

                <label>Password  : </label>
                <input type="password"  value={pwd}  onChange={(args) => setPassword(args.target.value)} />
                <br/><br/>

                <input type="button"  onClick={loginButton_click}  value="Login"    />
                <p  style={{color : "red"}}>{result}</p>   
       </fieldset>  
    );
}

export default Login;