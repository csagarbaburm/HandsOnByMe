import {React,useState} from 'react';
let courses =[{id:1,cname:"React"},
{id:2,cname:"CSS"},
{id:3,cname:".Net"},
{id:4,cname:"C#"}
];
const MyForm=()=>{
  const [course,setCourse]= useState({id:0,cname:""});
    return(
        <div className='container'>
<label>
    Select Course
</label>
<div className='col'>
<select onChange={(e)=> setCourse({id:e.target[e.target.selectedIndex].value,
cname: e.target[e.target.selectedIndex].text})}>
    {
        courses.map((course)=>(
            <option value={course.id}>{course.cname}</option>
        ))
    }
</select>
</div>
        <span>selected courses for exam id:{course.id} name:{course.cname}</span>
        </div>
    );
};
export default MyForm;