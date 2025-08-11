var calc = function (a, b, c) {
    if (typeof c !== 'undefined') {
        return a + b + c;
    }
    return a + b;
};
console.log(calc(12, 8, 22));
console.log("Result when c is undefined: " + calc(12, 8));
