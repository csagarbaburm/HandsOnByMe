import React, { useState } from 'react';

const Car = () => {
    const [brand,setBrand] =useState("Ford");
    const [model,setModel]=useState("Mustang");
    const [year,setYear]=useState(1876);
    const [color,setColor]=useState("Black");
    return (
        <div>
            <h1>My brand {brand}</h1>
<p>
    It is a {color} {model} from {year}.
</p>
        </div>
    );
}

export default Car;
