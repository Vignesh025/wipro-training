import axios from 'axios';
import React, { useEffect, useState } from 'react';

const Protected = () => {
    const [message, setMessage] = useState("");
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchProtectedData = async () => {
            try {
                const token = localStorage.getItem("token");
                if (!token) {
                    throw new Error("No token found");
                }

                const response = await axios.get("http://localhost:5000/protected", {
                    headers: {
                        Authorization: `Bearer ${token}`,
                    },
                });

                setMessage(response.data.message);
            } catch (error) {
                if (error.response && error.response.status === 401) {
                    setMessage("Unauthorized: Please login again.");
                } else {
                    setMessage("Access denied!");
                }
                setError(error);
            } finally {
                setLoading(false);
            }
        };

        fetchProtectedData();
    }, []);

    if (loading) {
        return <h1>Loading...</h1>;
    }

    if (error) {
        console.error("Error fetching protected data:", error);
    }

    return <h1>{message}</h1>;
};

export default Protected;