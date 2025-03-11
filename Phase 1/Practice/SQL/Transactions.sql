create table product
(
productid int primary key,
name varchar(30),
price int,
quantity int
)

insert into product values(101,'Product1',100,10)
insert into product values(102,'Product2',200,50)
insert into product values(103,'Product3',300,30)
insert into product values(104,'Product4',450,60)

Begin transaction
	insert into product values(105,'Product5',500,20)
	update product set price =390 where productid = 102
	delete from product where productid = 102
commit transaction

select * from product


use Demo

begin transaction
insert into product values(106,'Product6',600,60)
insert into product values(106,'Product6',600,60)

if(@@Error > 0)
begin 
rollback transaction
end
else
begin
commit transaction
end


