import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom'
import axios from 'axios'

const CreateItem = () => {
    const [title,setTitle] = useState("");

    const navigate = useNavigate();

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.post("https://jsonplaceholder.typicode.com/posts", {title})
        .then(() => navigate("/"))
        .catch((err) => console.log(err));
    };

  return (
    <form onSubmit={handleSubmit}>
        <h1>Create Item</h1>
        <input type='text' value={title} onChange={(e) => setTitle(e.target.value)} placeholder='Enter Title' />
        <button type='Submit'>Create Item</button>
    </form>
  );
}

export default CreateItem