let students=[
    {Id:323,Name:"Nidhin", Age:12 },
    {Id:324,Name:"Nevin", Age:22 },
    {Id:424,Name:"Naran", Age:42 },
    {Id:394,Name:"Nanma", Age:27 },
    {Id:545,Name:"Mohan", Age:56 }
    
];
let GetStudents=()=> students

    for(let ob of GetStudents()){
console.log(`ID:${ob.Id} Name:${ob.Name} Age:${ob.Age}`)        
    }
let GetStudentById=(id)=>{
    for(let ob of students){
        if(ob.Id==id)
        return ob;
    }
    return null;
};

let obj= GetStudentById(394);
if (obj!=null)
{
    console.log(`ID:${obj.Id} Name:${obj.Name} Age:${obj.Age}`)
}
else
console.log("invalid ID");

