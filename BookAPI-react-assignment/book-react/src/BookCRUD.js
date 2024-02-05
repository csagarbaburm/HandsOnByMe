function () {
    return (  );
}



{books.map((b)=>{
    return(
    <tr>
        <td>{b.bookId}</td>
        <td>{b.title}</td>
        <td>{b.author}</td>
        <td>{b.publisher}</td>
        <td>{b.year}</td>
    </tr>)
})}


export default ;