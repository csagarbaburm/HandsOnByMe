import React from 'react';

const Football = () => {
    const shoot=(a,b)=>{
    alert("Great "+a);
    alert(b.type);
};
    return (
        <div>
            <button onClick={(event)=>shoot("Goal",event)}>Hit!!</button>
        </div>
    );
}

export default Football;
