import React from 'react';

const Demo2 = () => {
    let countries=['India','Nepal','Afrca','America'];
    return (
        <div>
            
                <h1>Countries list</h1>
            {countries.map((items)=>(
                <li>{items}</li>
            ))}
        </div>
    );
}

export default Demo2;
