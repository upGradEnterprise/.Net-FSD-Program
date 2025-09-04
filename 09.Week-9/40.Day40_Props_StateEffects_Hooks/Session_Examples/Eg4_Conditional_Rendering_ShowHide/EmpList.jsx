import React, { useState } from 'react';


 let data = [ 
        { empno : 10256, ename :  "Scott", job : "Manager" , salary : 56000, deptno : 10 }, 
        { empno : 10257, ename :  "Smith", job : "Analyst" , salary : 45000, deptno : 20 },
        { empno : 10258, ename :  "Allen", job : "Clerk" , salary : 35000, deptno : 30 },
        { empno : 10259, ename :  "Tiger", job : "Salesman" , salary : 40000, deptno : 10 },
        { empno : 10260, ename :  "David", job : "Manager" , salary : 60000, deptno : 20 }
    ];

function EmpList() {

  const [empsArray, setEmpsArray] = useState(data);


 
 // let empsArray = [ ];  // empty array


  function hadleRemove(empno) {   
      let index = empsArray.findIndex( emp => emp.empno === empno );

      if(index !== -1) {
          empsArray.splice(index, 1);
          setEmpsArray( [...empsArray] );  // spread operator
          alert(`Employee with empno ${empno} removed successfully!`);
      }

  }

      let empsRows = empsArray.map( (employee, index) =>  
        <tr  key={index} className="hover:bg-gray-100"> 
            <td> {employee.empno} </td> 
            <td> {employee.ename} </td> 
            <td> {employee.job} </td> 
            <td> {employee.salary} </td> 
            <td> {employee.deptno} </td>  
            <td> 
              <button onClick={() => hadleRemove(employee.empno)}>Remove</button>  
            </td>
        </tr> );  

      
function  getFooter() {
    if(empsArray.length === 0) {
        return (  <tr className="bg-gray-200">
                  <td colSpan={6}> **Employees are not available in the application </td>
                </tr> );
    } else {
        return (  <tr className="bg-gray-200">
                  <td colSpan={6}> Total Employees : {empsArray.length} </td>
                </tr> );
    }
  }

  return (
      <>

      <div className="m-8 p-4 border rounded-lg shadow-md">
        <h2 className="text-xl font-bold mb-2">Array of Objects Example</h2>


        <table border="2" cellPadding={5} cellSpacing={0} className="w-full border-collapse">
            <thead> 
               <tr className="bg-gray-200">
                    <th>Emp No</th>
                    <th>Emp Name</th>
                    <th>Emp Job</th>
                    <th>Emp Salary</th>
                    <th>Emp Deptno</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
               {empsRows}
            </tbody>

          <tfoot>
               {getFooter()}
            </tfoot> 
                
        </table>
    </div>
      </>     
  );
}

export default EmpList;
