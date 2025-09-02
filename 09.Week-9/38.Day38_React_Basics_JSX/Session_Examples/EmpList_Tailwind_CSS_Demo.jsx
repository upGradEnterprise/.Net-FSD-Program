import React from 'react';

function EmpList() {

  let empsArray = [ 
        { empno : 10256, ename :  "Scott", job : "Manager" , salary : 56000, deptno : 10 }, 
        { empno : 10257, ename :  "Smith", job : "Analyst" , salary : 45000, deptno : 20 },
        { empno : 10258, ename :  "Allen", job : "Clerk" , salary : 35000, deptno : 30 },
        { empno : 10259, ename :  "Tiger", job : "Salesman" , salary : 40000, deptno : 10 },
        { empno : 10260, ename :  "David", job : "Manager" , salary : 60000, deptno : 20 }
    ];

      let empsRows = empsArray.map( (employee, index) =>  
        <tr  key={index} className="hover:bg-gray-100"> 
            <td> {employee.empno} </td> 
            <td> {employee.ename} </td> 
            <td> {employee.job} </td> 
            <td> {employee.salary} </td> 
            <td> {employee.deptno} </td>  
        </tr> );  


  return (
      <>

      <div className="m-8 p-4 border rounded-lg shadow-md">
        <h2 className="text-xl font-bold mb-2">Array of Objects Example</h2>


        <table className="w-full border-collapse">
            <thead> 
               <tr className="bg-gray-200">
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
    </div>
      </>     
  );
}

export default EmpList;
