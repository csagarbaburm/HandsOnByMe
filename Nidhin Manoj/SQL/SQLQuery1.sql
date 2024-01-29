 create database TrainingDB1
 use TrainingDB1
 create table Participantlist
(
participantID bigint identity (1,1) not null,
FirstName varchar(30),
LastName varchar(30),
OfficialEmail varchar(100)
)
insert into Participantlist values ('nidhin','manoj','nidhin@gmail.com')
select * from Participantlist
truncate table Participantlist
drop table Participantlist
drop database TrainingDB
drop database TrainingDB1
sp_rename 'Participantlist','participants'
select * from participants