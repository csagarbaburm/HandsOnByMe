import React from 'react';

const Demo3 = () => {
    let employees=['Bince','Adithya','Nidhin'];
    return (
        <div>
            <table className='table table-stripped'>
            <thead>
                <th>Employee</th>
                </thead>
<tbody>
    {
        employees.map((emp)=><tr><td>{emp}</td></tr>)
    }
</tbody>
                
            </table>
        </div>
    );
}

export default Demo3;
