let no=[12,45,32,65,76,87,43,78];
 no.forEach((i) =>console.log(i));
 no.forEach((i)=>console.log(i * i));
 no.forEach((i)=> {
 if(i%2==0)
 console.log(i); });
 console.clear();

 let k=no.find((i=>i>50));
 console.log(k);
k=no.find((i)=>i%2==0);
console.log(k);
let a=no.filter((i)=>i%2==0);
console.log(a);