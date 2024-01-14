select * from smjerovi;

-- filtriranje kolona ide između select i from
-- * označava sve kolone
-- naziv kolone - pojedine kolone
select naziv, naziv from smjerovi;

select naziv, cijena, * from smjerovi;

-- koloni se može promijeniti naziv
select naziv as smjer_naziv, cijena from smjerovi;

-- konstanta - uvijek ista vrijendost

select naziv, cijena, 'Osijek' as mjesto, 2 as broj from smjerovi;

-- izraz - funkcija
select naziv, len(naziv) as znakova from smjerovi;

-- najjednostavniji select
select getdate();

-- filtriranje redova
-- operatori uspoređivanja
-- =
select ime, prezime from polaznici
where prezime='Tolić';

-- uspoređivanja < > <= >=
select * from polaznici where sifra<12;

-- ostali operatori
-- like -> % označava bilo koji znak(ove)
-- Svi polaznici koji u svom imenu imaju slovo a
select * from polaznici
where ime like '%a%';

-- between
select * from polaznici
where sifra between 2 and 5;

-- in
select * from polaznici
where sifra in (2,7,9);

-- logički operatori
-- and (logički i)
select * from polaznici
where ime like '%a%' and sifra>10;

-- not (logičko ne)
select * from polaznici
where ime not like '%a%';

-- primjeri like
-- svi polaznici čije ime počinje slovom T
select * from polaznici
where ime like 'm%';

-- polaznice - s najmanjom reškom ime završava na a
select * from polaznici
where ime like '%a';

-- or (logičko ili)
select * from polaznici
where ime like 'm%' or ime like 'l%';

-- slaganje rezultata
-- order by
-- po prezimenu uzlazno (A->Ž)
select * from polaznici
where ime like 'm%' or ime like 'l%'
order by prezime; --asc se i ne mora pisati

-- po prezimenu silazno (Ž->A)
select * from polaznici
where ime like 'm%' or ime like 'l%'
order by prezime desc;

-- limitiranje podataka
select top 10 * from polaznici;

-- kreiranje nove tablice na osnovu select podataka
select top 10 * 
into odabrani from polaznici;

select * from odabrani;

drop table odabrani;

-- Baza knjižnica
use knjiznica;

-- Marka je ostavila cura. On sada pati!
-- Dolazi u knjižnicu kod Vas i pita što mu
-- preporučujete da čita

select * from katalog 
where naslov like '%ljubav%'
and sifra not in (2784,2938,3063,2541);

-- Koja mjesta su pobjednici u igri kaladont?
select * from mjesto
where naziv like '%nt';

-- koliko ima mjesta
select count(*) from mjesto;