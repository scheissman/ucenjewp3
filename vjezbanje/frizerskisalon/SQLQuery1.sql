use master;
go
drop database if exists frizerskisalon ;
go
create database frizerskisalon;
go
use frizerskisalon;

create table djelatnice (
id int not null  primary key identity (1,1),
ime varchar (59),
prezime varchar (59),
oib char (11)
);



create table korisnici  (
id int not null  primary key identity (1,1),
ime varchar (59),
prezime varchar (59),
telefon char (20)
);
create table usluge (
    id int not null primary key identity (1,1),
    ime varchar (59),
    cijena decimal (10,2),
    djelatnik_id int,
    korisnik_id int
);

alter table usluge add foreign key (djelatnik_id) references djelatnice (id);
alter table usluge add foreign key (korisnik_id) references korisnici (id);
