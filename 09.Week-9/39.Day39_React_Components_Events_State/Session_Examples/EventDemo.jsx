function EventDemo() {    


    let productId = 101;

    function handleClick() {
        alert("Button was clicked!");
    }



    function handleChange(event) {
        console.log("Input changed: ", event.target.value);
    }

    function handleSubmit(event) {
        event.preventDefault();
        alert("Form submitted!");
    }


    function handleDeleteClick(id) {
         alert(`Delete item with id: ${id}`);
    }

  return (
    <>
       <h3>Event Handling in React</h3>
       <hr/>

        <h3>onChange Event</h3>
       <input type="text" placeholder="Type something..." onChange={handleChange} />       
       <hr/>


         <h3>onClick Event</h3>
       <button onClick={handleClick}>Click Me</button>
         <hr/>

        <h3>onSubmit Event</h3>      
         <form onSubmit={handleSubmit}>
            <h3>Form Submission</h3>
           
            <button type="submit">Submit</button>
         </form>

         <hr/>
            <h3>Passing Parameters to Event Handlers</h3>
              
            <button onClick={ () => handleDeleteClick(productId)  }>Delete</button>
         <hr/>
    </>
  );
}

export default EventDemo;