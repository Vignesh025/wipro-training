import React from 'react'
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import Home from '../Pages/Home';
import AboutUs from '../Pages/AboutUs';
import ContactUs from '../Pages/ContactUs';
import logo from '../Wipro_Primary_Logo_Color_RGB.svg.png';
import RegisterForm from './RegisterForm';

const Navbar = () => {
  return (
    <div>
    <Router>
      <div>
        <nav>
          <ul style={{display: "flex", justifyContent: "space-around"}}>
            <img src={logo} alt="logo" height={50} width={60}/>
            <p><Link to="/">Home</Link></p>
            <p><Link to="/about">About Us</Link></p>
            <p><Link to="/contact">Contact Us</Link></p>
            <p><Link to="/register">Register</Link></p>
          </ul>
        </nav>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<AboutUs />} />
          <Route path="/contact" element={<ContactUs />} />
          <Route path="/register" element={<RegisterForm />} />
        </Routes>
      </div>
    </Router>
    </div>
  )
}

export default Navbar