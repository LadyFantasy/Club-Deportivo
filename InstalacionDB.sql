delimiter //

DROP DATABASE IF EXISTS omeguitas//

CREATE DATABASE IF NOT EXISTS omeguitas character set utf8 collate utf8_spanish2_ci//

USE omeguitas//

CREATE TABLE IF NOT EXISTS socio(
    nombre varchar(50),
    apellido varchar(50),
    direccion varchar(50),
    mail varchar(50),
    telefono varchar(20),
    dni int PRIMARY KEY,
    apto boolean
    )//

CREATE TABLE IF NOT EXISTS roles(
    RolUsu int PRIMARY KEY,
    NomRol varchar(30)
    )//


CREATE TABLE IF NOT EXISTS usuario(
    nombre varchar(50) PRIMARY KEY,
    passw varchar(50),
    activo boolean,
    rol int,
    FOREIGN KEY (rol) REFERENCES roles(RolUsu)
)//



INSERT INTO roles VALUES
    (120,'Administrador'),
    (121,'Empleado')//


INSERT INTO usuario VALUES("admin","admin",true,120)//


CREATE procedure ingresarSocio(IN nom varchar(50), IN ape varchar(50), IN dir varchar(50), IN mail varchar(50), IN tel varchar(20), IN pdni int, IN apto boolean, OUT exito boolean)
BEGIN
    declare existe int;
    set exito = false;
    set existe = (SELECT count(*) FROM socio WHERE dni LIKE pdni); 
    IF  existe < 1 THEN
        INSERT INTO socio VALUES(nom, ape, dir, mail, tel, pdni, apto);
        set exito = True;
    END IF;
END //

CREATE procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
BEGIN  
  SELECT NomRol
	FROM usuario INNER JOIN roles ON Rol = RolUsu
		WHERE nombre = Usu AND passw = Pass 
			AND Activo = 1;
END 
//