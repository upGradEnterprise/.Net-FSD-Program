import './DeptDetails.css';

function DeptDetails({deptObj, onDeptRemove})
{  

    function handleRemoveChild()
    {
        if( window.confirm("Are you sure to remove this dept ?") == false )
        {
            return;  // do nothing
        }
        
        // alert("Remove Dept (from Child) : " + deptObj.deptno);
        //  Call parent component function to remove this dept from array
        onDeptRemove(deptObj.deptno);        
    }

    return (
        <>
            <div className="card">
                    <h3 style={{margin: "2px", color:"Red"}}> {deptObj.dname} </h3>
                    <u> Deptno : {deptObj.deptno} </u>  <br/>
                     Location : <span style={{color:"Green"}}> {deptObj.loc} </span>   <br/>
                     <a href="javascript:void(0);"  onClick={handleRemoveChild}>Remove</a>
            </div>
        </>
    );
}

export default DeptDetails;


