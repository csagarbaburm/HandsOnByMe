import {React,useState} from "react";
const MyForm=()=>{
    
    const [uname,setName] =useState("");
    const [age,setAge]= useState(0); 
    const [msg, setMessage]= useState("");
const handName =(event)=>{
    setName(event.target.value);
};
const handleAge =(event)=>{
    setAge(event.target.value);
};
const handleSubmit=(event)=>{
    event.preventDefault();
    setMessage(`Hello ${uname} you are ${age}`)
};
    
return(
       <div className="container">
        <form >
            <table className="table table-bordered" style={{width:"400px", marginTop: "20px"}}>
<tr>
    <td>
        Enter Name
    </td>
    <td>
        <input type="text" value={uname} onChange={handName} className="form-control"/>
    </td>
</tr>
<tr>
    <td colspan={2}>
        <button className="btn btn-primary" type="submit" >submit</button>
    </td>
</tr>
{/* <tr>
    <td colSpan={2}>
        <span className="text-primary">Good Morning {uname}</span>
    </td>
</tr> */}
            </table>
        </form>
        </div>
    )
}
export default MyForm;