use EmpSample_#OK
Go

SELECT * 
FROM tblEmployees;
GO

--1.Write a query to Get a List of Employees who have a one part name
SELECT Name
FROM tblEmployees
WHERE CHARINDEX(' ', Name) = 0;
GO
--select emp.Name
--from dbo.tblEmployees emp
--where emp.Name not like '%[ ]%';

--2 Write a query to Get a List of Employees who have a three part name

SELECT Name
FROM tblEmployees
WHERE LEN(Name) - LEN(REPLACE(Name, ' ', '')) = 2;
GO
/*
select emp.Name
from dbo.tblEmployees emp
where emp.Name like '[a-z]%[ ][a-z]%[ ][a-z]%' and emp.Name not like '[a-z]%[ ][a-z]%[ ][a-z]%[ ][a-z]%';
*/

--3. write a query to get a list of Employees who have a First Middle Or last name as Ram, and not any thing else

SELECT Name
FROM tblEmployees
WHERE ' ' + Name + ' ' LIKE '% Ram %';
GO
/*
select emp.Name
from dbo.tblEmployees emp
where emp.Name like 'ram[ ]%' or emp.Name like '%[ ]ram' or emp.Name like '%[. ]ram[ ]%';
*/

--4. Write the answers for  the Below
--65 OR 11
--65 XOR 11
--65 AND 11
--(12 AND 4) OR ( 13 AND 1)
--127  OR  64
--127  XOR 64
--127 XOR 128
--127 AND 64
--127 AND 128

-- 1. 65 OR 11

--SELECT 65 | 11 AS Result1; GO

select emp.EmployeeNumber, emp.Name, emp.CentreCode
from dbo.tblEmployees emp
where emp.CentreCode = 65 or emp.CentreCode = 11;

-- 2. 65 XOR 11
--SELECT 65 ^ 11 AS Result2;GO

select COUNT(*)
from dbo.tblEmployees emp
where (emp.CategoryCode = 65 and emp.CentreCode <> 11) or ((emp.CategoryCode <> 65 and emp.CentreCode = 11));
  
  --OR
/*
select COUNT(*)
from tblEmployees emp
where (emp.CategoryCode = 65 or emp.CentreCode = 11) and ((emp.CategoryCode <> 65 and emp.CentreCode <> 11));  
*/

-- 3. 65 AND 11
--SELECT 65 & 11 AS Result3;GO

select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from tblEmployees emp
where emp.CategoryCode = 12 and emp.CentreCode = 4;

-- 4. (12 AND 4) OR (13 AND 1)
-- SELECT (12 & 4) | (13 & 1) AS Result4;GO
select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from dbo.tblEmployees emp
where (emp.CategoryCode=12 and emp.CentreCode=4)or (emp.CategoryCode=13 and emp.CentreCode=1);

-- 5. 127 OR 64
--SELECT 127 | 64 AS Result5;GO
select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 or emp.EmployeeNumber = 64;

-- 6. 127 XOR 64
--SELECT 127 ^ 64 AS Result6;GO
select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 64) or ((emp.CategoryCode <> 127 and emp.CentreCode = 64));

-- 7. 127 XOR 128
--SELECT 127 ^ 128 AS Result7;GO
select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 128) or ((emp.CategoryCode <> 127 and emp.CentreCode = 128));

-- 8. 127 AND 64
--SELECT 127 & 64 AS Result8;GO
select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 64;

-- 9. 127 AND 128
--SELECT 127 & 128 AS Result9;GO
select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 128;

--5. Write a query which returns data in all columns from the table dbo.tblCentreMaster

SELECT * 
FROM dbo.tblCentreMaster;
GO

--6.      Write a query which gives employee types in the organization.

SELECT DISTINCT EmployeeType 
FROM tblEmployees;
GO

--SELECT DISTINCT EmployeeType, ServiceType
--FROM tblEmployees;
--GO

--7.      Write a query which returns Name, FatherName, DOB of employees whose PresentBasic is
--a.      Greater than 3000.
SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic > 3000;
GO
--b.      Less than 3000.
SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic < 3000;
GO
/*
select emp.Name, emp.FatherName, emp.DOB, emp.PresentBasic
from dbo.tblEmployees emp
where emp.PresentBasic < 30000;
GO
*/

--c.      Between 3000 and 5000.
SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic BETWEEN 3000 AND 5000;
GO

--8.      Write a query which returns All the details of employees whose Name
--a.      Ends with 'KHAN'
SELECT *
FROM tblEmployees
WHERE Name LIKE '%KHAN';
GO
--b.      Starts with 'CHANDRA'
SELECT Name 
FROM tblEmployees
WHERE Name LIKE 'CHANDRA%';
GO
--c.      Is 'RAMESH' and their initial will be in the rage of alphabets a-t.
--EX:If an employee name is T.Ramesh then your query should return his record.
SELECT Name 
FROM tblEmployees
WHERE Name LIKE '[A-Z].RAMESH';
GO

