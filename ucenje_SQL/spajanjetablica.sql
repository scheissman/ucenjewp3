
-- baza edunovawp3

select * from smjerovi where sifra=1;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on b.smjer = a.sifra;

-- alternative
select smjerovi.naziv as smjer, grupe.naziv as grupa
from smjerovi inner join grupe
on grupe.smjer = smjerovi.sifra;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a, grupe b
where a.sifra=b.smjer;

-- ispisati naziv grupe te ime i prezime voditelja
select a.naziv, concat(b.prezime, ' ', b.ime) as predavac
from grupe a inner join predavaci b
on a.predavac=b.sifra;

select * from grupe;

select a.naziv as smjer,
b.naziv as grupa,
concat(c.ime, ' ', c.prezime) as predavac,
concat(e.ime,' ',e.prezime) as polaznik
from smjerovi a 
inner join grupe b on a.sifra=b.smjer
inner join predavaci c on b.predavac=c.sifra
inner join clanovi d on d.grupa=b.sifra
inner join polaznici e on d.polaznik=e.sifra;

-- recite da Šaki vodi WP2

select * from predavaci;
select * from grupe where predavac=2;

update grupe set predavac=2 where sifra=2;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra=b.smjer
order by 2 ;

-- baza knjiznica

use knjiznica;
-- Koje je sve knjige objavio August Šenoa
select a.naslov
from katalog a inner join autor b
on a.autor=b.sifra
where b.ime='August' and b.prezime='Šenoa';

-- DZ:
-- Izlistajte sve naslove knjiga
-- koje su izdane u Osijeku

-- Koliko izdavača su Društva s ograničenom odgovornošću?
select  naziv from izdavac
where naziv like '%d.o.o.%'
or naziv like '%doo%'
or naziv like '%d.o.o%';

-- unesite sebe kao autora
insert into autor (sifra,ime,prezime,datumrodenja) values
(4,'Tomislav','Jakopec','1980-12-07');

select top 10 * from autor;

-- koji su autori rođeni u vašoj godini rođenja?
select * from autor where
datumrodenja between '1980-01-01' and '1980-12-31';


-- Ispišite ime i prezime autora koji su 
-- izdali knjige u Zagrebu
select a.ime, a.prezime
from autor a inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv='Zagreb';

-- koji autori nisu izdali niti jednu knjigu?
select a.ime, a.prezime, b.naslov
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

-- obriši ih

delete a
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

-- svim autorima koji su 
-- objavili knjigu u mjestu koje ima slovo a
-- imenu dodajte Plemeniti. 
-- Npr ako se zvao Mirko, sada će se zvati Plemeniti Mirko
select * from autor;
select concat('Plemeniti ',a.ime), c.naziv
from autor a inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';

update a 
set a.ime=concat('Plemeniti ',a.ime)
from autor a
inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';


-- koliko ima autora u bazi
select count(*) from autor;