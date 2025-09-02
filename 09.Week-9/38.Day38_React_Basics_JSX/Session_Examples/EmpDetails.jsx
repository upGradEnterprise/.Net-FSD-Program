import React from 'react';

function EmpDetails() {

  let empObj = { empno : 10256, ename :  "Scott", job : "Manager" , salary : 56000, deptno : 10 };

  return (
      <>
         <h2>Employee Details</h2>

        <div>  
          Employee Id :  {empObj.empno}  <br/>
          Employee Name :  {empObj.ename}  <br/>
          Employee Job  :  {empObj.job}  <br/>
          Employee Salary  :  {empObj.salary}  <br/>
          Employee Deptno  :  {empObj.deptno}  <br/>
       </div> 
       
      </>     
  );
}

export default EmpDetails;
