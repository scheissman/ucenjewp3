CREATE TABLE Svecenik (
    ID_Svecenik INT PRIMARY KEY,
    Ime VARCHAR(50),
    Prezime VARCHAR(50),
    NadredjeniSvecenikID INT,
    FOREIGN KEY (NadredjeniSvecenikID) REFERENCES Svecenik(ID_Svecenik)
);

CREATE TABLE Posao (
    ID_Posao INT PRIMARY KEY,
    NazivPosla VARCHAR(100)

);

CREATE TABLE Svecenik_Posao (
    ID_Svecenik INT,
    ID_Posao INT,
    PRIMARY KEY (ID_Svecenik, ID_Posao),
    FOREIGN KEY (ID_Svecenik) REFERENCES Svecenik(ID_Svecenik),
    FOREIGN KEY (ID_Posao) REFERENCES Posao(ID_Posao)
);

