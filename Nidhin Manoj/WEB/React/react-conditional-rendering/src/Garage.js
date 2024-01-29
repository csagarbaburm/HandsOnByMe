import React from 'react';

const Garage = (props) => {
    const cars=props.cars;
    return (
        <div>
           <h1>Garage</h1> 
   {cars.length >0? (
    <h2> you have {cars.length } cars in garage</h2>
   ):(
    <h2>No cars!!!</h2>
   )  }     </div>
    );
}

export default Garage;
