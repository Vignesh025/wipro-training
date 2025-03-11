import React, { useRef } from 'react'

const UncontrolledComp2 = () => {
    const nameRef = useRef(null);
    const emailRef = useRef(null);

    const handleSubmit = (event) => {
        event.preventDefault();
        alert(`Name: ${nameRef.current.value} and Email: ${emailRef.current.value}`);
    }
  return (
    <div>
        <br/>
        <form onSubmit={handleSubmit}>
            <label> Name: </label>
            <input type="text" ref={nameRef}/><br />
            <label > Email: </label>
            <input type="email" ref={emailRef} /><br />
            <button type="submit">Submit</button>
        </form>
    </div>
  )
}

export default UncontrolledComp2