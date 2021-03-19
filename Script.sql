create database Proyecto
use Proyecto

create table Productos(
idProducto int,
nombreProducto varchar,
codigoProducto varchar,
precioProducto float,
Descripcion varchar(255),
constraint pk_Productos primary key (idProducto),
constraint ck_codigoProducto check(codigoProducto like '[P][R][D][0-9][0-9][0-9]')
)

create table Detalle_pedido(
idDetalle int,
idProducto int,
cantidadProducto int,
precioDetalle float,
constraint pk_Detalle_pedidio primary key (idDetalle),
constraint fk_Productos foreign key (idProducto) references Productos(idProducto)
)

create table Pedido(
idPedido int,
fechaPedido datetime,
estadoPedido int,
constraint pk_idPedidio primary key (idPedido),
idDetalle int,
constraint fk_TDetallePedido foreign key (idDetalle) references Detalle_pedido(idDetalle)
)

create table Tipo_usuario(
idTipoUsuario int,
TipoUsuario varchar(100)
constraint pk_Tipo_usuario primary key (idTipoUsuario)
)

create table Usuarios(
idUsuario int,
nombre varchar,
apellido varchar,
fechaNacimiento date ,
usuario varchar, 
contrasena varchar,
email varchar(100),
Telefono varchar(20),
idTipoUsuario int,
constraint pk_Idusuario primary key (idUsuario),
constraint fk_TipoUsuario foreign key (idTipoUsuario) references Tipo_usuario (idTipoUsuario)

)



