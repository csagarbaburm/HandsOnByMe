const Greet= (name) => "Hello" + name;
console.log(Greet("sanjay"));
console.log(Greet('Nidhin'));
const Add=(a,b)=> a+b;
console.log(Add(12,10));
let IsEven=(n)=> n%2==0;
console.log(IsEven(2)? "Even":"Odd");
console.log(IsEven(3)? "Even":"Odd");
const Sum=(a)=>
{
let result=0;
for(let k of a)
result = result + k;
return result;
}
console.log(Sum([2,3,2,3,4,6]));