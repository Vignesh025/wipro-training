import React from 'react'
import { useParams } from 'react-router-dom';

const Profile = () => {
    const {username} = useParams();
  return (
    <div>
        <h1>Profile of {username}</h1>
    </div>
  )
}

export default Profile