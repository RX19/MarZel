-- Crear la base de datos
CREATE DATABASE MarZel;
GO
USE MarZel;
GO
/****** Object:  Table TBL_EstadosUsuario ******/
create table TBL_EstadosUsuario(
	IdEstadoUsuario int identity(1,1) not null,
	Descripcion varchar(25) not null,
);

--PK
alter table TBL_EstadosUsuario add constraint PK_EstadosUsuario
primary key(IdEstadoUsuario);

/****** Object:  Table TBL_TiposUsuario ******/
create table TBL_TiposUsuario(
	IdTipoUsuario int identity(1,1) not null,
	Descripcion varchar(25) not null,
);

--PK
alter table TBL_TiposUsuario add constraint PK_TiposUsuario
primary key(IdTipoUsuario);

/****** Object:  Table TBL_Usuarios ******/
create table TBL_Usuarios(
	IdUsuario int identity(1,1) not null,
	Identidad varchar(13) not null,
	Nombre varchar(50) not null,
	Correo varchar(50) not null,
	Usuario varchar(50) not null,
	Contrasena varchar(50) not null,
	Celular varchar(8) not null,
	IdTipoUsuario int not null,
	IdEstadoUsuario int not null,
);

--PK
alter table TBL_Usuarios add constraint PK_Usuarios
primary key(IdUsuario);

--UQ
alter table TBL_Usuarios add constraint UQ_Usuarios_Identidad
unique(Identidad);

alter table TBL_Usuarios add constraint UQ_Usuarios_Correo
unique(Correo);

alter table TBL_Usuarios add constraint UQ_Usuarios_Usuario
unique(Usuario);

--FK
alter table TBL_Usuarios add constraint FK_Usuarios_TiposUsuario
foreign key(IdTipoUsuario) references TBL_TiposUsuario(IdTipoUsuario);

alter table TBL_Usuarios add constraint FK_Usuarios_EstadosUsuario
foreign key(IdEstadoUsuario) references TBL_EstadosUsuario(IdEstadoUsuario);

/****** Object:  Table TBL_Proveedores ******/
create table TBL_Proveedores(
	IdProveedor int identity(1,1) not null,
	Rtn varchar(14) not null,
	Nombre varchar(50) not null,
	Direccion varchar(50) null,
	Celular varchar(8) null,
	CantCompras int null,
	Importe decimal(9, 2) null
); 

--PK
alter table TBL_Proveedores add constraint PK_Proveedores
primary key(IdProveedor);

--UQ
alter table TBL_Proveedores add constraint UQ_Proveedores_Rtn
unique(Rtn);

/****** Object:  Table TBL_Compras ******/
create table TBL_Compras(
	IdCompra int identity(1,1) not null,
	IdProveedor int not null,
	Fecha date not null,
	Factura varchar(25) not null,
	Subtotal decimal(9, 2) not null,
	Gravado decimal(9, 2) not null,
	ISV decimal(9, 2) not null,
	Exento decimal(9, 2) not null,
	Total decimal(9, 2) not null
);

--PK
alter table TBL_Compras add constraint PK_Compras
primary key(IdCompra);

--UQ
alter table TBL_Compras add constraint UQ_Compras_Factura
unique(Factura);

--FK
alter table TBL_Compras add constraint FK_Compras_Proveedores
foreign key(IdProveedor) references TBL_Proveedores(IdProveedor);

/****** Object:  Table TBL_CategoriasProducto ******/
create table TBL_CategoriasProducto(
	IdCategoria int identity(1,1) not null,
	Descripcion varchar(25) not null
);

--PK
alter table TBL_CategoriasProducto add constraint PK_CategoriasProducto
primary key(IdCategoria);

/****** Object:  Table TBL_TiposISV ******/
create table TBL_TiposISV(
	IdISV int identity(1,1) not null,
	Descripcion varchar(25) not null,
);

--PK
alter table TBL_TiposISV add constraint PK_TiposISV
primary key(IdISV);

/****** Object:  Table TBL_Productos ******/
create table TBL_Productos(
	IdProducto int identity(1,1) not null,
	CodigoBarra varchar(25) not null,
	Descripcion varchar(100) not null,
	IdISV int not null,
	PrecioCompleto decimal(9, 2) null,
	PrecioUnitario decimal(9, 2) null,
	IdCategoria int not null,
	Existencia int not null,
);

--PK
alter table TBL_Productos add constraint PK_Productos
primary key(IdProducto);

--UQ
alter table TBL_Productos add constraint UQ_Productos_CodigoBarra
unique(CodigoBarra);

--FK
alter table TBL_Productos add constraint FK_Productos_TiposISV
foreign key(IdISV) references TBL_TiposISV(IdISV);

alter table TBL_Productos add constraint FK_Productos_CategoriasProducto
foreign key(IdCategoria) references TBL_CategoriasProducto(IdCategoria);

/****** Object:  Table TBL_DetallesCompra ******/
create table TBL_DetallesCompra(
	IdCompra int not null,
	IdProducto int not null,
	Cantidad int not null,
	Costo decimal(9, 2) not null,
	Descuento decimal(9, 2) not null,
	Importe decimal(9, 2) not null,
);

--PK
alter table TBL_DetallesCompra add constraint PK_DetallesCompra
primary key(IdCompra, IdProducto);

--FK
alter table TBL_DetallesCompra add constraint FK_DetallesCompra_Compras
foreign key(IdCompra) references TBL_Compras(IdCompra);

alter table TBL_DetallesCompra add constraint FK_DetallesCompra_Productos
foreign key(IdProducto) references TBL_Productos(IdProducto);

/****** Object:  Table TBL_Clientes ******/
create table TBL_Clientes(
	IdCliente int identity(1,1) not null,
	Rtn varchar(14) not null,
	Nombre varchar(50) not null,
	Direccion varchar(50) null,
	Celular varchar(8) null,
	CantCompras int null,
	Importe decimal(9, 2) null
);

--PK
alter table TBL_Clientes add constraint PK_Clientes
primary key(IdCliente);

--UQ
alter table TBL_Clientes add constraint UQ_Clientes_Rtn
unique(Rtn);

/****** Object:  Table TBL_Ventas ******/
create table TBL_Ventas(
	IdVenta int identity(1,1) not null,
	IdUsuario int not null,
	IdCliente int not null,
	Fecha date not null,
	Factura varchar(25) not null,
	Subtotal decimal(9, 2) not null,
	Gravado decimal(9, 2) not null,
	ISV decimal(9, 2) not null,
	Exento decimal(9, 2) not null,
	Total decimal(9, 2) not null,
);

--PK
alter table TBL_Ventas add constraint PK_Ventas
primary key(IdVenta);

--UQ
alter table TBL_Ventas add constraint UQ_Ventas_Factura
unique(Factura);

--FK
alter table TBL_Ventas add constraint FK_Ventas_Usuarios
foreign key(IdUsuario) references TBL_Usuarios(IdUsuario);

alter table TBL_Ventas add constraint FK_Ventas_Clientes
foreign key(IdCliente) references TBL_Clientes(IdCliente);

/****** Object:  Table TBL_DetallesVenta ******/
create table TBL_DetallesVenta(
	IdVenta int not null,
	IdProducto int not null,
	Cantidad int not null,
	Costo decimal(9, 2) not null,
	Descuento decimal(9, 2) not null,
	Importe decimal(9, 2) not null,
);

--PK
alter table TBL_DetallesVenta add constraint PK_DetallesVenta
primary key(IdVenta, IdProducto);

--FK
alter table TBL_DetallesVenta add constraint FK_DetallesVenta_Ventas
foreign key(IdVenta) references TBL_Ventas(IdVenta);

alter table TBL_DetallesVenta add constraint FK_DetallesVenta_Productos
foreign key(IdProducto) references TBL_Productos(IdProducto);

-- TBL_TIPOS_ISV
INSERT INTO TBL_TIPOSISV (DESCRIPCION)
VALUES 
('15% General'),
('18% Servicios');

-- TBL_CATEGORIAS_PRODUCTO
INSERT INTO TBL_CategoriasProducto(DESCRIPCION)
VALUES 
('Electrónica'),
('Papelería');

-- TBL_TIPOS_USUARIO
INSERT INTO TBL_TiposUsuario(DESCRIPCION)
VALUES 
('Administrador'),
('Cajero');

-- TBL_ESTADOS_USUARIO
INSERT INTO TBL_EstadosUsuario(DESCRIPCION)
VALUES 
('Activo'),
('Inactivo');

-- TBL_PROVEEDORES
INSERT INTO TBL_PROVEEDORES (RTN, NOMBRE, DIRECCION, CELULAR, CANTCOMPRAS, IMPORTE)
VALUES 
('08011990000123', 'Distribuidora Latina', 'Col. Kennedy', '99887766', 5, 12500.50),
('08011985000234', 'Proveedora Mundial', 'Centro', '88776655', 2, 5200.00);

-- TBL_PRODUCTOS (ID_ISV=1 y 2, ID_CATEGORIA=1 y 2)
INSERT INTO TBL_PRODUCTOS (CODIGOBARRA, DESCRIPCION, IDISV, PRECIOCOMPLETO, PRECIOUNITARIO, IDCATEGORIA, EXISTENCIA)
VALUES 
('1234567890123', 'Impresora Epson L3250', 1, 4500.00, 4000.00, 1, 10),
('3210987654321', 'Resma de papel A4', 2, 150.00, 130.00, 2, 100);

-- TBL_USUARIOS (ID_TIPO=1 y 2, ID_ESTADO=1)
INSERT INTO TBL_USUARIOS (IDENTIDAD, NOMBRE, CORREO, USUARIO, CONTRASENA, CELULAR, IdTipoUsuario, IdEstadoUsuario)
VALUES 
('0801199901234', 'Carlos Pérez', 'carlos@empresa.com', 'cperez', '1234', '99887755', 1, 1),
('0801199705678', 'Ana Torres', 'ana@empresa.com', 'atorres', '5678', '88776644', 2, 1);

-- TBL_CLIENTES
INSERT INTO TBL_CLIENTES (RTN, NOMBRE, DIRECCION, CELULAR, CANTCOMPRAS, IMPORTE)
VALUES 
('08011991001234', 'Javier Medina', 'Col. Miraflores', '98765432', 3, 3500.00),
('08011992004567', 'María López', 'Barrio Abajo', '91234567', 1, 1250.00);

-- TBL_COMPRAS (ID_PROVEEDOR=1 y 2)
INSERT INTO TBL_COMPRAS (IDPROVEEDOR, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL)
VALUES 
(1, '2025-07-10', 'F-0001-2025', 4000.00, 4000.00, 600.00, 0.00, 4600.00),
(2, '2025-07-11', 'F-0002-2025', 1300.00, 1300.00, 195.00, 0.00, 1495.00);

-- TBL_DETALLES_COMPRA (ID_COMPRA=1 y 2, ID_PRODUCTO=1 y 2)
INSERT INTO TBL_DETALLESCOMPRA (IDCOMPRA, IDPRODUCTO, CANTIDAD, COSTO, DESCUENTO, IMPORTE)
VALUES 
(1, 1, 1, 4000.00, 0.00, 4000.00),
(2, 2, 10, 130.00, 0.00, 1300.00);

-- TBL_VENTAS (ID_USUARIO=1 y 2, ID_CLIENTE=1 y 2)
INSERT INTO TBL_VENTAS (IDUSUARIO, IDCLIENTE, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL)
VALUES 
(1, 1, '2025-07-12', 'V-0001-2025', 4000.00, 4000.00, 600.00, 0.00, 4600.00),
(2, 2, '2025-07-13', 'V-0002-2025', 1300.00, 1300.00, 195.00, 0.00, 1495.00);

-- TBL_DETALLES_VENTA
INSERT INTO TBL_DETALLESVENTA (IDVENTA, IDPRODUCTO, CANTIDAD, COSTO, DESCUENTO, IMPORTE)
VALUES 
(1, 1, 1, 4000.00, 0.00, 4000.00),
(2, 2, 10, 130.00, 0.00, 1300.00);
