Create database MyDB;
use MYDB;

-- DDL
Create table Employee(ID int identity(1,1),EmployeeName varchar(200));
-- DQL
select * from Employee;

--DML
insert into Employee(ID,EmployeeName) values(1,'Ravi kumar 1'); 
insert into Employee(ID,EmployeeName) values(2,'Ravi kumar 2'); 

update Employee set EmployeeName='Vikash Verma 1' where ID=1

insert into Employee(EmployeeName) values('Ravi kumar 1'); 

insert into Employee(EmployeeName) values('Ravi kumar 2'); 

insert into Employee(EmployeeName) values('Ravi kumar 3'); 
delete  from Employee where ID=2

truncate table Employee

drop table Employee

--in like not in between or and 

select * from Employee where id in (1,2,3)


select * from Employee where id not in (1)


select * from Employee where EmployeeName like '%kumar%'

Create table department(id int identity(1,1),DepartmentName varchar(2000) );

insert into department values('IT')

insert into department values('Admin');
insert into department values('Support');
insert into department values('HR');
insert into department values('Finance');

select * from department
select * from Employee
alter table Employee add deptID int ;

insert into Employee(EmployeeName,deptID) values('Ravi kumar 4',6);
select emp.ID,emp.EmployeeName,dep.DepartmentName from Employee emp inner join department dep on emp.deptID=dep.id;

select emp.ID,emp.EmployeeName,dep.DepartmentName from Employee emp left join department dep on emp.deptID=dep.id

select emp.ID,emp.EmployeeName,dep.DepartmentName from Employee emp right join department dep on emp.deptID=dep.id