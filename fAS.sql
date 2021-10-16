create database Farmacia
use Farmacia

create table persona(
id_persona int primary key,
primer_nombre varchar (50),
segundo_nombre varchar (50),
primer_apellido varchar (50),
segundo_apellido varchar (50),
)
go

create table usuario(
id_usuario int primary key,
id_persona int,
nombre_usuario varchar (30),
passwor varchar (30),
tipo varchar (30),
estado_usuario varchar (30),
)
go

create table factura(
id_factura int primary key,
id_usuario int,
cod_factura int,
fecha_venta datetime,
subtotal decimal(16,2),
iva decimal(16,2),
total_factura decimal(16,2),
)
go

create table devolucionventa(
id_devolucionventa int primary key,
id_factura int,
id_usuario int,
fecha_devolucionventa date,
cometario_devolucionventa nvarchar(200),
)
go


create table detalle_factura(
id_detalle_factura int primary key,
id_factura int,
id_medicamentos int,
precio_unit  decimal(16,2),
cantidad decimal(16,2),
subtotal decimal(16,2),
total_venta decimal(16,2),

)
go


create table medicamento(
id_medicamento int primary key,
id_farmacologico int,
id_presentacion int,
id_proveedor int,
nombre_medicamento varchar(50),
existencia_medicamento varchar(50),
cantidad_minima varchar(50),
fecha_de_vencimiento date,
precio_venta decimal(16,2),
)
go

create table presentacion(
id_presentacion int primary key,
descricion_presentacion_ nvarchar(60),
)
go

create table farmacologico(
id_farmacologico int primary key,
descricion_farmacologico nvarchar(60),
)
go

create table proveedor(
id_proveedor int primary key,
nombre_proveedor nvarchar(70),
direccion nvarchar(200),
telefono nvarchar(15),
representante nvarchar(40),
)
go

create table compras(
id_compras int primary key,
id_proveedor int,
fecha_compras date,
cod_compras nvarchar(50),
observacion_compra nvarchar(50),
subtotal decimal(16,2),
descuento decimal(16,2),
total decimal(16,2),
)
go

create table devolucioncompras(
id_devolucioncompras int primary key,
id_proveedor int,
id_usuario int,
fecha_devolucioncompras date,
comentario_devolucioncompras nvarchar(80),
)
go


create table detallecompras(
id_compras int primary key,
id_medicamentos int,
cantida_agregar nvarchar(1000),
precio_compra nvarchar(1000),
fecha_vencimiento date,

)
go

create table devoluciondetallecompras(
id_devoluciondetallecompras int primary key,
id_medicamento int,
cantidad_devolucioncompra nvarchar(1000),
)
go

alter table usuario 
add constraint pk_id_persona foreign key(id_persona) references persona(id_persona) 

alter table usuario
add constraint pk_id_usuario foreign key(id_usuario) references devolucionventa(id_usuario) 

