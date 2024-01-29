create database assignment2
use  assignment2

create table Department(
Dept_no varchar(10) not null,
Dept_name varchar(20) not null,
[location] varchar(20) not null
)

Insert into Department values('d1','Research','Dallas'),('d2','Accounting','Seattle'),('d3','Marketing','Dallas')

create table Employee(
emp_no int not null, 
emp_fname varchar(20) not null,
emp_lname varchar(20) not null,
dept_no varchar(10) not null,
)

Insert into Employee values(25348 ,'Matthew', 'Smith', 'd3'),
(10102 ,'Ann', 'Jones', 'd3'),
(18316 ,'John', 'Barrimore', 'd1'),
(29346 ,'James' ,'James' ,'d2')

create table Project(
	project_no varchar(20) not null, 
	project_name varchar(20) not null,
	Budget  int not null
)

Insert into Project values('p1' ,'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3' ,'Mercury' ,185600)


create table Works_on(
	emp_no int not null,
	project_no varchar(10) not null,
	Job varchar(20)  null,
	enter_date date not null
)

Insert into Works_on values(10102 ,'p1', 'Analyst', '1997.10.1'),
(10102 ,'p3', 'manager', '1999.1.1'),
(25348 ,'p2', 'Clerk ','1998.2.15'),
(18316 ,'p2', NULL, '1998.6.1'),
(29346 ,'p2' ,NULL ,'1997.12.15'),
(2581 ,'p3', 'Analyst', '1998.10.15'),
(9031 ,'p1', 'Manager' ,'1998.4.15'),
(28559 ,'p1', NULL ,'1998.8.1'),
(28559 ,'p2' ,'Clerk', '1992.2.1'),
(9031 ,'p3', 'Clerk', '1997.11.15'),
(29346 ,'p1', 'Clerk', '1998.1.4')

--Question 1
select * from Works_on
--Question 2
select emp_no as 'Employee No' from Works_on where Job='Clerk' 
--Question 3
select emp_no as 'Employee No' from Works_on where project_no='p2' and emp_no < 10000 
--Question 4
select emp_no as 'Employee No' from Works_on 
--Question 5
select emp_no as 'Employee No' from Works_on where project_no='p1' and( Job='Analyst' or Job='Manager') 
--Question 6
select enter_date as 'Employee No' from Works_on  where project_no='p2' and Job is null
--Question 7
select emp_no , emp_lname from Employee where emp_fname like '%tt%'
--Question 8
select emp_no , emp_fname from Employee where (emp_lname like '_o%' or emp_lname like '_a%') and emp_lname like '%es'
--Question 9
select e.emp_no from Employee e join Department d on d.Dept_no=e.dept_no where d.location='Seattle'
--Question 10
select e.emp_fname, e.emp_lname from Employee e join Works_on w on 
e.emp_no=w.emp_no where w.enter_date = '04.01.1998'
--Question 11
Select * from Department group by location
--Question 12
select Max(emp_no) from Works_on 
--Question 13
select Job from Works_on where (Select Count(Job) from Works_on)>2
--Question 14
select emp_no from Employee where dept_no = 'd3' OR emp_no IN (select emp_no FROM Works_on WHERE Job = 'Clerk');