import { useContext } from "react";
import { userContext } from "../App";

function GrandChild() {

    var  contextData  = useContext(userContext);

    //console.log("GrandChild - contextData ", contextData);

    return (
         <div style={{margin:"10px", border:"2px solid Blue"}}>
            <h2>Grand Child Component</h2>

            <h3>User Details from Context API</h3>
            <p>Name : {contextData.name}</p>
            <p>Age : {contextData.age}</p>
            <p>Email : {contextData.email}</p>
           
        </div>
    );
}   

export default GrandChild;