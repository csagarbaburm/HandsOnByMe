
import React from "react";
class Student extends React.Component{

    constructor (props){
        super(props);
        this.state={
            rollno: 23232,
            name:"Nidhin",
            std:7,
            section:"B"

        };

    }
    changeState=()=>{
    this.setState(
        {
            section:"A"
        }
    );
    }
    render(){
        return(
            <div>
<h1>I am  {this.state.name} Rollno {this.state.rollno}</h1>
<h2>I am studying in {this.state.std}, Section {this.state.section}</h2>
<button onClick={this.changeState}>Submit</button>
            </div>
        );
    }
}
export default Student;