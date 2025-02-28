const express = require('express');
const app = express();
const port = 3000;

app.use(express.json());

app.get('/api/items',(req,res)=>{
    res.send("Get Request to the /api/items route");
});

app.post('/api/items',(req,res) =>{
    const newItem = req.body;
    res.send(`POST request to the /api/items route with data .... wipro: ${JSON.stringify(newItem)}`);
});

app.put('/api/items/:id',(req,res)=>{
    const itemId = req.params.id;
    const updatedItem = req.body;
    res.send(`PUT request to the /api/items/${itemId} route with the data: ${JSON.stringify(updatedItem)}`);
});

app.delete('/api/items/:id',(req,res) =>{
    const itemId = req.params.id;
    res.send(`DELETE request to the /api/items/${itemId} route .... wipro`);
});

app.patch('/api/items/:id',(req,res) =>{
    const itemId = req.params.id;
    const partialUpdate = req.body;
    res.send(`PATCH request to the /api/items/${itemId} route with the data: ${JSON.stringify(partialUpdate)}`);
});

app.listen(port,()=>{
    console.log(`Server running at http://localhost:${port}`);
});