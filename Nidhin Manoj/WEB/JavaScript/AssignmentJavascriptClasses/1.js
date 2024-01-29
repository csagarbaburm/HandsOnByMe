class Bookstore{
    constructor(isbn,bookname,booktitle,bookauthor,quantityofbooks,bookprice)
    {
        this.isbn=isbn;
        this.bookname=bookname;
        this.booktitle=booktitle;
        this.bookauthor=bookauthor;
        this.quantityofbooks=quantityofbooks;
        this.bookprice=bookprice;
    
    
        }
    show(){
        let bill= this.show1();
        console.log(`BookNo:${this.isbn} BookName: ${this.bookname} BookTitle:${this.booktitle} BookAuthor: ${this.bookauthor} Quantity Of Books: ${this.quantityofbooks} BookPrice:${this.bookprice} Bill: ${bill}`);
    
    }
show1(){    
     return this.quantityofbooks*this.bookprice;
}
  
}

     let obj= new Bookstore(1,"Luther","Comic","Martin",5,5000);
    obj.show();
  