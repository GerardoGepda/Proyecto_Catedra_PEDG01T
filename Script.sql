create database Proyecto
use Proyecto

create table Productos(
idProducto int identity(1,1),
nombreProducto varchar(25),
codigoProducto varchar(5),
precioProducto float,
Descripcion varchar(255),
imgProducto image,
constraint pk_Productos primary key (idProducto)
)

create table Pedido(
idPedido int identity(1,1),
idUsuario int,
fechaPedido datetime,
estadoPedido int,
totalPedido float,
constraint pk_idPedidio primary key (idPedido)
)

ALTER TABLE Pedido
ADD CONSTRAINT DF_Fecha 
DEFAULT getdate() for fechaPedido

create table Detalle_pedido(
idDetalle int identity(1,1),
idProducto int,
cantidadProducto int,
precioDetalle float,
idPedido int
constraint pk_Detalle_pedido primary key (idDetalle),
constraint fk_Productos foreign key (idProducto) references Productos(idProducto),
constraint fk_idPedido foreign key (idPedido) references Pedido(idPedido)
)



create table Tipo_usuario(
idTipoUsuario int identity(1,1),
TipoUsuario varchar(100)
constraint pk_Tipo_usuario primary key (idTipoUsuario)
)

create table Usuarios(
idUsuario int identity(1,1),
nombre varchar(50),
apellido varchar(50),
fechaNacimiento date ,
usuario varchar(50), 
contrasena varchar(30),
email varchar(100),
Telefono varchar(20),
idTipoUsuario int,
constraint pk_Idusuario primary key (idUsuario),
constraint fk_TipoUsuario foreign key (idTipoUsuario) references Tipo_usuario (idTipoUsuario)

)


--Insertanto tipos de usuario
INSERT INTO Tipo_usuario VALUES ('Administrador'),
('Empleado');

--Insertando usuarios de prueba
INSERT INTO Usuarios (nombre, apellido, fechaNacimiento, usuario, contrasena, email, Telefono, idTipoUsuario) 
VALUES ('Juan', 'Pérez', '2000-10-3', 'JuanP12', '123456', 'juan.perez@gmail.com', '7361839', 1),
('Pedro', 'Hernández', '2001-6-12', 'Pedro11', '123456', 'pedro.hndz@gmail.com', '7810385', 2);