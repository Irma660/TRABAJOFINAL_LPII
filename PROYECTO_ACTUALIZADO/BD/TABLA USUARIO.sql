use BDSISTR
CREATE TABLE usuario (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    USUARIO VARCHAR(50) NOT NULL,
    CONTRASEŅA VARCHAR(8) NOT NULL);

INSERT INTO usuario (USUARIO, CONTRASEŅA)
VALUES ('usuario1', '12345678')