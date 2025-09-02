import React from 'react';

function EmpList() {

  let empsArray = [ 
        { empno : 10256, ename :  "Scott", job : "Manager" , salary : 56000, deptno : 10 }, 
        { empno : 10257, ename :  "Smith", job : "Analyst" , salary : 45000, deptno : 20 },
        { empno : 10258, ename :  "Allen", job : "Clerk" , salary : 35000, deptno : 30 },
        { empno : 10259, ename :  "Tiger", job : "Salesman" , salary : 40000, deptno : 10 },
        { empno : 10260, ename :  "David", job : "Manager" , salary : 60000, deptno : 20 }
    ];

      let empsRows = empsArray.map( (employee) =>  
        <tr> 
            <td> {employee.empno} </td> 
            <td> {employee.ename} </td> 
            <td> {employee.job} </td> 
            <td> {employee.salary} </td> 
            <td> {employee.deptno} </td>  
        </tr> );  


  return (
      <>
         <h2>All Employees Details</h2>


        <table border="1">
            <thead> 
                <tr>
                    <th>Emp No</th>
                    <th>Emp Name</th>
                    <th>Emp Job</th>
                    <th>Emp Salary</th>
                    <th>Emp Deptno</th>
                </tr>
            </thead>
            <tbody>
               {empsRows}
            </tbody>
        </table>
      </>     
  );
}

export default EmpList;
