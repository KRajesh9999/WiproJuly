import React, {Component, useState} from 'react';

const Four = () => {
  const [name, setName] = useState('')

  const Rajesh = () => {
    setName("Hi I am Rajesh...!");
  }

  const Rakesh = () => {
    setName("Hi I am Rakesh....!");
  }

   const uday = () => {
    setName("Hi I am Uday...");
  }

  return(
    <div>
      <input type = "button" value = "Rajesh" onClick = {Rajesh}/>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type = "button" value = "Rakesh" onClick = {Rakesh}/>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <input type="button" value="Uday" onClick={uday} />
     <hr/>
     Name is : <b>{name}</b>
    </div>
  )
}
export default Four;