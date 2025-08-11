import React, {Component} from 'react';

const ButtonEx = () => {
  const rajesh = () => {
    alert("Hi I am Rajesh");
  }

  const rakesh = () => {
    alert("Hi I am Rakesh");
  }

   const uday = () => {
    alert("Hi I am Uday...");
  }

  return(
    <div>
      <input type="button" value="Rajesh" onClick={rajesh} /> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Rakesh" onClick={rakesh} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Uday" onClick={uday} />
    </div>
  )
} 
export default ButtonEx;