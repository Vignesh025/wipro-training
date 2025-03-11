import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';

const ItemList = () => {
    const [items, setItems] = useState([]);

    useEffect(() => {
        axios.get("https://jsonplaceholder.typicode.com/posts")
            .then((res) => setItems(res.data))
            .catch((err) => console.log(err));
    }, []);

    const handleDelete = (id) => {
        axios.delete(`https://jsonplaceholder.typicode.com/posts/${id}`)
            .then(() => setItems(items.filter((item) => item.id !== id)))
            .catch((err) => console.log(err));
    };

    return (
        <div>
            <h1>Item List</h1>
            <Link to="/create">Create Item</Link>
            <ul>
                {items.map((item) => (
                    <li key={item.id}>
                        {item.title}
                        <Link to={`/edit/${item.id}`}>Edit</Link>
                        <button onClick={() => handleDelete(item.id)}>Delete</button>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default ItemList;