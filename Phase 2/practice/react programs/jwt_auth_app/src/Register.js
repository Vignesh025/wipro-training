import axios from 'axios'

const registerUser = async () => {
  try{
    const response = await axios.post("http://localhost:5000/register", {
      username: "testuser",
      password: "password123",
  });
  console.log(response.data.message);
} catch (error) {
    console.log("Error registering user",error);
}
};

registerUser();