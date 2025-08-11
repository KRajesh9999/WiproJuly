"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var EmployNew_1 = require("./EmployNew");
var employs = [
    new EmployNew_1.Employ(1, "Rajesh", 99898),
    new EmployNew_1.Employ(2, "Rakesh", 87878),
    new EmployNew_1.Employ(3, "Ramesh", 78776),
    new EmployNew_1.Employ(4, "Raghav", 87877)
];
employs.forEach(function (x) {
    console.log(x.empno + " " + x.name + " " + x.basic);
});
