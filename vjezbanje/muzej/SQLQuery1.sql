use master;
go
drop database if exists muzej ;
go
create database muzej;
go
use muzej;

create table izlozbe (
    id int not null primary key identity (1,1),
    ime varchar (59),
    datum datetime 
);

create table djela  (
    id int not null primary key identity (1,1),
    ime varchar (59),
    vrsta varchar (59),
);

create table kustos (
    id int not null primary key identity (1,1),
    ime varchar (59),
    prezime varchar (59),
    oib char (11)
);

create table mecena (
    id int not null primary key identity (1,1),
    ime varchar (59),
    prezime varchar (59),
    oib char (11)
);

create table izlozba_djelo (
    izlozba_id int,
    djelo_id int,
    mecena_id int,
    kustos_id int,
    datum datetime,
    primary key (izlozba_id, djelo_id),
    foreign key (izlozba_id) references izlozbe(id),
    foreign key (djelo_id) references djela(id),
    foreign key (mecena_id) references mecena(id),
    foreign key (kustos_id) references kustos(id)
);
