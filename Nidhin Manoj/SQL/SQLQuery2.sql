create database SqlAssignment_2;
use SqlAssignment_2;
create Table Department(
Dept_no varchar(2) primary key,
Dept_name varchar(15) not null,
[Location] varchar(15) not null
);
create table Employee(
emp_no varchar(8) primary key,
emp_fname varchar(30) not null,
emp_lname varchar(30) not null,
dept_no varchar(2) Foreign key references Department(dept_no)
);
 
create Table Project(
Project_no varchar(2) primary key,
Project_name varchar(15) not null,
Budget varchar(15) not null
);
 
create table Works_on(
emp_no varchar(8) foreign key references Employee(emp_no),
Project_no varchar(2) foreign key references Project(Project_no),
Job varchar(15) null, 
Enter_date datetime default getdate()
);

 
insert into Department values('d1','Research','Dallas'),
('d2','Accounting','Seattle'),
('d3','Marketing','Dallas')
 
 
insert into Employee values
('25348','Matthew','Smith','d3'),
('10102','Ann','Jones','d3'),
('18316 ','John','Barrimore','d1'),
('29346 ','James','James','d2')

insert into Project values('P1','Appolo','120000'),
('P2','Gemini','95000'),
('P3','Mercury','185600')
select * from Employee
 
insert into Works_on values ('10102','p1','Analyst','1997.10.1'),
('10102','p3','manager','1999.1.1'),
('25348' ,'p2' ,'Clerk' ,'1998.2.15'),
('18316','p2' ,NULL,'1998.6.1'),
('29346' ,'p2' ,NULL ,'1997.12.15'),
('2581','p3','Analyst', '1998.10.15'),
('9031' ,'p1' ,'Manager' ,'1998.4.15'),
('28559','p1', NULL, '1998.8.1'),
('28559' ,'p2' ,'Clerk' ,'1992.2.1'),
('9031', 'p3', 'Clerk','1997.11.15'),
('2934' ,'p1' ,'Clerk' ,'1998.1.4')
 
 
--Question1
 
select * from Works_on
 
--Question2
 
select emp_no from Works_on where job='Clerk'
 
--Question3
 
select emp_no from Works_on where Project_no='p2' and emp_no<10000
--no result for the query
 
--Question4
 
select emp_no from Works_on where year(Enter_date)not in(1998)
 
--Question5
select emp_no from Works_on where job in('Analyst','Manager') and Project_no='P1'
 
--Question6
select Enter_date from Works_on where Project_no='P2' and job is null
 
--Question7
 
select emp_no,emp_lname from Employee where emp_fname like ('%t%t%')
 
--Question8
 
select emp_no,emp_fname from Employee where emp_lname like ('_[oa]%es')
 
--Question9
select emp_no from Employee where dept_no=(select dept_no from Department where location='Seattle')
 
--Question10
 
select emp_fname,emp_lname from Employee where emp_no in(select emp_no from Works_on where Enter_date='04.01.1998' )
 
--Question11
 
select location,Dept_name from Department group by location, dept_name
 
--Question12
 
select * from Employee where emp_no=(select max(emp_no) from Employee)
 
--Question13
 
select  Job as 'Jobs with more than 2' from Works_on group by job having count(emp_no)>2
 
--Question14
 
select * from Works_on
select * from Employee
select Employee.emp_no from Employee right join Works_on on Employee.emp_no=Works_on.emp_no where Employee.dept_no='d3' or Works_on.Job='Clerk'
