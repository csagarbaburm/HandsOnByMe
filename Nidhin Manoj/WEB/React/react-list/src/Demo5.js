import React from 'react';

const Demo5 = () => {
    let item ={id:424242,name:"nidhin", age:22,std:5,section:"A"};
    return (
        <div className='container'>
            <pre className='text-primary'>
        Id: {item.id} <br></br>
        Name: {item.name}<br></br>
        Age: {item.age}<br></br>
        Class: {item.std}<br></br>
        Section: {item.section}
        </pre>
        </div>
    );
}

export default Demo5;
