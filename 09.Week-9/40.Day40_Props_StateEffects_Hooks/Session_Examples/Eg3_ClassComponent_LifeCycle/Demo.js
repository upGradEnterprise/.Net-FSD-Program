import React  from "react";

class Demo extends React.Component
{
  constructor(props)
  {
    super(props);      
    this.state = {date: new Date()}; 
    console.log("Constructor is executed at : " + this.state.date.toLocaleTimeString());    
    this.updateTime  = this.updateTime.bind(this);
  }

  updateTime()
  {
    this.setState({  date :  new Date() });
  }

  UNSAFE_componentWillMount()
  {
    console.log("Will Mount is executed at : " + this.state.date.toLocaleTimeString()); 
  }
  
  componentDidMount()
  {
    console.log("Did Mount is executed at : " + this.state.date.toLocaleTimeString()); 
  }

  shouldComponentUpdate()
  {
    console.log("Should component update is executed at : " + this.state.date.toLocaleTimeString()); 
    return true;
    //return false;
  }

  UNSAFE_componentWillUpdate()
  {
    console.log("Will Update is executed at : " + this.state.date.toLocaleTimeString()); 
  }
  
  componentDidUpdate()
  {
    console.log("Did Update is executed at : " + this.state.date.toLocaleTimeString()); 
  }

   
  componentWillUnmount()
  {
    
    alert("UnMount is executed at : " + this.state.date.toLocaleTimeString()); 
    console.log("UnMount is executed at : " + this.state.date.toLocaleTimeString()); 
  }
  

  render()
  {
    return (
      <>
         <h3 style={ { color:"blue", textAlign : "center", border : "2px solid blue", borderRadius : "10px",padding: "10px", margin : "15px"} }>
            Demonstrating React Component Life Cycle
        </h3> 

        <input type="button"  value="Get Time"  onClick={this.updateTime} />
        <h1 align="center">Current Time  :  {this.state.date.toLocaleTimeString()}</h1>
      </>
    );
  }
}

export default Demo; 
