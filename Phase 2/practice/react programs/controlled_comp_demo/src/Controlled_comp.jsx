import React, { useState } from 'react'

const Controlled_comp = () => {
    const[count,setCount] = useState(0);
  return (
    <div>
        <p>Count: {count}</p>
        <button onClick={() => setCount(count + 1)}>Increment</button>
    </div>
  )
}

export default Controlled_comp;