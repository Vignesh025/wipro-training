import React, { useRef } from 'react';

const UncontrolledComp = () => {
    const inputRef = useRef(null);

    const handleSubmit = (event) => {
        event.preventDefault(); // Prevent the default form submission behavior
        alert(`Input Value: ${inputRef.current.value}`);
    };

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <label>Enter Value:</label>
                <input type="text" ref={inputRef} />
                <button type='submit'>Submit</button>
            </form>
        </div>
    );
};

export default UncontrolledComp;