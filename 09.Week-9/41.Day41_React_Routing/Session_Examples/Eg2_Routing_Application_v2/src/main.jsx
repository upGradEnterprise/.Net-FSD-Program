import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
//import './index.css'
import App from './App.jsx'
import { BrowserRouter, Link, Route, Routes } from 'react-router-dom';
import About from './components/About.jsx';
import Navbar from './components/Navbar.jsx';
import Depts from './components/Depts.jsx';
import Contact from './components/Contact.jsx';
import NotFound from './components/NotFound.jsx';
import Emps from './components/Emps.jsx';
import Details from './components/Details.jsx';
import Dashboard from './components/AdminDashboard/Dashboard.jsx';
import Profile from './components/AdminDashboard/Profile.jsx';
import Settings from './components/AdminDashboard/Settings.jsx';


const routing = (
    <BrowserRouter>

       <Navbar />   

        <Routes>
            <Route path="/" element={<App />} />
            <Route path="/About" element={<About />} />
            <Route path="/Depts" element={<Depts />} />   
            <Route path="/Emps" element={<Emps />} />   
            <Route path="/Contact" element={<Contact />} />
            <Route path="/Details/:id" element={<Details />} />

             <Route path="/Dashboard" element={<Dashboard />}>                 
                  <Route index element={<Profile />} />   
                  <Route path="Profile" element={<Profile />} />
                  <Route path="Settings" element={<Settings />} />  
             </Route>


            <Route path="*" element={<NotFound />} />
        </Routes>
    </BrowserRouter>
);

createRoot(document.getElementById('root')).render(
  <StrictMode>
    {routing}
  </StrictMode>,
);
