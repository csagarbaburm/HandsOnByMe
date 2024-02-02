import React from 'react';

const Car = (props) => {
    
    return <li>I am a {props.brand}</li>;
};
const Garage =()=>{
    let cars=["Audi","Benz","BMW","Fiat"];
    return (
        <div>
            <h1>List of car brands</h1>
            {cars.map((c)=>(
            <Car brand={c}/>))}
        </div>
    );
}

export default Garage;
