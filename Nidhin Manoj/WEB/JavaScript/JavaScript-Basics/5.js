// if-else-if
let m1=79,m2=47,m3=78,m4=89,m5=90;
let total = m1+ m2 + m3 + m4 + m5;
let avg = total/5;
let grade = "";
if(m1>40&&m2>40&&m3>40&&m4>40&&m5>40){
if(avg>=70) grade= "distinction";
else if(avg>=60) grade ="first class";
else if(avg>=50) grade ="second class";
else grade ="third class";
console.log(`Grade:${grade}\nTotal Marks:${total}\nPercentage:${avg}%`);
}
else
{
    console.log("Result : Failed");
}