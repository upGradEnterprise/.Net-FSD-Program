import { useState } from "react";

function Login() {

    const [username, setUsername] = useState("");   
    const [password, setPassword] = useState("");
    const [status, setStatus] = useState("");



    function handleLoginClick() {
       
        if(username === "admin" && password === "admin123") {
            setStatus("Login Successful");
        }
        else {
            setStatus("Login Failed");
        }
    }

   
  return (
    <>
      

        <fieldset>
            <legend>Login</legend>

            <label htmlFor="username">User Name:</label>
            <input type="text" onChange={(event) => setUsername(event.target.value)} id="username" name="username" />
            <br /> <br />

            <label htmlFor="password">Password:</label>
            <input type="password" onChange={(event) => setPassword(event.target.value)} id="password" name="password" />
            <br /> <br />

            <button onClick={handleLoginClick}>Login</button>
            <p>{status}</p>

        </fieldset>
  
    </>
  );
}

export default Login;