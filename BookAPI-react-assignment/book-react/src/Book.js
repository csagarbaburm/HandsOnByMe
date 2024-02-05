import axios from "axios";
import { useEffect, useState } from "react";

function Book() {

    let [bookId,setId]=useState("")
    let [title,setTitle]=useState("")
    let [author,setAuthor]=useState("")
    let [publisher,setPublisher]=useState("")
    let [year,setYear]=useState("")
    let [books,setBook]=useState([])


    useEffect(()=>{
        axios
        .get("http://localhost:60750/api/Book/GetAllBooks")
        .then((response)=>{
        console.log(response.data)
        setBook(response.data)})
        .catch((error)=>{
            console.log(error)
        })
    },[books])


    const Save = () => {
        let book = {
          bookId: bookId,
          title:title,
          author: author,
          publisher: publisher,
          year: year,
        };
        axios
          .post("http://localhost:60750/api/Book/AddBook", book)
          .then((response) => {
            console.log(response.data);
          })
          .catch((error) => console.log(error));
      };
      const Search = () => {
        axios
          .get("http://localhost:60750/api/Book/GetBookByID/" + bookId)
          .then((response) => {
            console.log(response.data);
            setAuthor(response.data.author);
            setPublisher(response.data.publisher);
            setTitle(response.data.title);
            setYear(response.data.year);

          })
          .catch((error) => console.log(error));
      };
      const Edit = () => {
        let book = {
            bookId: bookId,
            title:title,
            author: author,
            publisher: publisher,
            year: year,
          };
        axios
          .put("http://localhost:60750/api/Book/EditBook", book)
          .then((response) => {
            console.log(response.data);
          })
          .catch((error) => console.log(error));
      };
      const Delete = () => {
        axios
          .delete("http://localhost:60750/api/Book/DeleteBook/" + bookId)
          .then((response) => {
            console.log(response.data);
          })
          .catch((error) => console.log(error));
          TableUpdate();
      };
      const TableUpdate=()=>{
        axios
        .get("http://localhost:60750/api/Book/GetAllBooks")
        .then((response)=>{
        console.log(response.data)
        setBook(response.data)})
        .catch((error)=>{
            console.log(error)
        })

      }

    return ( <>
    
    <div
        class="table-responsive"
    >
        <table
            class="table table-primary"
        >



            <tbody>
            <tr>
              <td>Id</td>
              <td>
                <input
                  type="text"
                  value={bookId}
                  onChange={(e) => setId(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Title</td>
              <td>
                <input
                  type="text"
                  value={title}
                  onChange={(e) => setTitle(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Author</td>
              <td>
                <input
                  type="text"
                  value={author}
                  onChange={(e) => setAuthor(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Publisher</td>
              <td>
                <input
                  type="text"
                  value={publisher}
                  onChange={(e) => setPublisher(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Year</td>
              <td>
                <input
                  type="text"
                  value={year}
                  onChange={(e) => setYear(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td colSpan={2}>
                <button type="button" onClick={Save}>Add</button>
                <button type="button" onClick={Search}>
                  Search
                </button>
                <button type="button" onClick={Edit}>
                  Edit
                </button>
                <button type="button" onClick={Delete}>
                  Delete
                </button>
              </td>
            </tr>
            </tbody>
        </table>

        <table>

        <thead>
            <tr>
                <th>
                    Book ID
                </th>
                <th>
                    Title
                </th>
                <th>
                    Author
                </th>
                <th>
                    Publisher
                </th>
                <th>
                    Year
                </th>
            </tr>
        </thead>


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
        </table>
    </div>
    
    
    
    </> );
}

export default Book;