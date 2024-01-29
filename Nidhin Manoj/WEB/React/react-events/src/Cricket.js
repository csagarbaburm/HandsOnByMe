import React from 'react';

const Cricket = () => {
    // const Shot=()=>
    // {
    //     alert('Great shot!!')
    // }
    const Shot=(a)=>
    {
        alert('Great shot!!'+ a)
    }
    return (
        <div>
            {/* <button onClick={Shot}>Take a shot!!</button> */}
            <button onClick={()=> Shot("Nidhin")}>Take a shot!!</button>
            <br></br>
            <button onClick={()=> Shot("Nevin")}>Take a shot!!</button>
        </div>
    );
}

export default Cricket;
