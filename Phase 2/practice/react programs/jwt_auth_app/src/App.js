import {BrowserRouter as Router, Routes ,Route, Navigate  } from 'react-router-dom';
import './App.css';
import Login from './Login';
import Protected from './Protected';

function App() {
  const isAuthenticated = !!localStorage.getItem('token'); // Check if user is logged in

  return (
    <Router>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route
          path="/protected"
          element={isAuthenticated ? <Protected /> : <Navigate to="/" replace />}
        />
      </Routes>
    </Router>
  );
}

export default App;