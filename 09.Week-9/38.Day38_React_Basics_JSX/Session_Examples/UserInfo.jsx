
function UserInfo() {

     let uname = "Scott";
    let email = "scott@gmail.com";
    let age = 24;
    let isValidUser = false;

  return (
    <>
      <h2>User Information</h2>
      <p>
         User Name: {uname} <br/>
            Email: {email} <br/>
            Age: {age} <br/>
            Valid User: {isValidUser ? "Yes" : "No"}    
      </p>
    </>
  );
}

export default UserInfo;