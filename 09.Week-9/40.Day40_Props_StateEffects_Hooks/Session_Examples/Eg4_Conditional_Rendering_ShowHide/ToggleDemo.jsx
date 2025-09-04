import { useState } from "react";

function ToggleDemo() {


    const[isVisible, setIsVisible] = useState(true);


   
  return (
    <>
        <h3>Show/Hide Content in React</h3>
        <hr/>

        <button onClick={() => setIsVisible(!isVisible)}>
            {isVisible ? 'Hide' : 'Show'} Content
        </button>

        {isVisible && (
            <div>
                <h4>This is some toggleable content!</h4>
                <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Iste ducimus voluptas expedita dolore sapiente quod? Beatae necessitatibus quidem quibusdam corrupti veritatis atque maxime voluptatum saepe tempora dolor! Nemo, atque voluptatem. </p>
            </div>
        )}
    </>
  );
}

export default ToggleDemo;