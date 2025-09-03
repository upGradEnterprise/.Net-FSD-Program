
function Greeting(props) {

       
  return (
    <>
        <h1 style={{"color":props.textColor}}>Hello, {props.uname} </h1>
    </>
  );
}

export default Greeting;