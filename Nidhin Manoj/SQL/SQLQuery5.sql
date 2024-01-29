
create table Participants 
(FirstName varchar(30),SecondName varchar(30),Email varchar(20),Mobile varchar(20))
select * from Participants
alter table Participants add mobile varchar(1)

alter table participants drop column mobile
insert into Participants values ('James','Kanna','james@gmail.com','9989898989')
alter table Participants alter column mobile varchar(10)
alter table Participants add constraint id_pk primary key(ParticipantID)
alter table Participants drop constraint id_pk
sp_helpconstraint Participants
