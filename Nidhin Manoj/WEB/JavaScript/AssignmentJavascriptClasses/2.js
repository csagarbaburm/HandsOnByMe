class Student {
    
    constructor(RollNo,
		StudName,
		MarksInEng,
		MarksInMaths,
		MarksInScience)
        {

this.StudName=StudName;
this.RollNo=RollNo;
this.MarksInEng=MarksInEng;
this.MarksInMaths=MarksInMaths;
this.MarksInScience=MarksInScience;
    }
Show(){
    let totalmarks= this.FindTotalMarks();
    let percentage=this.FindPercentage();
    console.log(`Percentage of the Student:${percentage} Total Marks:${totalmarks}`);

}
FindTotalMarks(){
return this.MarksInEng+this.MarksInMaths+this.MarksInScience;
}
FindPercentage(){
    return ((this.FindTotalMarks())/300)*100;
}
}
let student = new Student(27,"Nidhin",46,34,45);
student.Show();



