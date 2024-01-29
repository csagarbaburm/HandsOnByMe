create procedure add_student(@sid int,@sname varchar(20),@class varchar,@section char,@mobile varchar(20))
as
begin
insert into student values (@sid,@sname,@class,@section,@mobile)
end
exec add_student 4,'Nidhin','6','B','9894849890'
exec add_student @sid = 3,@sname='Nidhin',@class='G',@section= 'C' ,@mobile='8459483939'
select * from student
						
