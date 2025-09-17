import { useEffect } from "react";

function ProductList() {


    useEffect(() => {
        // Simulate data fetching
        console.log("Fetching products...");        
    }, []);

    return (
        <div>
            <h2>Product List</h2>
            <ul>
                <li>Product 1</li>
                <li>Product 2</li>      
                <li>Product 3</li>
            </ul>
        </div>
    );
}

export default ProductList;