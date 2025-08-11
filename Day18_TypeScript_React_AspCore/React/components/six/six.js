import React, {Component, useState} from 'react';

const Six = () => {
  const [sname,setName] = useState('')

  const handlechange = event => {
    setName(event.target.value)
  }

return(
  <div>
    <form>
      <label>Please Enter you Name: </label>
      <input type = "text" name = 'sname' value={sname} onChange = {handlechange}/>
      <br/>
      Student Name is: {sname}
    </form>
  </div>
)
}
export default Six;