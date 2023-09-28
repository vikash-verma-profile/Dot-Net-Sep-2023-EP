select * from Employee

create table student(id int identity(1,1),FirstName varchar(200) NOT NULL,LastName varchar(200),
ClassName int,CreatedOn datetime DEFAULT GETDATE(),PRIMARY KEY(id)) 

drop table ClassMaster

create table ClassMaster(id int identity(1,1),ClassName varchar(2000),CreatedOn datetime DEFAULT GETDATE(),PRIMARY KEY(id)) 

select GETDATE()

select * from student

insert into student(FirstName,LastName,ClassName) values('Vikash','Verma',1)

insert into student(FirstName,LastName,ClassName) values('Vikash','Verma 1',2);

insert into student(FirstName,LastName,ClassName) values('Vikash','Verma 2',3);
select CONCAT(FirstName,' ',LastName) FullName from student;

select dbo.GetFullName(id) as FullName from student
select dbo.GetFullName(1) as FullName

-- function creation syntax
create function GetFullName(@ID INT)
returns varchar(2000)
as
BEGIN 
return (select CONCAT(FirstName,' ',LastName) FullName from student where id=@ID)
END

select  * from ClassMaster CM inner join student s on CM.id=s.ClassName;

insert into ClassMaster(ClassName)  values ('X'),('XII'),('IX')


Create View GetData as 

select  s.id,dbo.GETFullName(s.id) as FullName,s.ClassName,s.CreatedOn 
from ClassMaster CM inner join student s on CM.id=s.ClassName;


select  * from GetData;

alter proc InsertData(@FirstName varchar(200),@LastName varchar(200),@ClassName varchar(200))
as
BEGIN

if((select count(*) from ClassMaster where ClassName= @ClassName)>0)
BEGIN

insert into student(FirstName,LastName,ClassName) values(@FirstName,@LastName,(select id from ClassMaster where ClassName= @ClassName));
END
ELSE 
BEGIN

insert into ClassMaster(ClassName) values(@ClassName);
insert into student(FirstName,LastName,ClassName) values(@FirstName,@LastName,@@IDENTITY);
END

END;



end

exec InsertData 'Rakesh','Kumar','XI'

select  * from student;
select * from ClassMaster

select count(*) from ClassMaster where ClassName= 'XI'