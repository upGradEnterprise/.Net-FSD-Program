
function Greeting(props) {

    const {uname, textColor} = props;
       
  return (
    <>
        <h1 style={{"color":textColor}}>Hello, {uname} </h1>
    </>
  );
}

export default Greeting;