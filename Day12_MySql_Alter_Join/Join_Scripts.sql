-- Join Keyword

-- 1. Inner Joining Employ and LeaveHistory tables
select Employ.Empno, Name, Dept, Basic,
LeaveHistory.LeaveId, LeaveStartDate, LeaveEndDate
from Employ Inner Join LeaveHistory
ON Employ.Empno = LeaveHistory.EmpNo

select E.Empno, Name, Dept, Basic,
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E INNER JOIN LeaveHistory LH
ON E.Empno = Lh.EmpNO

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A INNER JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
INNER JOIN Policy P ON P.PolicyId = AP.PolicyID

--2.  Outer Join Examples
select E.Empno, Name, Dept, Basic, LH.LeaveId,
LeaveStartDate, LeaveEndDate
from Employ E LEFT JOIN LeaveHistory LH
ON E.Empno = Lh.EmpNo


select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A LEFT JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
LEFT JOIN Policy P ON P.PolicyId = AP.PolicyID

--3. RIGHT Outer JOin
select E.Empno, Name, Dept, Basic,
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E RIGHT JOIN LeaveHistory LH
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
RIGHT JOIN Policy P ON P.PolicyId = AP.PolicyID


-- 4. Full Outer JOIN
select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, Modalpremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON
A.AgentId = AP.AgentID
RIGHT JOIN Policy P ON P.PolicyId = AP.PolicyID

-- 5. Cross Join 
select * from Agent cross join AgentPolicy
select * from Policy Cross Join AgentPolicy