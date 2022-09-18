create database QL_HS

go
use QL_HS
go

create table Account(
	UserName varchar(255),
	PassWord varchar(255),
	Type int default(0),
)
--insert into Account(UserName,PassWord,Type)
--values('admin','123','0')

create table Class(
	ClassId varchar(10) primary key,
	ClassName nvarchar(255),
)

create table Student(
	Mssv varchar(10) primary key,
	LastName nvarchar(255),
	FirstName nvarchar(255),
	ClassId varchar(10),
	DateOfBirth varchar(255),
	YearOfIntake varchar(255),
	ModeOfTraining varchar(255),
	FOREIGN KEY (ClassId) REFERENCES Class(ClassId)
)
--insert into Student(Mssv,LastName,FirstName,ClassId,DateOfBirth,YearOfIntake,ModeOfTraining)
--values ('5180088','Nguyen','Tung','518H50306','08/08/2000','2018','clc')

select * from Student
select * from Class

create table InStudent(
	Mssv varchar(10),
	PlaceOfBirth nvarchar(255) default(null),
	TownOfOrigin nvarchar(255)default(null),
	Gender nvarchar(255)default(null),
	Nationality nvarchar(255)default(null),
	ProvinceOrCity nvarchar(255),
	Dicstrict nvarchar(255),
	WardOrTown nvarchar(255),
	Street nvarchar(255),
	Addressnumber nvarchar(255),
	StudentPhone nvarchar(255),
	IdCardNumber nvarchar(255),
	DateIdCard nvarchar(255),
	PlaceIdCard nvarchar(255),
	FOREIGN KEY (Mssv) REFERENCES Student(Mssv)
)

insert into InStudent(mssv, placeOfBirth, townOfOrigin,gender, nationality, 
                    provinceOrCity, dicstrict,wardOrTown, street, addressNumber, studentPhone,idCardNumber, dateIdCard, placeIdCard)
values('51800648',null,'null','null','null','null','null','null','null','null','null','null','null','null')

select c.* from Student as s ,Class as c 
where c.ClassId=s.ClassId and s.Mssv ='51800649'