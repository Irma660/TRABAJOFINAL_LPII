USE BDSISTR

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	dni varchar (8) NOT NULL,
    password VARCHAR(8) NOT NULL,
    email VARCHAR(100) NOT NULL,
	cargo varchar(30) not null,
);

CREATE TABLE Estudiante (
    ID INT PRIMARY KEY IDENTITY(1,1),
    primernombre VARCHAR(50) NOT NULL,
	segundonombre VARCHAR(50) NOT NULL,
	primerapellido varchar (50) NOT NULL,
    segundoapellido VARCHAR(50) NOT NULL,
	nivel Varchar (20) NOT NULL,
	GRADO VARCHAR (2) NOT NULL,
	SECCION VARCHAR (3) NOT NULL,
	SEXO VARCHAR (15) NOT NULL,
	dni VARCHAR(8) NOT NULL,
    telefono varchar(9) NOT NULL,
	dirección varchar(60) NOT NULL,
	fechaDnac date NOT NULL,
	observaciones varchar(100) NOT NULL,
);
