import GrandChild from "./GrandChild";

function Child() {
    return (
         <div style={{margin:"10px", border:"2px solid Red"}}>
            <h2>Child Component</h2>
            <GrandChild />
        </div>
    );
}   

export default Child;