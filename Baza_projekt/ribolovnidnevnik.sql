USE MASTER;
GO
drop database if exists ribolovnidnevik;
go
CREATE  DATABASE ribolovnidnevnik;
GO
USE ribolovnidnevnik;

CREATE TABLE Korisnici (
    ID INT PRIMARY KEY,
    KorisnickoIme VARCHAR(50),
    Email VARCHAR(100),
    Sifra VARCHAR(250),
    ProfilnaSlika VARCHAR(255),
    Opis text
);

CREATE TABLE Ribe (
    ID INT PRIMARY KEY,
    NazivRibe VARCHAR(100),
    SlikaRibe VARCHAR(255),
    OpisRibe text
);

CREATE TABLE MjestaRibolova (
    ID INT PRIMARY KEY,
    NazivMjesta VARCHAR(100)
);

CREATE TABLE Objave (
    ID INT PRIMARY KEY,
    Korisnik_ID INT FOREIGN KEY REFERENCES Korisnici(ID),
    Naslov VARCHAR(255),
    Tekst text,
    Datum DATETIME,
    LokacijaRibolova VARCHAR(255),
	Ribe_ID INT FOREIGN KEY REFERENCES Ribe(ID),
    Mjesta_ID INT FOREIGN KEY REFERENCES MjestaRibolova(ID)
	);
    
