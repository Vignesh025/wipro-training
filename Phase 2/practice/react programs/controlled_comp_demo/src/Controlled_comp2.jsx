import React, { useState } from 'react'

const Controlled_comp2 = () => {
    const[inputvalue,setInputvalue] = useState('');
    const handlechange = (e) => {
        setInputvalue(e.target.value);
    }
  return (
    <div>
        <input type="text" value={inputvalue}
        onChange={handlechange}/>
        <p>Current Value: {inputvalue}</p>
    </div>
  )
}

export default Controlled_comp2