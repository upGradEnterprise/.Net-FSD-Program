import { useState } from "react";
import DeptDetails from "./DeptDetails";
 

 let data = [
        {deptno : 10, dname : "Accounts",  loc :  "Hyd"} ,
        {deptno : 20, dname : "Sales",  loc :  "Pune"},
        {deptno : 30, dname : "Marketing",  loc :  "Hyd"},
        {deptno : 40, dname : "Operations",  loc :  "Chnnai"},
        {deptno : 50, dname : "Admin",  loc :  "Pune"},
        {deptno : 60, dname : "Finance",  loc :  "Hyd"},
        {deptno : 70, dname : "Testing",  loc :  "Mumbai"},
        {deptno : 80, dname : "Advertise",  loc :  "Goa"}        
       ];

function DeptList()
{
   
    const [dataArray, setDataArray] = useState(data);

     function handleRemoveParent(deptno)
     {
        //alert("Remove Dept (from Parent) : " + deptno);

        //  Remove the dept object from dataArray based on deptno
        let index = dataArray.findIndex( (obj) => obj.deptno === deptno );
        if(index !== -1)
        {
            dataArray.splice(index, 1);
            setDataArray([...dataArray]);  // modify state variable
            console.log("Dept Removed. New Array : ", dataArray);
        }
     }

       let deptComponents = dataArray.map( (obj) => <DeptDetails key={obj.deptno}  onDeptRemove={handleRemoveParent} deptObj={obj} /> );

    return (
        <>
            <h2 style={{color:"Blue"}}> Dept List Component </h2>
            <hr/>

            {deptComponents}
        </>
    );
}

export default DeptList;