const express = require('express');
const path = require('path');
const app = express();
const port = 3000;

app.use(express.static(path.join(__dirname,'public')));

app.get('/',(req,res)=>{
    res.send('Hello, Express.js!');
});

app.get('/index',(req,res)=>{
    res.sendFile(path.join(__dirname,'public','index.html'));
});

app.get('/aboutus',(req,res)=>{
    res.sendFile(path.join(__dirname,'public','aboutus.html'));
});

app.listen(port,()=>{
    console.log(`Server running at http://localhost:${port}`);
});