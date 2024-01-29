use Assignment2
select*from Employee
select*from Works_on
select*from Project
--Qestion 1
--1)EquiJoin

select e.*,p.* from Works_on e inner join Project p on p.project_no=e.project_no 

--2)Natural Join

select e.*,p.* from Works_on e inner join Project p on p.project_no=e.project_no 

--3)Cartesian product
select e.*,p.* from Works_on e cross join Project p 
--or
select*from Project,Works_on

--Question 2   
select e.emp_no,w.job from Employee e join works_on w on w.emp_no=e.emp_no join project p on  p.project_name='Gemini'

--Question 3
select Employee.emp_fname, Employee.emp_lname from Employee join Department on Employee.Dept_no = Department.Dept_no where Department.Dept_name IN ('Research', 'Accounting')

--Question 4
select Works_on.enter_date from Works_on JOIN Employee on Works_on.emp_no = Employee.emp_no where Employee.Dept_no= 'd1' AND Works_on.Job = 'Clerk'

 --Question 5
SELECT P.Project_name FROM Project P JOIN Works_on W ON P.Project_no = W.Project_no WHERE W.Job = 'Clerk' GROUP BY P.Project_name HAVING COUNT(W.Emp_no) >= 2;

--Question 6
select e.emp_fname, e.emp_lname from Employee e JOIN Works_on w on e.emp_no = w.emp_no  join Project p on w.project_no=p.project_no where p.project_name = 'mercury' AND w.Job = 'Manager'

-- Question 7

select distinct E1.emp_fname, E1.emp_lname FROM Works_on W1 JOIN Employee E1 ON W1.emp_no = E1.emp_no
JOIN Works_on W2 ON W1.enter_date = W2.enter_date AND W1.emp_no <> W2.emp_no

--Question 8

select e1.emp_no from Employee e1
JOIN Department d ON e1.Dept_no = d.Dept_no AND d.location = d.location
 
--Question 9

--9 a)
 select e.emp_no from Employee e join Department d on e.dept_no=d.Dept_no where d.Dept_name='Marketing'
 --9 b)
select emp_no  from Employee where  dept_no in ( select dept_no from Department where Dept_name='Marketing' )

--Modifiying table of contents

--Question 1
 
insert into Employee (emp_no, emp_fname, emp_lname,dept_no)
values (1111, 'Julia', 'Long','null');

--Question 2
update Project set Budget = NULL;
 
--Question 3
update Works_on
set Job = 'Clerk'
where project_no = 'p1' AND Job = 'Manager';
 
--Question 4
update project set Budget = NULL;

--Question 5
update Project
set Budget = Budget * 1.1
where project_no in (select project_no from Works_on where emp_no = 10102 AND Job = 'Manager');

--Question 6
update Works_on
set enter_date = '1998-12-12'
where project_no = 'p1' AND emp_no IN (select emp_no from Employee where Dept_no = 'Sales')

--Question 7
CREATE PROCEDURE sp_InsertDepartmentAndEmployee
@dept_name NVARCHAR(255),
@Location NVARCHAR(255),
@EmployeeName NVARCHAR(255),
@EmployeePosition NVARCHAR(255) 
AS BEGIN 
-- Insert into the department table
INSERT INTO department (dept_name, Location) VALUES (@dept_name, @Location); 
-- Get the department ID of the newly inserted record
DECLARE @DepartmentID INT; 
SET @DepartmentID = SCOPE_IDENTITY(); 
-- Insert into the employee table with the corresponding department ID 
INSERT INTO employee (emp_fname, dept_no) VALUES (@EmployeeName, @DepartmentID);
END;