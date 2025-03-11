import React, { useEffect, useState } from 'react'
import { useNavigate, useParams } from 'react-router-dom';
import axios from 'axios';

const EditItem = () => {
    const [title,setTitle] = useState("");
    const {id} = useParams();
    const navigate = useNavigate();

    useEffect(() => {
        axios.get(`https://jsonplaceholder.typicode.com/posts/${id}`)
        .then((res) => setTitle(res.data.title))
        .catch((err) => console.log(err));
    },[id]);

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.put(`https://jsonplaceholder.typicode.com/posts/${id}`, {title})
        .then(() => navigate("/"))
        .catch((err) => console.log(err));
    }
  return (
    <form onSubmit={handleSubmit}>
        <h1>Edit Item</h1>
        <input type='text' value={title} onChange={(e) => setTitle(e.target.value)} placeholder='Enter Title' />
        <button type='Submit'>Save Item</button>
    </form>
  )
}

export default EditItem