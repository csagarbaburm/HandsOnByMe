import React, { useState } from 'react';

const Teacher = () => {
    const[teacher,setTeacher]=useState({
        teacherId:2324,
        teacherName:"Joseph",
        subject:"Maths",
        std:5
    })
    const updateTeacher=()=>
    {
        setTeacher((prevState)=>({
...prevState,

std:8
        }))
    }
    return (
        <div>
            <table className='table table-striped'>
                <thead className='table-dark'>
                    <tr>
                    <th>TeacherId</th>
                    <th>TeacherName</th>
                    <th>Subject</th>
                    <th>Std</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{teacher.teacherId}</td>
                        <td>{teacher.teacherName}</td>
                        <td>{teacher.subject}</td>
                        <td>{teacher.std}</td>
                    </tr>
                </tbody>
            </table>
<button onClick={updateTeacher}>Update Std</button>
        </div>
    );
}

export default Teacher;
