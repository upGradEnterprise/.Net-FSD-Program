import { useState } from "react";

function SignupForm() {
    const [email, setEmail] = useState("");
    const [error, setError] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        
        if (!email.includes("@")) {
            setError("Invalid email address");
        }
        else {
            setError("");
            alert("Submitted:"+ email);
        }
    };


    return (

        <>
            <h3>React Forms & Validations</h3>
            <hr />

            <form onSubmit={handleSubmit}>
                E-mail :  <input type="email" value={email}
                    onChange={(e) => setEmail(e.target.value)}
                />
                {error && <span style={{ color: "red" }}>{error}</span>}
                <br/>
                <br/>
                <button type="submit">Submit</button>
            </form>

        </>
    );
}


export default SignupForm;