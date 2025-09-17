import React, { Suspense, lazy } from "react";

// Instead of importing directly:
// import ProductList from "./components/ProductList";

// Lazy import
const ProductList = lazy(() => import("./ProductList"));

export default function App() {
  return (
    <div>
      <h1>Lazy Loading in React</h1>
      <hr/>
      {/* Suspense shows fallback until ProductList is loaded */}
      <Suspense fallback={<div>Loading products...</div>}>
        <ProductList />
      </Suspense>
    </div>
  );
}
