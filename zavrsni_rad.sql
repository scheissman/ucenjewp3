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
vodostaj int,
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



insert into korisnici (ime,prezime,email) values
('Slaven','Poznić','slaven.poznic@hotmail.com'),
('Karla','Kraljik','kraljikkarla@gmail.com'),
('Dino','Sabljić','dino.sabljic@gmail.com'),
('Luka','Crljić','lukacrljic7@gmail.com'),
('Mario','Baliban','mariobalibanos@gmail.com'),
('Branimir','Fekete','branimir.fekete@gmail.com'),
('Dajana','Tolić','dajanabozic@gmail.com'),
('Ivan','Tolić','ivan.tolic1989@gmail.com'),
('Tomislav','Kučić','tomislavkucic@gmail.com'),
('Zdenko','Barić','zbaric_hr@yahoo.com'),
('Mihael','Žulj','mihaelzulj@gmail.com'),
('Ivan','Marošević','ivanmarosevic4@gmail.com'),
('Goran','Kovačić','kovacic.go@gmail.com'),
('Nataša','Jakopec','njakopec@gmail.com'),
('Goran','Franjić','goran@proces.hr'),
('Ana','Jurić','ana.juric19@gmail.com'),
('Emina','Vejsilović','emiomiemi@gmail.com'),
('Josip','Rebolj','rebolj.josip031@gmail.com'),
('Merlin','Jišše','jisse.merlin@gmail.com'),
('Snežana','Grković','snezana4688@yahoo.com'),
('Rade','Jasenovčanin','rade.jasenovcanin@yahoo.com'),
('Krešimir','Bilokapić','ilead7@gmail.com'),
('Srđan','Filipović','srdjanfilipovic991@gmail.com'),
('Veljko','Vujić','veljko2805vujic@gmail.com');


INSERT  INTO unos  (korisnici_id,datum,vodostaj, biljeska) values
(1,'2023-11-10', 100, 'danas sam upecao ajkulu'),
(2,'2023-11-10', 111, 'kada sam izvadio soma, klecnio je brod kod apatina'),
(3,'2023-11-10', 21, 'upecao soma mužjaka od 30 kila, dosla poslije zenka , muzjak izgledao neuhranjeno kraj nje'),
(7,'2023-11-10', -33, 'danas nisam nista upecao , los dan na vodi '),
(7,'2023-11-11', 0, 'pecao bjelu na feeder i pokido , uzimalo anis i vaniliju'),
(8,'2023-11-10', -10, 'zahaklo tolstolobika od 10 kila'),
(9,'2023-11-10', 30, 'najbolji dan ikad, pokido smudjeve'),
(10,'2023-11-10', 300, 'tlak zraka 1013,25 hektopaskala, bucov uzimao samo povrsince, temp vode 20C');

insert into ribe (vrsta) values 
('deverika'),
('kečiga'),
('patuljasti somic'),
('jegulja'),
('bolen'),
('crnooka deverika'),
('mrena'),
('krupatica'),
('zlatni karas'),
('karas'),
('babuška'),
('podust'),
('bijeli amur'),
('šaran'),
('štuka'),
('krkuša'),
('balavac'),
('mladica'),
('bijeli tolstolobik'),
('sivi tolstolobik'),
('sunčanica'),
('jez'),
('manjić'),
('pastrvski grgeč'),
('crni amur'),
('grgeč'),
('paklara'),
('gavičica'),
('bodorka'),
('plotica'),
('potočna pastrva'),
('mekousna pastrva'),
('smuđ'),
('smuđ kamenjar'),
('crvenperka'),
('som'),
('klen'),
('lipljen'),
('linjak'),
('vretenac');



INSERT INTO ulov (ribe_id,unos_id, tezina, duzina, kolicina) values

(16,1,null, null, 1),
(36,2 ,'40kg', '2metra šestdeset 7 cantima', 1),
(36,3,'15kg', '150cm', 1),
(36,3,'22kg', '180', 1),
(30,5,'12kg', null, 57),
(19,6,'10kg', null, 1),
(33,7,'27kila', null, 5),
(5,8,null, null, 11);


select a.ime , b.id , b.biljeska ,c.kolicina, d.vrsta 
from korisnici a 
inner join unos b on a.id = b.korisnici_id 
inner join ulov c on b.id = c.unos_id 
inner join ribe d on c.ribe_id = d.id;






