function fn(f1,f2)
{
    console.log(f1());
    console.log(f2());
}
fn(
    ()=>"Happy Morning",
    ()=> "Happy Evening"
);
setTimeout(() => {
   console.log("hello javascript learners")},5000); 

setTimeout(function(){
    console.log("Hello Javascript Learners")},5000);

