import React from "react";
import styled from "styled-components";

const Button = styled.button`
  background-color: blue;
  color: white;
  font-size: 1.5rem;
  padding: 0.5rem 1rem;
  border-radius: 5px;
  cursor: pointer;
  margin: 1rem;
`;

const App1 = () => (
    <div>
        <Button>Click Me</Button>
    </div>
)

export default App1;