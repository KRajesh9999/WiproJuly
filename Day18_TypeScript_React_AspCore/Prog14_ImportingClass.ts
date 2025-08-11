import {Employ} from "./EmployNew";

const employs = [
    new Employ(1, "Rajesh", 99898),
    new Employ(2, "Rakesh", 87878),
    new Employ(3, "Ramesh", 78776),
    new Employ(4, "Raghav", 87877)
];

employs.forEach(x => {
    console.log(x.empno + " " +x.name+ " "+x.basic);
});