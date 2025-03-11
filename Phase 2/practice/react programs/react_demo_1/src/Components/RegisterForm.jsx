import React from 'react'

const RegisterForm = () => {
  return (
    <div>
        <h3>Register</h3>
        <form >
        <label for="firstname">First Name  </label>
        <input type="text" name="firstname" id="firstname" placeholder='First Name'/><br/><br/><br/>
        <label for="lastname">Last Name  </label>
        <input type="text" name="lastname" id="lastname" placeholder='Last Name'/><br/><br/><br/>
        <label>Gender  </label>
        <input type="radio" name="gender" id="gender1" value="male" />
        <label for="gender1">Male</label>
        <input type="radio" name="gender" id="gender2" value="female" />
        <label for="gender2">Female</label><br/><br/><br/>
        <label>Qualification  </label>
        <input type="checkbox" id="qualification1" name="qualification1" value="Diploma"/>
        <label for="qualification1"> Diploma</label>
        <input type="checkbox" id="qualification2" name="qualification2" value="Bachelors"/>
        <label for="qualification2"> Bachelors</label>
        <input type="checkbox" id="qualification3" name="qualification3" value="Masters"/>
        <label for="qualification3"> Masters</label><br/><br/><br/>
        <label for="city">City  </label>
        <select name="city" id="city">
            <option value="">--Please choose an option--</option>
            <option value="Chennai">Chennai</option>
            <option value="Mumbai">Mumbai</option>
            <option value="Bangalore">Bangalore</option>
            <option value="Delhi">Delhi</option>
            <option value="Kolkata">Kolkata</option>
        </select><br/><br/><br/>
        <label for="address">Address  </label>
        <textarea id="address" name="address" placeholder='Your Address..'></textarea><br/><br/><br/>
        <button id='submit'>Submit</button>
        </form>
        {
            document.getElementById('submit').addEventListener('click', function(event){
                event.preventDefault();
                alert('Form Submitted Successfully');
            })
        }
    </div>
  )
}

export default RegisterForm