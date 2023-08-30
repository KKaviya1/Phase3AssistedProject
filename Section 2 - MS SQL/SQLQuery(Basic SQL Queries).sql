create database SchoolsDb
use SchoolsDb

create table student (
    name varchar(100) not null,
    address varchar(100) not null,
    email varchar(75) not null,
    class varchar(5) not null
)

--Using INSERT to add data
insert into student (name, class, address, email) values ('Tom', '7a', 'lenin street', 'tom@email.com')
insert into student (name, class, address, email) values ('Thomas', '10b', 'white toen', 'thomas@email.com')
insert into student (name, class, address, email) values ('Manuel', '8a', 'Ig square', 'manuelm@email.com')

-- Using SELECT to view the data
select * from student
select name from student

--Using UPDATE to update data
update student set class = '9a'
update student set name = 'Tom Clancy' where name = 'Tom'

--Using filter and sorting for displaying data
select * from student where name like 'm%'
select * from student where email = 'thomas@email.com' and class = '9a'
select * from student order by name

--Using variables in queries
declare @namevalue as varchar(100)
set @namevalue = 'Mitchell'

select * from student where name = @namevalue






