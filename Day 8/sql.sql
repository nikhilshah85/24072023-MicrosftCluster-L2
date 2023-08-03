create table productList
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)
insert into productList values(1,'Pepsi','Cold-Drink',80,1)

insert into productList values(2,'IPhone','Electronic',150000,1)

insert into productList values(3,'Fossli Q','Watch',38000,0)

select * from productList