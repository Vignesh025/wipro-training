create table customers
(
cid int primary key,
cname varchar(40),
cmobno char(10)
)

insert into customers values(1,'ABC','123456')
insert into customers values(2,'DEF','332443')
insert into customers values(3,'XYZ','5356644')

create table products
(
pcode int primary key,
pname varchar(20),
price money
)

insert into products values(10,'pen',20)
insert into products values(20,'Scale',10)
insert into products values(30,'Laptop',40000)

create table orders
(
oid int primary key,
qty int,
Cid int foreign key references customers(cid),
Pcode int foreign key references products(pcode)
)

insert into orders values(101, 20, 2, 20)

Select * from customers
Select * from products
Select * from orders