import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";


function ProtectedRoute(props) {

    const navigate = useNavigate();
    const [isLoggedIn, setIsLoggedIn] = useState(false);

    useEffect(() => {
       // alert(props.returnUrl);       
        checkUserToken();
    }, [isLoggedIn]);


    function checkUserToken()
    {		
        const userToken = sessionStorage.getItem('AUTH_TOKEN');

        //console.log("Message from Protected Route - Check User Token: " + userToken);  
		
        if (!userToken || userToken === 'undefined') 
		{
            setIsLoggedIn(false);                
            return navigate('/Login?returnUrl=' + props.returnUrl);
            // return navigate('/Login');
        }

        setIsLoggedIn(true);
    }

     return (
        <>
            {
                isLoggedIn ? props.children : null
            }
        </>
    );

}


export default ProtectedRoute;