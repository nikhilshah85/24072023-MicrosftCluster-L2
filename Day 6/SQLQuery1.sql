create table AccountDetails
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit
)

insert into AccountDetails values(10,'Karan','Savings',7000,1)
insert into AccountDetails values(11,'Priya','Current',8000,1)
insert into AccountDetails values(12,'Riya','Savings',9000,0)
insert into AccountDetails values(13,'Jiya','Savings',10000,1)
insert into AccountDetails values(14,'Mohan','Current',11000,1)
insert into AccountDetails values(15,'Suresh','Current',12000,0)



select * from AccountDetails


