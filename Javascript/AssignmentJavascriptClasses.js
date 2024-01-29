class Student{
    constructor(rollno,name,markofeng,markofmaths,markofscience)
    {
this.rollno=rollno;
this.name=name;
this.markofeng=markofeng;
this.markofscience=markofscience;
this.markofmaths=markofmaths;

    }
    Show()
    {
        // let Total= this.FindTotalMarks();
        // let per= this.FindPercentage();
       console.log(`Total Marks:${this.FindTotalMarks()} Percentage: ${this.FindPercentage()} `);
    }
    FindTotalMarks(){
        return this.markofeng+this.markofmaths+this.markofscience;
    }
    FindPercentage(){
        return ((this.FindTotalMarks())/300)*100;
    }
   
}
let student= new Student (1,"Nidhin",25,25,50);
student.Show();