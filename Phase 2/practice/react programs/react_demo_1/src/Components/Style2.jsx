import React from "react";
import styled from "styled-components";

const Card = styled.div`
    background-color: #f9f9f9;
    border-radius: 5px;
    padding: 1rem;
    margin: 1rem;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    `;

const App2 = () => (
    <div>
        <Card>
            <h1>Hello World</h1>
            <p>This is a styled card.</p>
        </Card>
    </div>
)

export default App2;