import React from 'react'
import { Link } from 'react-router-dom';

const UserList = () => {
    const users = ['Cristiano','Neymar','Ronaldo','Lionel'];
  return (
        <ul>
            {users.map(user=> (
                <li key={user}>
                    <Link to={`/profile/${user}`}>{user}'s Profile</Link>
                </li>
            ))}
        </ul>
  )
}

export default UserList