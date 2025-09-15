//  npm i formik 

import React from "react";
import { useFormik } from "formik";

function FormikForm() {


  const formik = useFormik({

    initialValues: {
      email: "",
      password: "",
    },
    validate: (values) => {
      const errors = {};
      
      if (!values.email) {
        errors.email = "Email is required";
      } else if (!values.email.includes("@")) {
        errors.email = "Invalid email address";
      }

      if (!values.password) {
        errors.password = "Password is required";
      } else if (values.password.length < 6) {
        errors.password = "Password must be at least 6 characters";
      }

      return errors; // very important to return errors object
    },
    onSubmit: (values) => {
      alert("Form data is valid! Check console for details.");
      console.log("Form data is valid:", values);

      //  axios.post("https://example.com/api/submit", values)
      //    .then(response => console.log("Data submitted successfully:", response))
      //    .catch(error => console.error("Error submitting data:", error));
    },
  });

  return (
    <> 

    <h3>Performing validations in React Using Formik library </h3>
    <hr/>

    <form onSubmit={formik.handleSubmit} noValidate>
      E-mail Id :  <input
        type="email"
        name="email"
        value={formik.values.email}
        onChange={formik.handleChange}
      />
      {formik.errors.email && <span style={{color: "red"}}>{formik.errors.email}</span>}
    <br/><br/>
      Password :  <input
        type="password"
        name="password"
        value={formik.values.password}
        onChange={formik.handleChange}
      />
      {formik.errors.password && <span style={{color: "red"}}>{formik.errors.password}</span>}
    <br/><br/>
      <button type="submit">Submit</button>
    </form>
    </>
  );
}

export default FormikForm;
