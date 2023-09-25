select * from Employee

create table student(id int identity(1,1),FirstName varchar(200) NOT NULL,LastName varchar(200),
ClassName int,CreatedOn datetime DEFAULT GETDATE(),PRIMARY KEY(id)) 

select GETDATE()

select * from student

insert into student(FirstName,LastName,ClassName) values('Vikash','Verma',1)