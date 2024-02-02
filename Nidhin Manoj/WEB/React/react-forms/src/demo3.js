import {React,useState} from "react";
const MyForm=()=>{
      const [uname,setName] =useState("");
    const [names,setNames] =useState([]);
    const save =(e)=>{
        setNames([...names,uname]);
        e.preventDefault();
    };
          return(
        <div className="container">
        <form onSubmit={save}>
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
</table>

<hr/>
<table className="table table-bordered">
    
        {names.map((n)=>(<tr><td>{n}</td></tr>))}
            </table>
        </form>
        </div>
    )
}
export default MyForm;