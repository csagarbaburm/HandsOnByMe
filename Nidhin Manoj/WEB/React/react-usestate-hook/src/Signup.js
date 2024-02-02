import React, { useState } from 'react';

const Signup = () => {
//    const [name,setName]= useState("Faris");
// const [email,setEmail]=useState("Fairz@gmail.com");
// const [address,setAddress]=useState("chennai"); 
const [{name,email,address},SetUser]=useState(
    {
        name:"Nidhin",
        email:"nidhin123@gmail.com",
        address:"Chennai"
    }
 );
// const updateUser=()=>{
//     setName("Adhi");
//           setEmail("n@gmail.com") 
//      setAddress("Kottayam")   
    
// }
const updateUser=()=>{
    SetUser(()=>({
        name:"Bince",
        email:email,
        address:"tvm"
    }))
}
return (
        <div>
            
          <p> Name: {name} <span></span>
           email: {email} &nbsp;
           address: {address}
          </p>  
          <button type='button' onClick={updateUser}> change </button>
        </div>
    );
}  

export default Signup;
