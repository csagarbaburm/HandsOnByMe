import React from 'react';

const Demo7 = (props) => {
    return (
        <div>
            <ul>
                {props.cities.map((city)=>(
                    <li>{city}</li>
                ))}
            </ul>
        </div>
    );
}

export default Demo7;
