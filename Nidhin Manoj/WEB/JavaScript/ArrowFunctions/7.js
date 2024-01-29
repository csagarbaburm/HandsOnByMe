let a=[12,23,34,45];
let b=[1,2,...a];
console.log(b);
function sum(...a){
    let r=0;
    for(let k of a)
    r=r+k;
console.log("sum= " +r );
}
sum(12,33,45);
sum(45,56,67,67);
sum(1,2,3,4,5,6);