function Greeting({uname, textColor}) { 
       
  return (
    <>
        <h1 style={{"color":textColor}}>Hello, {uname} </h1>
    </>
  );
}

export default Greeting;