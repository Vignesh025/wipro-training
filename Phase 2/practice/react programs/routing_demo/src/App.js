import About from './About';
import './App.css';
import Contact from './Contact';
import Home from './Home';
import { BrowserRouter as Router, Link, Routes, Route } from 'react-router-dom';
import Profile from './Profile';
import UserList from './UserList';

function App() {
  return (
    <Router>
      <div>
        <nav>
          <ul>
            <li><Link to="/">Home</Link></li>
            <li><Link to="/about">About</Link></li>
            <li><Link to="/contact">Contact</Link></li>
          </ul>
        </nav>
        <Routes>
          <Route path="/" element = {<Home />} />
          <Route path="/about" element = {<About />} />
          <Route path="/contact" element = {<Contact />} />
          <Route path="/profile/:username" element = {<UserList />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
