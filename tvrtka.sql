use master;
go
drop database if exists tvrtka;
go
create database tvrtka;
go
use tvrtka;

create table zaposlenici (
id int not null primary key identity  (1,1),
ime varchar (50),
prezime varchar (50),
dob datetime ,
placa decimal (10,2),
invalid bit
);

create table slike (
id int not null primary key identity  (1,1),
zaposlenik  int not null  foreign key  references zaposlenici(id),
rednibroj int ,
putanja varchar(100) 
);

insert into zaposlenici (ime, prezime, dob, placa, invalid) values
('ivan','štivic','1980-11-20', 1700.55, 0),
('jovan','mivic','1973-01-21', 1222.55, 0);

select * from zaposlenici


insert into slike (zaposlenik,rednibroj,putanja) values
(1,1,'c:/nekipath'),
(1,2,'c:/nekipath'),
(2,1,'c:/nekipath'),
(2,2,'c:/nekipath'),
(3,1,'c:/nekipath'),
(3,2,'c:/nekipath')

select * from slike 