import Child from "./Child";

function Parent() {
    return (
        <div style={{margin:"10px", border:"2px solid Green"}}>
            <h1>Parent Component</h1>
            <Child />
        </div>
    );
}

export default Parent;