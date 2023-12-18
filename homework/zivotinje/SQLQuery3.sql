use master;
go
drop database if exists zivotinje ;
go
create database zivotinje;
go
use zivotinje;

create table osobe (
id int not null  primary key identity (1,1),
ime varchar (59),
prezime varchar (59),
oib char (11)
);



create table sticenici  (
id int not null  primary key identity (1,1),
ime varchar (59),
vrsta varchar (59),
zanjegasebrine int
);

create table prostor (
    id int not null primary key identity (1,1),
    ime varchar (59),
    sticenik_id int,
);

alter table prostor add foreign key (sticenik_id) references sticenici (id);
alter table sticenici add foreign key (zanjegasebrine) references osobe (id);
