import React, { useState } from 'react';
 
const Student = () => {
    const[student,setStudent] = useState({
        id:1212,
        name:"adithya",
        std:7,
        section:'A',
    })
    const updateStudent=()=>
    {
        setStudent((prevState)=>({
            ...prevState,
            std:4,
            section:'B',
        }));
 
    }
    return (
        <div>
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Class</th>
                        <th>SecTion</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{student.id}</td>
                        <td>{student.name}</td>
                        <td>{student.std}</td>
                        <td>{student.section}</td>
                        <td><button type='button' onClick={updateStudent}>Click ME</button></td>
                    </tr>
                   
                </tbody>
            </table>
           
        </div>
    );
}
 
export default Student;
 
