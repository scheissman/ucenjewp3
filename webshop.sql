use master;
go
drop database if exists webshop;
go
create database webshop;
go
use webshop;

create table proizvodi (
sifra int not null primary key identity  (1,1),
naziv varchar (100),
datumnabave datetime ,
cijena decimal (18,2),
aktivan bit
);

create table stavke (
proizvod int not null ,
racun int not null ,
kolicina decimal (18,2),
cijena decimal (10,2),
);
create table kupci (
sifra int not null primary key identity  (1,1),
ime varchar (50),
prezime varchar (50),
ulica varchar (100),
mjesto varchar (100)
);

create table racuni (
sifra int not null primary key identity  (1,1),
datum datetime ,
kupac int not null ,
status bit
);

alter table racuni add foreign key (kupac) references kupci(sifra);
alter table stavke add foreign key (proizvod) references proizvodi(sifra);
alter table stavke add foreign key (racun) references racuni(sifra);


