create database VentasxRegion
go

use VentasxRegion

go
create table ComisionxVentas
(
	Tipo_id char(3) NOT NULL,
	id char(20) NOT NULL,
	nombre char(40) NOT NULL,
	jefe char(30) NOT NULL,
	provincia char(10) NULL,
	cuotaventas money NOT NULL,
	bonificacion money NOT NULL,
	porccomision smallmoney NOT NULL,
	ventasanuales money NOT NULL,
	ventasanioant money NOT NULL,
	promediomensual money NOT NULL,
	comision money NOT NULL,
	CONSTRAINT PK_Ventas_id
	PRIMARY KEY CLUSTERED ( id ASC )
) ON [PRIMARY]insert into ComisionxVentas values ('515','1323654','MartinGomez','BryanAlvarado','Cartago',6,2000,1234,40,54,4.2,0)insert into ComisionxVentas values ('506','5463234','JorgeMasvidal','BryanAlvarado','Cartago',50,3000,2343,48,48,4,0)insert into ComisionxVentas values ('123','1285432','ConnorMcDonald','BryanAlvarado','Cartago',45,3000,6454,51,52,4.3,0)insert into ComisionxVentas values ('421','7895735','EnguayeBabitus','BryanAlvarado','Cartago',13,2500,1232,60,73,5.5,0)insert into ComisionxVentas values ('546','7853054','DivomirTelasin','BryanAlvarado','Cartago',50,2000,1212,35,34,2.8,0)truncate table ComisionxVentasselect * from ComisionxVentas