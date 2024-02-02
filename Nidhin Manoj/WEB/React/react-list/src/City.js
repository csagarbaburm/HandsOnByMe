import React from 'react';
const CityinKerala =(props)=>
{
    return(
        <>
        <h3>{props.name}</h3>
        <br/>
        </>
    );
};
const City = () => {
    let cites = ['Tvm','Kollam','Varkala','Kasargod','Kottayam']
    return (
        <div>
            <h1>Cities in Kerala </h1>
            {
                cites.map((c)=><CityinKerala name={c} />)
            }
           
        </div>
    );
}
 
export default City;