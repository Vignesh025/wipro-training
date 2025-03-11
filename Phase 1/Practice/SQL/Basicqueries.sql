--create table student
--(
--studid int,
--studname varchar(30),
--studmarks int
--)

-- insert into student values(1,'Alex',99.00),(2,'Ben',86.00),(3,'Charlie',84.00),(4,'David',92.00)

-- Select * from student

-- Alter table student add grade varchar(2)

-- update student set grade = 'A1' where studid = 1

-- select * from student

-- update student set grade = 'A2' where studid = 2
-- update student set grade = 'A2' where studid = 3
-- update student set grade = 'A1' where studid = 4

-- select * from student

Create table customer
(
id int not null check(id between 1 and 40),
name varchar(30) not null,
BatchDateEntered Datetime not null check(BatchdateEntered >= current_timestamp(),
Emailid varchar(20) 
)