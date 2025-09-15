import { Link, Outlet } from "react-router-dom";

function Dashboard()
{  
    return (

        <>
            <div style={{backgroundColor:'LightYellow', padding: '10px', border : "2px solid black"}}>
                <h1>This is Admin Dashboard</h1>  
                <hr />
                <div>
                    <Link to="Profile">Profile</Link> |  
                    <Link to="Settings">Settings</Link> |
                </div>

                <Outlet />

               
            </div>
    </>
    );
}  

export default Dashboard;
 

 