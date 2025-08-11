const calc = (a : number, b : number, c? : number) => {
    if(typeof c !== 'undefined')
    {
        return a + b + c;
    }
    return a + b;
}
console.log(calc(12,8,22));
console.log("Result when c is undefined: "+calc(12,8));