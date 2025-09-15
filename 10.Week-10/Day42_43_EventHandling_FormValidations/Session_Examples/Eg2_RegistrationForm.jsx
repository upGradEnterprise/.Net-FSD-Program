import { useState } from "react";



function RegistrationForm() {

    const [uname, setUname] = useState("");
    const [password, setPassword] = useState("");
    const [retypePassword, setRetypePassword] = useState("");
    const [email, setEmail] = useState("");   

    const [result, setResult] = useState("");   

    const [errorObj, setErrorObj] = useState({
        uname :  "", password :  "", retypePassword : "", email : ""
    });


    function handleSubmit(e)   {   

        e.preventDefault();  

        let tempErrorObj = Object.assign({}, errorObj);

        const validEmailRegex = RegExp(/^(([^<>()\[\]\.,;:\s@\"]+(\.[^<>()\[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i);
        
        tempErrorObj.uname  =  (uname.length == 0)? "User Name is required" : ""; 
        tempErrorObj.password = (password.length == 0) ? "Password is required" : "";
        tempErrorObj.email =  validEmailRegex.test(email)? '': 'Email is not valid!';
        tempErrorObj.retypePassword =  (password != retypePassword)? "Password and rettype password should be same..!" : "";

        setErrorObj(tempErrorObj);

        let valuesArray = Object.values(tempErrorObj);
        let  index = valuesArray.findIndex(item => item.length != 0);
						
						
        if(index == -1)
        {
            // Make an ajax call to send data to server
            setResult("Customer details are valid. We can send data to server.");       
        }
        else
        {
            setResult("You have entered invalid data. Please enter valid data.")
        }


    }


  return (<>

            <h3>Performing form validations in React JS</h3>
            <hr />

              <form  onSubmit={handleSubmit}  noValidate>     
                <fieldset>
                    <legend>Customer Registration Form</legend>

                    User Name  :  
                    <input type="text" value={uname} onChange={(e) => setUname(e.target.value)}  />
                    <span style={{color:"red"}}>{errorObj.uname}</span>
                    <br/><br/>

                    Password  :  
                    <input type="password" value={password}  onChange={(e) => setPassword(e.target.value)}  />
                   <span style={{color:"red"}}>{errorObj.password}</span>
                    <br/><br/>


                    Retype Password  :  
                    <input type="password" value={retypePassword}  onChange={(e) => setRetypePassword(e.target.value)}  />
                    <span style={{color:"red"}}>{errorObj.retypePassword}</span>
                    <br/><br/>

                    E-mail Id:
                    <input type="email" value={email}   onChange={ (e) => setEmail(e.target.value)}  />
                    <span style={{color:"red"}}>{errorObj.email}</span>
                    <br/><br/>

                      <input type="submit" value="Register" />
                </fieldset>
            </form>

            <div>
                <h3>{result}</h3>
            </div>
  </>);
}

export default RegistrationForm;