import {React,useState} from "react";
const MyForm=()=>{
    let [uname,setName] =useState("");
    const submitForm=(e)=>{
        e.preventDefault();
      alert("Hello " + uname);
      
    }
    return(
        <div className="container">
        <form onSubmit={submitForm}>
            <table className="table table-bordered" style={{width:"400px", marginTop: "20px"}}>
<tr>
    <td>
        Enter Name
    </td>
    <td>
        <input type="text" value={uname} onChange={(e)=>setName(e.target.value)} className="form-control"/>
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