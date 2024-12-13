/*
NOTA: Encriptamos la contraseña con una algoritmo SHA256 ya es considerado muy mala práctica guardar
contraseñas planas en la base de datos.
A los fines de facilitar el acceso a la aplicación con el objeto de probar su funcionamiento se
adjuntan los datos de logeo.
Username: prueba
Password: 123

Username: fabi
Password: 12345
*/


Drop DATABASE if EXISTS proyecto_club_deportivo;

Create DATABASE proyecto_club_deportivo;
use proyecto_club_deportivo;

create table roles(
id_rol iNT AUTO_INCREMENT,
Nombre varchar(30),
constraint primary key(id_rol)
);

create table usuarios (
id int auto_increment,
nombre Varchar (45),
apellido Varchar (55),
username Varchar (30),
password Varchar (64), 
dni Varchar (8),
email Varchar (45),
telefono Varchar (15),
fk_rol int,
 Constraint pk_usuario Primary Key(id),
 constraint fk_usuario foreign key(fk_rol) references roles(id_rol)
);

create table socios (
id_socio int auto_increment,
nombre Varchar (45),
apellido Varchar (55),
dni Varchar (8),
email Varchar (45),
telefono Varchar (15),
apto_fisico tinyint,
estado tinyint,
 Constraint pk_socio Primary Key(id_socio)
 );
 
create table noSocios (
id_noSocio int auto_increment,
nombre Varchar (45),
apellido Varchar (55),
dni Varchar (8),
email Varchar (45),
telefono Varchar (15),
apto_fisico tinyint,
 Constraint pk_noSocio Primary Key(id_noSocio)
 );
 
create table actividades (
id_actividad int auto_increment,
nombre Varchar (55),
valor double,
 Constraint pk_actividad Primary Key(id_actividad)
 );
 
create table act_nosocios(
id_act int,
id_noSocio int,
dia_habilitado date,
monto_pagado double,
constraint pk_act_noSocio primary key (id_act, id_noSocio),
constraint fk_act_noSocios_A foreign key (id_act) references actividades (id_actividad),
constraint fk_act_noSocios_NS foreign key (id_noSocio) references noSocios (id_noSocio)
);

create table cuotas (
idCuota int auto_increment,
valor_cuota double,
fecha_pago date,
fecha_vencimiento date,
fecha_prox_vencimiento date,
forma_pago Varchar (20), 
cantidad_cuotas int,
estado tinyint,
fk_socio int,
 Constraint pk_cuota Primary Key(idCuota),
 constraint fk_socio_cuota foreign key(fk_socio) references socios(id_socio)
);

/* ------------------------------------------------------------------------------------------------ */

# Datos de prueba


insert into roles values
(1,'Administrador'),
(2, 'Empleado');

/*
NOTA: Encriptamos la contraseña con una algoritmo SHA256 ya es considerado muy mala práctica guardar
contraseñas planas en la base de datos.
A los fines de facilitar el acceso a la aplicación con el objeto de probar su funcionamiento se
adjuntan los datos de logeo.
Username: prueba
Password: 123

Username: fabi
Password: 12345
*/

insert into usuarios values
(1, 'Juan', 'Perez', 'prueba', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '31526785', 'juanp@gmail.com', '11526789254', 1),
(2, 'Fabiana', 'Altamirano', 'fabi', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', '37506998', 'fabial@gmail.com', '1152589163', 2);

insert into actividades values
(1, "yoga", 5500.0),
(2, "pilates", 4850.0),
(3, "tonificacion", 5500),
(4, "defensa personal", 7000.0);


INSERT INTO socios (id_socio, nombre, apellido, dni, email, telefono, apto_fisico, estado) VALUES 
(1,'Danilo','Yatra','38523664','daniloyatra@gmail.com','114998526',1,1),
(2,'Sebastian','Gonzalez','38515806','sebagonzalez@gmail.com','114990527',1,1),
(3,'Geronimo','Rulli','37885602','gero.rulli@gmail.com','114850360',1,1),
(4,'Bautista','Arce','41050223','bautista.arce@gmail.com','2214987008',1,1),
(5,'Alba','Danubio','29699822','albadanu@gmail.com','2213569993',1,1),
(6,'Homero','Jara','18228858','homerojara@gmail.com','2214778906',1,1),
(7,'Helena','Rosso','20414771','helenarosso@gmail.com','2214778550',1,1),
(8,'Prisila','Oca','34746667','prisilaoca@gmail.com','2253699858',1,1),
(9,'Lorenzo','Sastre','36652023','lorenzosas@gmail.com','116989741',1,1),
(10,'Ricardo','Duran','22599818','ricDuran@gmail.com','114225362',1,1),
(11,'Santino','Lugo','31447711','santilugo@gmail.com','112441153',1,1),
(12,'sandro','Idra','20266980','sandroidra@gmail.com','221400503',1,1),
(13,'Ivan','Sorredo','35606331','ivanso@gmail.com','221447850',1,1),
(14,'Ivana','Ramos','29332264','ivanaRamos@gmail.com','112036580',1,1),
(15,'Ramon','Corso','21005587','ramonco@gmail.com','2212400515',1,1),
(16,'Favio','Flandes','26885470','favioflan@gmail.com','113692315',1,1),
(17,'Alfredo','Tapia','32335608','alfredTapia@gmail.com','221369875',1,1),
(18,'Cielo','Flama','34789103','cielofla@gmail.com','2213569006',1,1),
(19,'Helena','Jordan','19520202','helenajor@gmail.com','110253657',1,1),
(20,'Victor','Thorton','29889523','victort@gmail.com','2214782360',1,1),
(21,'Julian','Prodan','36201487','juliprodan@gmail.com','113204726',1,1),
(22,'Vilma','Retegi','28498705','vilmarete@gmail.com','2216303324',1,1),
(23,'Sonia','Lemos','36574198','sonialemos@gma.com','2263633188',1,1),
(24,'Mariana','Esteche','40230156','marianeste@gmail.com','1123005403',1,1),
(25,'Fabiana','Nandes','38717119','fabinandes@gmail.com','116990807',1,1);

INSERT INTO noSocios (id_noSocio, nombre, apellido, dni, email, telefono, apto_fisico) VALUES
(1,'Marina','Wolf','39005853','marinawolf@gmail.com','115448527',1),
(2,'Gergina','Viola','39885141','georviola@gmail.com','113558963',1),
(3,'Amanda','Corso','37455621','amandacor@gmail.com','114774123',1),
(4,'Luna','Hoz','32565908','luna.hoz@gmail.com','2215444781',1),
(5,'Paolo','Roca','15205665','paoloroca@gmail.com','1155560632',1),
(6,'Zaira','Lemos','39711145','zairalemos@gmail.com','113665220',1),
(7,'Jose','Durant','18202514','josedurant@gmail.com','113669951',1),
(8,'Marcelo','Woss','39045899','marcewoss@gmail.com','1154120063',1),
(9,'Gabriel','Klopp','22310025','gabriel.kloss@gmail.com','112365855',1),
(10,'Fausto','Vera','38502301','favera@gmail.com','113226599',1),
(11,'Norberto','Art','22101102','roberArt@gmail.com','1123599811',1),
(12,'Silvia','Riquelme','24154447','silRiquelme@gmail.com','221422303',1),
(13,'Mia','Ordoñez','31006517','miaorde@gmail.com','2246987124',1);

INSERT INTO cuotas (idCuota, valor_cuota, fecha_pago, fecha_vencimiento, fecha_prox_vencimiento, forma_pago, cantidad_cuotas , estado , fk_socio) VALUES
(1,10000,'2024-08-04','2024-08-04','2024-09-04','Efectivo',1,1,1),
(2,10000,'2024-08-07','2024-08-10','2024-09-10','Efectivo',1,1,2),
(3,12500,'2024-08-13','2024-08-13','2024-10-04','Efectivo',1,1,3),
(4,12500,'2024-10-13','2024-10-14','2024-11-14','Efectivo',1,1,4),
(5,12500,'2024-10-13','2024-10-14','2024-11-14','Tarjeta de Crédito',6,1,5),
(6,12500,'2024-10-13','2024-10-29','2024-11-29','Efectivo',1,1,6),
(7,12500,'2024-10-13','2024-10-15','2024-10-16','Efectivo',1,1,7),
(8,12500,'2024-10-13','2024-10-14','2024-10-17','Tarjeta de Crédito',3,1,8),
(9,12500,'2024-10-10','2024-10-12','2024-10-20','Efectivo',1,1,9),
(10,12500,'2024-10-08','2024-10-09','2024-10-21','Efectivo',1,1,10),
(11,12500,'2024-10-01','2024-11-12','2024-10-18','Efectivo',1,1,11),
(12,12500, '2024-08-19','2024-09-19','2024-10-19','Efectivo',1,1,12),
(13,12500,'2024-08-21','2024-09-21','2024-10-21','Efectivo',1,1,13),
(14,12500,'2024-08-22','2024-09-22','2024-10-22','Efectivo',1,1,14),
(15,12500,'2024-10-13','2024-10-22','2024-11-22','Efectivo',1,1,14),
(16,12500,'2024-10-13','2024-11-12','2024-11-12','Efectivo',1,1,15),
(17,12500,'2024-08-23','2024-09-23','2024-10-23','Efectivo',1,1,16),
(18,12500,'2024-08-24','2024-09-24','2024-10-24','Efectivo',1,1,17),
(19,12500,'2024-08-25','2024-09-25','2024-10-25','Efectivo',1,1,18),
(20,12500,'2024-10-26','2024-10-26','2024-11-26','Tarjeta de Crédito',6,1,1),
(21,17875,'2024-10-13','2024-10-04','2024-11-12','Tarjeta de Crédito',3,1,19),
(22,12500,'2024-10-14','2024-11-13','2024-11-13','Efectivo',1,1,20),
(23,12500,'2024-10-14','2024-11-13','2024-11-13','Efectivo',1,1,21),
(24,12500,'2024-10-14','2024-11-13','2024-11-13','Efectivo',1,1,22),
(25,18791.67,'2024-10-15','2024-10-04','2024-11-14','Tarjeta de Crédito',6,1,23),
(26,12500,'2024-10-23','2024-10-23','2024-11-23','Efectivo',1,1,24),
(27,12500,'2024-10-24','2024-10-24','2024-11-24','Efectivo',1,1,25);


INSERT INTO act_nosocios (id_act, id_noSocio, dia_habilitado, monto_pagado) VALUES
(1,1,'2024-10-14',5500),
(1,5,'2024-10-11', 5500),
(2,1,'2024-10-10',4850),
(2,2,'2024-10-12',4850),
(2,4,'2024-10-10',4850),
(2,7,'2024-10-15',4850),
(2,11,'2024-10-12',4850),
(2,13,'2024-10-14',4850),
(3,10,'2024-10-15',4500),
(4,2,'2024-10-11',4000),
(4,3,'2024-10-09',4000);


/* ------------------------------------------------------------------------------------------------ */

/*
Store Procedure para el Login
*/

delimiter //  

create procedure IngresoLogin(in username varchar(20),in pass varchar(64))
begin
	select u.nombre, u.apellido, u.dni, u.username, r.nombre from usuarios u
    inner join roles r on u.fk_rol = r.id_rol
	where u.username = username and u.password = pass; 
end 
//

/*
Store Procedure para el inscribir socio
*/

DELIMITER //

 create procedure registrarSocio(in nombreSocio varchar(45),in apellidoSocio varchar(55), in dniSocio varchar(8),
 in emailSocio varchar(45), in telefonoSocio varchar(15), in aptoFisico tinyint, in estadoSocio tinyint, out respuesta int)
 begin
	 declare existe int default 0;
     set respuesta = 1;
     set existe = (select count(*) from socios where apellido = apellidoSocio and dni = dniSocio);
	  if existe = 0 then	 
		 set existe = (select count(*) from noSocios where apellido = apellidoSocio and dni = dniSocio);
		 if existe = 0 then
			insert into socios (nombre, apellido, dni, email, telefono, apto_fisico, estado) values(nombreSocio, apellidoSocio, dniSocio, emailSocio, telefonoSocio, aptoFisico, estadoSocio);
			set respuesta = (select id_socio from socios where dni = dniSocio);
         end if;   
	  else
		 set respuesta = existe;
      end if;		 
end //


/*
Store Procedure para el inscribir un No socio
*/


DELIMITER //

 create procedure registrarNoSocio(in nombreNoSocio varchar(45),in apellidoNoSocio varchar(55), in dniNoSocio varchar(8),
 in emailNoSocio varchar(45), in telefonoNoSocio varchar(15), in aptoFisico tinyint, out respuesta int)
 begin
	 declare existe int default 0;
     set respuesta = 1;
     set existe = (select count(*) from noSocios where apellido = apellidoNoSocio and dni = dniNoSocio);	 
	  if existe = 0 then	
		 set existe = (select count(*) from socios where apellido = apellidoNoSocio and dni = dniNoSocio);
         if existe = 0 then	
			 insert into noSocios (nombre, apellido, dni, email, telefono, apto_fisico) values
			 (nombreNoSocio, apellidoNoSocio, dniNoSocio, emailNoSocio, telefonoNoSocio, aptoFisico);
			 set respuesta  = (select id_noSocio from noSocios where dni = dniNoSocio);
         end if;    
	  else
		 set respuesta = existe;
      end if;		 
end //

/*
Store Procedure para obtener el id de una actividad
*/

DELIMITER //

 create procedure buscarIdActividad(in nombreActividad varchar(45), out respuesta int)
 begin
	 declare existe int default 0;
     set existe = (select count(*) from actividades where nombre = nombreActividad);
	 
	  if existe = 1 then	 
		 set respuesta  = (select id_actividad from actividades where nombre = nombreActividad);
	  else
		 set respuesta = existe;
      end if;		 
end //

/*
Store Procedure para buscar una actividad
*/

DELIMITER //

create procedure buscarActividad(in nombreActividad varchar(55))
begin
	select A.id_actividad, A.nombre, A.valor from actividades AS A
	where A.nombre = nombreActividad; 
end 
//

/*
Store Procedure para buscar un No socio
*/


DELIMITER //

 create procedure buscarNoSocio(in dniNoSocio varchar(8), out respuesta int)
 begin
	 declare existe int default 0;
     set existe = (select count(*) from noSocios where dni = dniNoSocio);
	 
	  if existe = 1 then	 
		 set respuesta  = (select id_noSocio from noSocios where dni = dniNoSocio);
	  else
		 set respuesta = existe;
      end if;		 
end //

/*
Store Procedure para el inscribir a un No socio en una Actividad
*/


DELIMITER //

 create procedure inscribirActividad(in idNoSocio int, in idActividad int, in diaHabilitado date, out respuesta int)
 begin
	 declare exito int default 0;
	 declare existe int default 0;
	 set existe = (select count(*) from act_nosocios where id_act = idActividad and id_noSocio = idNoSocio);
     if existe = 0 then
		insert into act_nosocios (id_act, id_noSocio, dia_habilitado) values (idActividad, idNoSocio, diaHabilitado);
		set exito = (select count(*) from act_nosocios where id_act = idActividad and id_noSocio = idNoSocio);
		if exito = 1 then
			set respuesta = 1;
		else
			 set respuesta = 0;
		end if;
      else
		set respuesta = 2; 
      end if;
end //


/*
Store Procedure para el pago de una actividad diaria
*/


DELIMITER //

 create procedure pagoDiario(in idNoSocio int, in idActividad int, in diaHabilitado date, in monto double, out respuesta int)
 begin
	 declare exito int;
	 declare existe int default 0;
	 set existe = (select count(*) from act_nosocios where id_act = idActividad and id_noSocio = idNoSocio);
     if existe = 1 then
		UPDATE act_nosocios set dia_habilitado = diaHabilitado, monto_pagado = monto where id_act = idActividad and id_noSocio = idNoSocio;
		set exito = (select count(*) from act_nosocios where id_act = idActividad and id_noSocio = idNoSocio and dia_habilitado = diaHabilitado);
		if exito = 1 then
			set respuesta = 1;
		else
			 set respuesta = 0;
		end if;
      else
		set respuesta = 2; 
      end if;
end //

/*
Store Procedure para listar los NoSocios habilitados para la práctica de actividades en el dia de la fecha
*/

DELIMITER //

create procedure listarNoSocios(in diaHabilitado date)
begin
	select NS.id_noSocio, NS.nombre, NS.apellido, NS.dni, A.nombre, AN.dia_habilitado 
    from noSocios AS NS 
    inner join act_nosocios AS AN on NS.id_noSocio = AN.id_noSocio
    inner join actividades AS A on AN.id_act = A.id_actividad
	where AN.dia_habilitado = diaHabilitado; 
end 
//

/*
Store Procedure para el registro y pago de una cuota
*/

DELIMITER //

 create procedure crearCuota(in valorCuota double, in fechaPago date, in fechaVencimiento date, in fechaProxVec date, in formaPago varchar(25), 
 in cantCuotas int, in estadoCuota tinyint, in idSocio int, out respuesta int)
 begin
	 declare exito int default 0;
	insert into cuotas (valor_cuota, fecha_pago, fecha_vencimiento, fecha_prox_vencimiento, forma_pago, cantidad_cuotas, estado, fk_socio) 
	values (valorCuota, fechaPago, fechaVencimiento, fechaProxVec, formaPago, cantCuotas, estadoCuota, idSocio);
	set exito = (select count(*) from cuotas where fk_socio = idSocio and fecha_vencimiento = fechaVencimiento);
	if exito = 1 then
		set respuesta = 1;
	else
		 set respuesta = 0;
	end if;
end //

/*
Store Procedure para buscar si existen cuotas para un socio, si no existen es debido a que se trata
de un nuevo socio.
*/

DELIMITER //

create procedure existeCuotaSocio(in id int,  out respuesta int)
begin
	declare existe int default 0;
	set existe = (select count(*) from cuotas C 
    inner join socios AS S on C.fk_socio = S.id_socio
    where S.id_socio = id); 
    if existe > 0 then 
		set respuesta = 1;
    elseif existe = 0 then
		set respuesta = 0;
    end if;
end 
//


/*
Store Procedure registrar el pago de una cuota en una couta vencida
*/

DELIMITER //

 create procedure modificarCuota(in idSocio int, in valorCuota double, in fechaPago date, in formaPago varchar(25), in cantCuotas int, out respuesta int)
 begin
	 declare exito int;
	 declare existe int default 0;
	 set existe = (select idCuota from cuotas where fk_socio = idSocio order by fecha_prox_vencimiento desc limit 1);
     if existe > 0 then
		UPDATE cuotas set fecha_pago = fechaPago, estado = 1, forma_pago = formaPago, cantidad_cuotas = cantCuotas, valor_cuota = valorCuota
        where idCuota = existe;
		set exito = (select count(*) from cuotas where fk_socio = idSocio and fecha_pago = fechaPago);
		if exito = 1 then
			set respuesta = 1;
		else
			 set respuesta = 0;
		end if;
      else
		set respuesta = 2; 
      end if;
end //


/*
Store Procedure que permite suspender a un socio moroso modificando su estado o readmitirlo cuando paga
*/


DELIMITER //

 create procedure modificarEstadoSocio(in dniSocio varchar(8), in estadoSocio tinyint, out respuesta int)
 begin
	 declare exito int;
	 declare existe int default 0;
	 set existe = (select count(*) from socios where dni = dniSocio);
     if existe = 1 then
		UPDATE socios set estado = estadoSocio where dni = dniSocio;
		set exito = (select count(*) from socios where dni = dniSocio and estado = estadoSocio);
		if exito = 1 then
			set respuesta = 1;
		else
			 set respuesta = 0;
		end if;
      else
		set respuesta = 2; 
      end if;
end //

/*
Store Procedure para crear un nuevo usuario del sistema
*/

DELIMITER //

 create procedure crearUsuario(in nombreUs varchar(45),in apellidoUs varchar(55), in usernameUs varchar(30), in passwordUs varchar(64), in dniUs varchar(8),
 in emailUs varchar(45), in telefonoUs varchar(15), in rolUs int, out respuesta int)
 begin
	 declare existe int default 0;
     set existe = (select count(*) from usuarios where username = usernameUs);
	 
	  if existe = 0 then	 
		 insert into usuarios 
         (nombre, apellido, username, password, dni, email, telefono, fk_rol) values(nombreUs, apellidoUs, usernameUs, passwordUs, dniUs, emailUs, telefonoUs, rolUs);
		 set respuesta  = (select id from usuarios where username = usernameUs);
	  else
		 set respuesta = 0;
      end if;		 
end //

/*
Store Procedure para modificar usuario del sistema
*/

DELIMITER //

 create procedure modificarUsuario(in nombreUs varchar(45),in apellidoUs varchar(55), in usernameUs varchar(30), in passwordUs varchar(64), in dniUs varchar(8),
 in emailUs varchar(45), in telefonoUs varchar(15), in rolUs int, out respuesta int)
 begin
	 declare existe int default 0;
     set existe = (select id from usuarios where username = usernameUs);
	 
	  if existe > 0 then	 
		 update usuarios set
         nombre = nombreUs, apellido = apellidoUs, password = passwordUs, dni = dniUs, 
         email = emailUs, telefono = telefonoUs, fk_rol = rolUs where id = existe;
		 set respuesta  = existe;
	  else
		 set respuesta = 0;
      end if;		 
end //

/*
Store Procedure para eliminar usuario del sistema
*/

DELIMITER //

 create procedure eliminarUsuario(in idUsuario int, out respuesta int)
 begin
	 declare existe int default 0;
     set existe = (select id from usuarios where id = idUsuario);
	 
	  if existe > 0 then	 
		 delete from usuarios where id = existe;
		 set respuesta  = existe;
	  else
		 set respuesta = 0;
      end if;		 
end //
