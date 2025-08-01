--1) Display Last Occurrence of given char in a string
--Ex : 'Keerthi' char 'e' exists 2 times last time at position 3 

DECLARE @str VARCHAR(50) = 'Keerthi';
DECLARE @ch CHAR(1) = 'e';

SELECT LEN(@str) - CHARINDEX(@ch, REVERSE(@str)) + 1 AS Last_Occurrence;
GO


--2) Take FullName as 'Rajesh Kethireddy' and split them into firstName and LastName

DECLARE @FullName VARCHAR(100) = 'Rajesh Kethireddy';

SELECT 
  LEFT(@FullName, CHARINDEX(' ', @FullName) - 1) AS FirstName,
  RIGHT(@FullName, LEN(@FullName) - CHARINDEX(' ', @FullName)) AS LastName;
GO


--3) In Word 'misissipi' count no.of 'i' 

DECLARE @word VARCHAR(50) = 'misissipi';

SELECT LEN(@word) - LEN(REPLACE(@word, 'i', '')) AS CountOf_i;
GO


--4) Display the last day of next month

SELECT EOMONTH(GETDATE(), 1) AS LastDay_NextMonth;
GO


--5) Display First Day of Previous Month

SELECT 
  CAST(DATEFROMPARTS(YEAR(DATEADD(MONTH, -1, GETDATE())), MONTH(DATEADD(MONTH, -1, GETDATE())), 1) AS DATE) AS FirstDay_PreviousMonth;
GO


--6) Display all Fridays of current month

-- Create recursive CTE for date range from previous month to next month
--OPTION (MAXRECURSION 1000);

WITH Dates AS (
    SELECT CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()) - 1, 1) AS DATE) AS dt
    UNION ALL
    SELECT DATEADD(DAY, 1, dt)
    FROM Dates
    WHERE dt < EOMONTH(GETDATE(), 1)
)
SELECT dt AS Friday
FROM Dates
WHERE DATENAME(WEEKDAY, dt) = 'Friday';
GO

-- Count total Fridays
WITH Dates AS (
    SELECT CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()) - 1, 1) AS DATE) AS dt
    UNION ALL
    SELECT DATEADD(DAY, 1, dt)
    FROM Dates
    WHERE dt < EOMONTH(GETDATE(), 1)
)
SELECT COUNT(*) AS Total_Fridays
FROM Dates
WHERE DATENAME(WEEKDAY, dt) = 'Friday';
GO
