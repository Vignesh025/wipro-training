import React from 'react'
import PropTypes from 'prop-types'
const Proptypes_comp = ({name,age,isStudent}) => {
  return (
    <div>
        <h1>Name : {name}</h1>
        <h1>Age: {age}</h1>
        <h1>isStudent : {isStudent ? "Yes" : "No"}</h1>
    </div>
  )
}

Proptypes_comp.propTypes = {
    name: PropTypes.string.isRequired,
    age: PropTypes.number.isRequired,
    isStudent: PropTypes.bool
}

Proptypes_comp.defaultProps = {
    isStudent: false
}
export default Proptypes_comp