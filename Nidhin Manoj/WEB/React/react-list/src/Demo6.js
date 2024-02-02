import React from 'react';

const Demo6 = () => {
    let students=[
        {id:424242,name:"nidhin", age:22,std:5,section:"A"},
        {id:234325,name:"nidn", age:72,std:7,section:"A"},
        {id:423433,name:"nihin", age:52,std:8,section:"A"},
        {id:235464,name:"nidin", age:23,std:3,section:"B"},
        {id:354646,name:"nivin", age:29,std:9,section:"B"},
    ];
    return (
        <div className='container'>
            <table className='table table-striped'>
<thead>
    <tr>
    <th>Id</th>
    <th>Name</th>
    <th>Age</th>
    <th>Class</th>
    <th>Section</th>
    </tr>
</thead>
<tbody>
    
        {
            students.map((student)=>(
        <tr>
            <td> {student.id}</td>
            <td> {student.name}</td>
            <td> {student.age}</td>
            <td> {student.std}</td>
            <td> {student.section}</td>
            </tr>       
            ))
        }
        
</tbody>
   </table>
        </div>
    );
}

export default Demo6;
