use TrainingDB1
create clustered index pid_cluster on person(pid)
sp_helpindex person
create nonclustered index name_non_cluster on person(name)
create nonclustered index email_non_cluster on Participants(Email)
sp_helpindex Participants
create clustered index name_cluster on Participants(FirstName)

