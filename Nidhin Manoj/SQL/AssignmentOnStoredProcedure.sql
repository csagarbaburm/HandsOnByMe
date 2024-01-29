--create following procedure wrt employee table
--a. add new employee
--b. get all employees
--c. get all employees by dept
--d. edit employee details
--e. delete employee by id.



---a. add new employee
create procedure add_Employee(@id int,@name varchar(30),@joindate date,@salary int,@deptcode char(5))
as
begin
if(exists (select *  from Employee where Id= @id))
begin
print 'already exists employe Id'
end
else
begin
insert into Employee values (@id,@name,@joindate,@salary,@deptcode) 
end
end

exec add_Employee 1,'Nidhin','2022.11.23',30000,'D0002'
exec add_Employee 4,'Nevin','2020.10.12',30000,'D0001'

---b. get all employees
create procedure get_employees
as
begin
select * from Employee  
end
exec get_employees
---c. get all employees by dept
create procedure get_employeesbydept(@deptcode char(5))
as
begin
(select * from Employee where Dept_Code =@deptcode)
end
exec get_employeesbydept 'D0002'
exec get_employeesbydept 'D0001'

---d. edit employee details

create procedure edit_employeedetails(@id int,@name varchar(30),@joindate date,@salary int,@deptcode char(5))
as
begin
if(exists(select * from Employee where Id =id))
begin
update Employee set Name=@name,JoinDate=@joindate,salary=@salary,Dept_Code=@deptcode where Id=@id
end
end
exec edit_employeedetails 1,'Bince','2023.2.14',4000,'D0002'
select * from Employee

---e. delete employee by id.

create procedure delete_employeebyid(@id int)
as
begin
if(exists(select * from Employee where Id=@id))
begin
delete from Employee where Id=@id
end
end
exec delete_employeebyid 1
select * from Employee





