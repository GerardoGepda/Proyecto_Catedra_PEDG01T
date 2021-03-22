create database Proyecto


create table Productos(
idProducto int,
nombreProducto varchar,
codigoProducto varchar,
precioProducto float,
Descripcion varchar(255),
constraint pk_Productos primary key (idProducto)
)

create table Detalle_pedido(
idDetalle int,
idProducto int,
cantidadProducto int,
precioDetalle float,
idPedido int
constraint pk_Detalle_pedido primary key (idDetalle),
constraint fk_Productos foreign key (idProducto) references Productos(idProducto),
constraint fk_idPedido foreign key (idPedido) references Pedido(idPedido)
)

create table Pedido(
idPedido int,
fechaPedido datetime,
estadoPedido int,
constraint pk_idPedidio primary key (idPedido)
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



