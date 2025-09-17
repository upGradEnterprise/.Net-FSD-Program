// src/components/ErrorBoundaryExample.js
import { ErrorBoundary } from "react-error-boundary";

function ErrorFallback({ error, resetErrorBoundary }) {
  return (
    <div role="alert" style={{ padding: "20px", background: "#fdd" }}>
      <p><strong>Something went wrong:</strong></p>
      <pre>{error.message}</pre>
      <button onClick={resetErrorBoundary}>Try again</button>
    </div>
  );
}

function BuggyComponent1() {
   //  throw new Error("Boom! Component crashed 🚨");
    return <div>This component-1 is working fine.</div>;
}


function BuggyComponent2() {
   throw new Error("Boom! Component crashed 🚨");
  //  return <div>This component-2 is working fine.</div>;
}
export default function App() {
  return (

    <> 
      <ErrorBoundary
        FallbackComponent={ErrorFallback}
        onReset={() => {
          // Reset the state of your app so the error doesn't happen again
          console.log("Resetting error boundary state...");
        }}
      >
         <BuggyComponent1/>
        
      </ErrorBoundary>

       <ErrorBoundary
        FallbackComponent={ErrorFallback}
        onReset={() => {
          // Reset the state of your app so the error doesn't happen again
          console.log("Resetting error boundary state...");
        }}
      >         
         <BuggyComponent2/>   
      </ErrorBoundary>

    </>

   
  );
}
