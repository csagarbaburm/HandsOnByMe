import React, { useState } from 'react';

const FavoriteColor = () => {
    //define state
    const [color, setColor]= useState("Green");
const changeColor=()=>
{
    if(color=="Green")
    setColor("Red");
else
setColor("Green")
};
    return (
        <div>
            <h2 text-primary>My FavoriteColor is {color}</h2>
        <button onClick={changeColor}>Change Color</button>
       <button onClick={()=>setColor("orange")}>orange</button>
       <button onClick={()=>setColor("Yellow")}>Yellow</button>
        </div>
    );
}

export default FavoriteColor;
