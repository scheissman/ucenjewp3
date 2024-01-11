USE MASTER;
GO
drop database if exists ribolov;
go
CREATE  DATABASE ribolov;
GO
USE ribolov;

CREATE TABLE Korisnici (
    ID INT PRIMARY KEY,
    KorisnickoIme VARCHAR(50),
    Email VARCHAR(100),
    Password VARCHAR(250)
);

CREATE TABLE Ribe (
    ID INT PRIMARY KEY,
    NazivRibe VARCHAR(100),
    SlikaRibe VARCHAR(255),
    OpisRibe text
);

CREATE TABLE Unos (
    ID INT PRIMARY KEY,
    Korisnik_ID INT,
    Naslov VARCHAR(255),
    Tekst text,
    Datum DATETIME,
    LokacijaRibolova VARCHAR(255),
	Riba_ID INT 
	);
    
	alter table Unos add foreign key (Korisnik_ID) references Korisnici(ID);
	alter table Unos add foreign key (Riba_ID) references Ribe(ID);


