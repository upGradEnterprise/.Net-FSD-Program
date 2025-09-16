 
import { Link } from 'react-router-dom';
import './Emps.css';

export default  function Emps()
{  
    let emps =  [
             {  empno : 10256, ename:"Scott", job: "Manager", deptno : 10  },
             {  empno : 10257, ename:"Smith", job: "Lead", deptno : 20  },
             {  empno : 10258, ename:"Sandy", job: "Programmer", deptno : 30  },
             {  empno : 10259, ename:"Sam", job: "Tester", deptno : 40  },
             {  empno : 10256, ename:"Scott", job: "Manager", deptno : 10  },
             {  empno : 10257, ename:"Smith", job: "Lead", deptno : 20  },
             {  empno : 10258, ename:"Sandy", job: "Programmer", deptno : 30  },
             {  empno : 10259, ename:"Sam", job: "Tester", deptno : 40  },
        ];
 

    
 
        var result = emps.map( (item, index) => 
            <tr className={ index % 2 == 0?"c2":"c3" } >  
               <td> {item.empno}  </td> 
               <td> {item.ename}  </td> 
               <td> {item.job}  </td> 
               <td> {item.deptno}  </td> 
               <td align='center'>
                    <Link to={"/Details/" + item.empno}>Details</Link>    
               </td>
            </tr>);

    return (
        <div>             
            <h3>All Employee Details</h3>
            <table  border="2"  cellpadding="5"  cellSpacing="0" width="700">
                <tr className="c1">
                    <th>Emp Number</th>
                    <th>Emp Name</th>
                    <th>Emp Job</th>
                    <th>Emp Deptno</th>    
                    <th></th>                
                </tr>
                {result}
            </table>
        </div>);
}
 

 