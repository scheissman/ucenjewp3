use edunovawp3;

select * from smjerovi;

-- školska sintaksa
insert into smjerovi (naziv, trajanje,cijena,vaucer)
values ('Web programiranje', 225, 1859.45,1);

-- loša sintaksa
insert into smjerovi values
('Web dizajn',null,null,null);

-- minimalna dobra sintaksa
insert into smjerovi (naziv) values ('čšćđž ČŠĆĐŽ');