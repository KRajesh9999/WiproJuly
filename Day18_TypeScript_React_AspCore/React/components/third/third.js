import React, {Component} from 'react';

const Third = (props) => {
  return(
    <div>
      <p>Third Component in React.</p>
      First Name: <b>{props.firstName}</b>
      Last Name: <b>{props.lastName}</b>
      Company : <b>{props.company}</b>
    </div>
  )
}
export default Third;