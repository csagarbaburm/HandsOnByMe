import React, { Component } from 'react';

class User extends Component {
    constructor (){
        super();
        this.state={
            name: "guest",
            email: "guest@gmail.com"
        };
    }
    //handler
    changeUser =()=>{
        this.setState({
            name:"Sagar",
            email:"sagar@gmail.com"
        });
    }
    render() {
        return (
            <div>
                <h1>Welcome {this.state.name}</h1>
                <h3>Login with {this.state.email}</h3>
<button onClick={this.changeUser}>Submit</button>
                
            </div>
        );
    }
}

export default User;
