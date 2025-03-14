const express = require('express');
const bodyParser = require('body-parser');
const bcrypt = require('bcryptjs');
const jwt = require('jsonwebtoken');
const cors = require('cors');

const app = express();
app.use(bodyParser.json());
app.use(cors());

const users = [];

const SECRET_KEY = "KrDIZQAvPw2NGH5YfO2U5WeyRz0toyNy";

app.post('/register', async (req, res) => {
  const { username, password } = req.body;
  const hashedPassword = await bcrypt.hash(password, 10);
  users.push({
    username,
    password: hashedPassword
  });
  res.json({ message: 'User registered successfully' });
});

app.post('/login', async (req, res) => {
    const {username, password} = req.body;
    const user = users.find(user => user.username === username);
    if( !user || !(await bcrypt.compare(password, user.password)) ){
        return res.status(401).json({ message: 'Invalid username or password' });
    }

    const token = jwt.sign({ username }, SECRET_KEY, { expiresIn: '1h' });
    res.json({token});
});

app.get("/protected", (req, res) => {
    const authHeader = req.headers.authorization;
    if(!authHeader) return res.sendStatus(401).json({ message: 'No token provided' });
    const token = authHeader.split(' ')[1];

    jwt.verify(token, SECRET_KEY, (err, decoded) => {
        if(err) return res.sendStatus(403).json({ message: 'Invalid token' });
        res.json({message: 'Welcome to the protected route',user: decoded});
    });
});

app.use(cors({
    origin: 'http://localhost:3000', // Replace with your client's origin
    credentials: true,
  }));
  
app.listen(5000, () => {
    console.log('Server running on port 5000');
    });