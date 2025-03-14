import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const [loading, setLoading] = useState(false);
    const navigate = useNavigate();

    const handleLogin = async (e) => {
        e.preventDefault();

        // Input validation
        if (!username || !password) {
            setError('Please fill in all fields.');
            return;
        }

        setLoading(true);
        setError('');

        try {
            const response = await axios.post('http://localhost:5000/login', {
                username,
                password,
            });

            // Store the token in localStorage
            localStorage.setItem('token', response.data.token);

            // Redirect to the protected route
            navigate('/protected');
        } catch (error) {
            if (error.response) {
                // Handle server errors
                if (error.response.status === 401) {
                    setError('Invalid username or password.');
                } else {
                    setError('An error occurred. Please try again.');
                }
            } else {
                // Handle network errors
                setError('Unable to connect to the server. Please check your connection.');
            }
            console.error('Login error:', error);
        } finally {
            setLoading(false);
        }
    };

    return (
        <form onSubmit={handleLogin}>
            <h1>Login</h1>
            {error && <p style={{ color: 'red' }}>{error}</p>}
            <div>
                <input
                    type="text"
                    placeholder="Username"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    disabled={loading}
                />
            </div>
            <div>
                <input
                    type="password"
                    placeholder="Password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    disabled={loading}
                />
            </div>
            <button type="submit" disabled={loading}>
                {loading ? 'Logging in...' : 'Login'}
            </button>
        </form>
    );
};

export default Login;