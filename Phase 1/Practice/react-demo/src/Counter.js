import React, { useState } from 'react'
import CounterDisplay from './CounterDisplay';
import { decrement, increment } from './utils';

const Counter = () => {
    const [count,setCount] = useState(0);
  return (
    <div>
        <CounterDisplay count = {count}/>
        <button onClick={()=>setCount(increment(count))}>Increment</button>
        <button onClick={()=>setCount(decrement(count))}>Decrement</button>
    </div>
  )
}

export default Counter