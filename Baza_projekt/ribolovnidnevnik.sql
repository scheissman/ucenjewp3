USE MASTER;
GO
CREATE  DATABASE ribolovnidnevnik;
GO
USE ribolovnidnevnik;

CREATE TABLE Korisnici (
    ID INT PRIMARY KEY,
    KorisnickoIme VARCHAR(50),
    Email VARCHAR(100),
    Sifra VARCHAR(50),
    ProfilnaSlika VARCHAR(255),
    Opis VARCHAR(MAX)
);

CREATE TABLE Ribe (
    ID INT PRIMARY KEY,
    NazivRibe VARCHAR(100),
    SlikaRibe VARCHAR(255),
    OpisRibe VARCHAR(255)
);

CREATE TABLE MjestaRibolova (
    ID INT PRIMARY KEY,
    NazivMjesta VARCHAR(100)
);

CREATE TABLE Objave (
    ID INT PRIMARY KEY,
    Korisnik_ID INT FOREIGN KEY REFERENCES Korisnici(ID),
    Naslov VARCHAR(255),
    Tekst VARCHAR(MAX),
    Datum DATETIME,
    LokacijaRibolova VARCHAR(100)
	
	);
    
alter table Ribe add foreign key (ID) references Ribe(ID);
alter table Mjesta add foreign key (ID) references MjestaRibolova(ID);