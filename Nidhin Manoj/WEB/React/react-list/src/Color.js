import React from 'react';

const Color = () => {
    let colors=["Blue","Green","Red","Yellow","Orange"]; 
    return (
        <div>
            <h1>List of colors</h1>
            <ol>
            {colors.map((color)=>(
               <li> {color}</li>
              
            ))}</ol>
       <div>
        <table className='table table-stripped' >
            <thead>
               <th> List of colors </th>
            </thead>
            <tbody>
                {
                    colors.map((color)=>(
                        <tr><td>{color}</td></tr>
                    ))
                }
            </tbody>
        </table>
        </div>




        </div>

    
    );
}
    

export default Color;
