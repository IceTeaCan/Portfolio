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
) ON [PRIMARY]