-- Crear la base de datos
CREATE DATABASE MarZel;
GO
USE MarZel;
GO

-- Tabla de Tipos de Usuario
CREATE TABLE TBL_Tipo_Usuario (
    ID INT PRIMARY KEY,
    Descripcion VARCHAR(100)
);

-- Tabla de Usuarios
CREATE TABLE TBL_Usuario (
    ID_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Correo VARCHAR(150),
    Usuario VARCHAR(100),
    Contrasena VARCHAR(100),
    Celular VARCHAR(20),
    ID_Tipo_Usuario INT,
    Estado bit,
    FOREIGN KEY (ID_Tipo_Usuario) REFERENCES TBL_Tipo_Usuario(ID)
);

-- Tabla de Clientes
CREATE TABLE TBL_Cliente (
    ID INT PRIMARY KEY,
    RTN VARCHAR(14),
	Nombre VARCHAR(50),
	Direccion VARCHAR(50),
	Celular VARCHAR(8),
	C_Compras  TINYINT
);

-- Tabla de Proveedores
CREATE TABLE TBL_Proveedores (
    ID INT PRIMARY KEY,
    RTN VARCHAR(14),
	Nombre VARCHAR(50),
	Direccion VARCHAR(50),
	Celular VARCHAR(8),
	C_Compras  TINYINT
);

-- Tabla de Tipos de Impuesto
CREATE TABLE TBL_Tipo_Impuesto (
    ID INT PRIMARY KEY,
    Descripcion VARCHAR(100)
);

-- Tabla de Categorías de Producto
CREATE TABLE TBL_Categoria_Producto (
    ID INT PRIMARY KEY,
    Descripcion VARCHAR(100)
);

-- Tabla de Productos
CREATE TABLE TBL_Productos (
    ID_Producto INT PRIMARY KEY,
    Codigo_Barra VARCHAR(50),
    Descripcion VARCHAR(150),
    ISV INT, -- Asumo que se refiere a un ID del tipo de impuesto
    ID_Categoria_Producto INT,
    Precio_Unitario DECIMAL(10, 2),
    Precio_Completo DECIMAL(10, 2),
    Cantidad INT,
    FOREIGN KEY (ISV) REFERENCES TBL_Tipo_Impuesto(ID),
    FOREIGN KEY (ID_Categoria_Producto) REFERENCES TBL_Categoria_Producto(ID)
);

-- Tabla de Órdenes
CREATE TABLE TBL_Orden (
    ID_Orden INT PRIMARY KEY,
    ID_cliente INT,
	ID_Proveedor INT,
	FOREIGN KEY (ID_Cliente) REFERENCES TBL_Cliente(ID),
	FOREIGN KEY (ID_Proveedor) REFERENCES TBL_Proveedores(ID),
);

-- Tabla intermedia Productos por Orden
CREATE TABLE TBL_ProductosOrden (
    ID_Orden INT,
    ID_Producto INT,
    Cantidad INT,
    Costo_Precio DECIMAL(10, 2),
    PRIMARY KEY (ID_Orden, ID_Producto),
    FOREIGN KEY (ID_Orden) REFERENCES TBL_Orden(ID_Orden),
    FOREIGN KEY (ID_Producto) REFERENCES TBL_Productos(ID_Producto)
);

-- Tabla de Factura
CREATE TABLE TBL_Factura (
    ID_Factura INT PRIMARY KEY,
    Numero_Factura VARCHAR(50),
    Fecha DATE,
    Subtotal DECIMAL(10, 2),
    Descuentos DECIMAL(10, 2),
    Importe_Gravado DECIMAL(10, 2),
    Importe_Exenta DECIMAL(10, 2),
    ISV DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    ID_Orden INT,
    FOREIGN KEY (ID_Orden) REFERENCES TBL_Orden(ID_Orden)
);

--Inserts de Panas

-- Insertar tipos de usuario
INSERT INTO TBL_Tipo_Usuario (ID, Descripcion) VALUES (1, 'Administrador');
INSERT INTO TBL_Tipo_Usuario (ID, Descripcion) VALUES (2, 'Vendedor');

-- Insertar usuarios
INSERT INTO TBL_Usuario ( Nombre, Apellido, Correo, Usuario, Contrasena, Celular, ID_Tipo_Usuario, Estado)
VALUES ('Carlos', 'Hernández', 'carlos@empresa.com', 'charlie', '1234', '88889999', 1, 1);
INSERT INTO TBL_Usuario (Nombre, Apellido, Correo, Usuario, Contrasena, Celular, ID_Tipo_Usuario, Estado)
VALUES ('María', 'López', 'maria@empresa.com', 'mlopez', 'abcd', '99998888', 2, 1);

-- Insertar clientes
INSERT INTO TBL_Cliente (ID, RTN, Nombre, Direccion, Celular, C_Compras)
VALUES (1, '08011999123456', 'Roberto Zelaya', 'Col. Kennedy', '98765432', 5);
INSERT INTO TBL_Cliente (ID, RTN, Nombre, Direccion, Celular, C_Compras)
VALUES (2, '08011999123457', 'Ana Torres', 'Col. Miraflores', '87654321', 3);

-- Insertar proveedores
INSERT INTO TBL_Proveedores (ID, RTN, Nombre, Direccion, Celular, C_Compras)
VALUES (1, '08011988123456', 'Proveedora Uno', 'Zona Industrial', '88882222', 10);
INSERT INTO TBL_Proveedores (ID, RTN, Nombre, Direccion, Celular, C_Compras)
VALUES (2, '08011988123457', 'Distribuciones S.A.', 'Bulevar del Norte', '77773333', 7);

-- Insertar tipos de impuesto
INSERT INTO TBL_Tipo_Impuesto (ID, Descripcion)
VALUES (1, 'Exento');
INSERT INTO TBL_Tipo_Impuesto (ID, Descripcion)
VALUES (2, '15% ISV');

-- Insertar categorías de producto
INSERT INTO TBL_Categoria_Producto (ID, Descripcion)
VALUES (1, 'Tecnología');
INSERT INTO TBL_Categoria_Producto (ID, Descripcion)
VALUES (2, 'Papelería');

-- Insertar productos
INSERT INTO TBL_Productos (ID_Producto, Codigo_Barra, Descripcion, ISV, ID_Categoria_Producto, Precio_Unitario, Precio_Completo, Cantidad)
VALUES (1, '1234567890123', 'Laptop HP 15"', 2, 1, 10000.00, 11500.00, 10);
INSERT INTO TBL_Productos (ID_Producto, Codigo_Barra, Descripcion, ISV, ID_Categoria_Producto, Precio_Unitario, Precio_Completo, Cantidad)
VALUES (2, '9876543210987', 'Resma de papel', 2, 2, 150.00, 172.50, 100);
