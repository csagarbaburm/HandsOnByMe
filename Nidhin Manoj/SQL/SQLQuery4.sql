select * from employee
insert into employee values(1,'Edwin','11.2.2023',34000,null)
insert into dept(dept_code,dept_name)values('D0001','IT'),('D0002','Admin')
select * from dept
insert into employee (id,[name],dept_code)values (2,'jerin','D0004')
select * from employee

update employee set Salary=50000 where id=2
update employee set Salary=50302,Dept_Code='D0001' where id=1
update employee set Salary=Salary+10000 where Dept_Code='D0001'
select * from employee

delete from employee 
delete from employee where dept_code='D0001'
delete from employee where id=2