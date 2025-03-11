import React from 'react'

const ContactUs = () => {
  return (
    <div>
        <form>
            <h3>Contact Us</h3>
            <label for="name">Name  </label><br/>
            <input type="text" id="name" name="name" placeholder="Your name.."></input><br/>
            <label for="email">Email  </label><br/>
            <input type="email" id="email" name="email" placeholder="Your email.."></input><br/>
            <label for="message">Message  </label><br/>
            <textarea id="message" name="message" placeholder="Write something.."></textarea><br/>
            <input type="submit" value="Submit"></input><br/>
        </form>
    </div>
  )
}

export default ContactUs