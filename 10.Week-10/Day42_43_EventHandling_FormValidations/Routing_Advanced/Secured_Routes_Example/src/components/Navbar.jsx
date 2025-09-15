import { Link } from "react-router-dom";

function Navbar()
{  
    return (

        <>
            <h3 style={{ textAlign: "center" }}>Developing Single Page Application using React</h3>
            <hr />
            <div style={{ textAlign: "center" }}>
                <Link to="/">Home</Link> |               
                <Link to="/Emps">Employees</Link> |     
                <Link to="/Depts">Departments</Link> |     
                <Link to="/Dashboard">Admin Dashboard</Link> |     
                <Link to="/Contact">Contact Us</Link> |     
                <Link to="/About">About Us</Link> |     
                <Link to="/Hello">Invalid</Link> |     
                <Link to="/Login">Login</Link> |     
            </div>
            <hr />
            
    </>
    );
}  

export default Navbar;
 

 