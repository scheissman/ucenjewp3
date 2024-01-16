use master;
--go go se koristi samo u ssms-u
drop database if exists ribolovnidnevnik;
--go
create database ribolovnidnevnik collate Croatian_CI_AS;
--go
use ribolovnidnevnik;

CREATE table korisnici (
id int primary key identity (1,1),
ime varchar (59) not null,
prezime varchar (50) not null,
email varchar (100) not null 
);

create table unos (
id int primary key identity (1,1),
korisnici_id int not null,
datum datetime not null,
vodostaj varchar (50),
biljeska varchar(max)
);

CREATE table ulov(
id int primary key identity (1,1),
ribe_id int not null,
unos_id int not null,
tezina varchar (50),
duzina varchar (50),
kolicina int not null 
);

CREATE table ribe (
id int primary key identity (1,1),
vrsta varchar (50) not null
);

alter table unos add foreign key (korisnici_id) references korisnici(id);
alter table ulov add foreign key (ribe_id) references ribe(id);
alter table ulov add foreign key (unos_id) references unos(id);














