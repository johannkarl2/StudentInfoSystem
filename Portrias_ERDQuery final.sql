create database SIS1 
use sis1
create table Role(
	role_id int primary key not null,
	role varchar(50)) 
	
create table Gender(
	gender_id int primary key not null,
	Gender varchar(50))

create table Admin(
	admin_id int primary key not null identity (1,1),
	email varchar(50),
	full_name varchar(50),
	role_id int default 1 foreign key references Role(role_id),
	created_at Date default getdate())

create table Student(
	student_id int primary key not null identity (1,1),
	first_name varchar(50),
	last_name varchar(50),
	date_of_birth date,
	gender int foreign key references Gender(gender_id),
	email varchar(50),
	phone int,
	address varchar(50),
	enrollment_date date,
	status varchar(20),
	role_id int foreign key references Role(role_id))

create table Teacher(
	teacher_id int primary key not null identity (1,1),
	first_name varchar(50),
	last_name varchar(50),
	email varchar(50),
	phone int,
	hire_date date,
	department varchar(20),
	specialization varchar(20),
	status varchar(20),
	role_id int foreign key references Role(role_id))

create table Course(
	course_id int primary key not null identity (1,1),
	course_name varchar(50),
	description varchar(50),
	credits int,
	teacher_id int foreign key references Teacher(teacher_id))



create table Grade(
	grade_id int primary key not null identity (1,1),
	student_id int foreign key references Student(student_id),
	course_id int foreign key references Course(course_id),
	grade float,
	semester int,
	grade_date date)

create table User_login(
	user_id int primary key not null identity (1,1),
	username varchar(50) not null,
	password varchar(50) not null,
	role_id int foreign key references Role(role_id),
	Uniq_id int not null)
	
create table Logs(Log_ID int primary key not null identity(1,1),DateTime DateTime default getdate(),Name Varchar(50),Action varchar(100))

insert into Role(role,role_id) values ('Admin',1),('Teacher',2),('Student',3)
insert into Gender (gender_id,Gender) values (1,'Male'),(2,'Female')
	select * from Teacher
		select * from Student
		drop table student
		DBCC CHECKIDENT ('Student', RESEED, 0);

	select * from User_login
	delete from student
	delete from User_login where user_id = 1
	drop table admin
	insert into Admin(email,full_name) values ('ccs.JoseRizal@gmail.com','Jose P. Rizal'),('ccs.bonifacio@gmail.com','andres bonifacio')

	insert into Teacher(first_name,last_name,email,phone,hire_date,department,specialization,status,role_id) values ('tandang','sora','ts@gmail.com',205468461,GETDATE(),'CCS','OOP','Active',2)

	insert into Student(first_name,last_name,date_of_birth,gender,email,phone,address,enrollment_date,status,role_id) values 
	('yowan','karl','2002-10-02',1,'yowan@gmail.com',123456,'lapulapu',GETDATE(),'Active',3),('John Paul','Cantila','2007-6-17',1,'ccs.cantila@gmail.com',123456,'mingla',GETDATE(),'Active',3)

	
	insert into User_login(username,password,role_id,Uniq_id) values ('admin','123',1,1),('teacher','123',2,1),('andres','123',1,2),('student1','123',3,1)
	
		
		SELECT *
FROM User_login AS ul
INNER JOIN Admin AS a ON ul.uniq_id = a.admin_id
WHERE ul.Username = 'andres' AND ul.Password = '123' 
	
		if user_login.role_id = 1
		select * from User_login inner join admin on User_login.Uniq_id = Admin.admin_id
	where User_login.role_id = 1

	SELECT 
    u.*, 
    a.full_name AS admin_name,
    t.first_name AS teacher_name
FROM User_login u
LEFT JOIN Admin a ON u.Uniq_id = a.admin_id AND u.role_id = 1
LEFT JOIN Teacher t ON u.Uniq_id = t.teacher_id AND u.role_id = 2

		select Teacher.first_name,Teacher.last_name from User_login inner join Teacher on User_login.Uniq_id = teacher.teacher_id where User_login.role_id = 1 

	
	 Select Log_ID as ActionID,DateTime,Name,Action from logs
	 SELECT * FROM User_login Admin inner join admin on user_login.uniq_id = Admin.admin_id WHERE Username = @username AND Password = @password
		

		