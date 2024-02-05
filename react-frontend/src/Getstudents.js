import {React,useState,useEffect} from "react";
import axios from "axios";
const Getstudents=()=>{
    const [students,getStudent]=useState([]);
    useEffect(()=>{
        axios
            .get("http://localhost:5066/api/Student/GetStudents")
            .then((response)=>{
                console.log(response.data);//return dta send by json
                getStudent(response.data);//add response data to student state
            })
            .catch((error)=>{
                console.log(error);
            });
    },[]);
    return(
        <div className="container">
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Standard</th>
                        <th>Section</th>
 
                    </tr>
                </thead>
                <tbody>
                    {students.map((student)=>{
                        return(
                            <tr>
                                <td>{student.id}</td>
                                <td>{student.name}</td>
                                <td>{student.std}</td>
                                <td>{student.section}</td>
 
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    )
}
export default Getstudents;