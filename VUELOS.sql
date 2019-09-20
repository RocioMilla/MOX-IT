CREATE DATABASE Vuelos;

CREATE TABLE LineaAerea (
	ID int PRIMARY KEY IDENTITY NOT NULL,
    Nombre VARCHAR(50),
);

CREATE TABLE Vuelo (
	ID int PRIMARY KEY IDENTITY NOT NULL ,
    HorarioLlegada TIME,
    Demorado BIT,
	NumeroDeVuelo VARCHAR(100),
	IDLineaAerea int NOT NULL,
	FOREIGN KEY (IDLineaAerea) REFERENCES LineaAerea(ID)
);


  INSERT INTO LineaAerea VALUES (1, 'Aerolineas Argentinas');
  INSERT INTO LineaAerea VALUES (2, 'LATAM');
  INSERT INTO LineaAerea VALUES (3, 'Copa Airlines');