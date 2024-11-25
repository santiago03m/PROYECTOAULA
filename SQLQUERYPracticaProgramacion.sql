CREATE DATABASE LaQuiebraLTDA
go
use LaQuiebraLTDA
go
CREATE TABLE Clientes (
    ID_Cliente INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(20),
    Correo_Electronico VARCHAR(50),
    Fecha_Registro DATE
);
GO
CREATE TABLE Creditos (
    ID_Credito INT PRIMARY KEY,
    ID_Cliente INT,
    Monto_Total DECIMAL(15, 2),
    Fecha_Inicio DATE,
    Fecha_Vencimiento DATE,
    Tasa_Interes DECIMAL(5, 2) default 10 ,
    Estado VARCHAR(20) default 'Activo',
	Cuotas int default 10,
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);
GO
CREATE TABLE Pagos (
    ID_Pago INT PRIMARY KEY,
    ID_Credito INT,
    Fecha_Pago DATE,
    Monto_Pago DECIMAL(15, 2),
    Metodo_Pago VARCHAR(20),
    Estado_Pago VARCHAR(20),

    FOREIGN KEY (ID_Credito) REFERENCES Creditos(ID_Credito)
);
GO
CREATE TABLE Control_Acceso (
    ID_Usuario INT PRIMARY KEY,
    Nombre_Usuario VARCHAR(50),
    Contrasena VARCHAR(255),
    Rol VARCHAR(20),
    Ultimo_Acceso DATETIME,
    Estado_Cuenta VARCHAR(20)	
);
GO
INSERT INTO Clientes (ID_Cliente, Nombre, Apellido, Direccion, Telefono, Correo_Electronico, Fecha_Registro)
VALUES
(1, 'Juan', 'Pérez', 'Calle Principal #123', '555-1234', 'juan.perez@email.com', '2024-01-15'),
(2, 'María', 'Gómez', 'Av. Las Flores #456', '555-5678', 'maria.gomez@email.com', '2024-02-01'),
(3, 'Carlos', 'López', 'Calle Secundaria #789', '555-9012', 'carlos.lopez@email.com', '2024-03-10'),
(4, 'Ana', 'Martínez', 'Av. Sol #321', '555-3456', 'ana.martinez@email.com', '2024-04-05'),
(5, 'Luis', 'Hernández', 'Calle Luna #654', '555-7890', 'luis.hernandez@email.com', '2024-05-20');
GO
INSERT INTO Creditos (ID_Credito, ID_Cliente, Monto_Total, Fecha_Inicio, Fecha_Vencimiento)
VALUES
(1, 1, 50000.00, '2024-01-20', '2024-12-20'),
(2, 2, 75000.00, '2024-02-15', '2025-02-15'),
(3, 3, 30000.00, '2024-03-01', '2024-09-01'),
(4, 4, 45000.00, '2024-04-10', '2025-04-10'),
(5, 5, 60000.00, '2024-05-05', '2025-05-05');
GO
INSERT INTO Pagos (ID_Pago, ID_Credito, Fecha_Pago, Monto_Pago, Metodo_Pago, Estado_Pago)
VALUES
(1, 1, '2024-02-20', 5000.00, 'Transferencia', 'Completado'),
(2, 2, '2024-03-15', 7500.00, 'Tarjeta', 'Completado'),
(3, 3, '2024-04-01', 3000.00, 'Efectivo', 'Completado'),
(4, 4, '2024-05-10', 4500.00, 'Cheque', 'Pendiente'),
(5, 5, '2024-06-05', 6000.00, 'Transferencia', 'Completado');
GO
INSERT INTO Control_Acceso (ID_Usuario, Nombre_Usuario, Contrasena, Rol, Ultimo_Acceso, Estado_Cuenta)
VALUES
(1, 'admin', 'admin123', 'Administrador', '2024-11-18 08:00:00', 'Activo'),
(2, 'usuario1', 'user12345', 'Cliente', '2024-11-17 10:30:00', 'Activo'),
(3, 'usuario2', 'pass456', 'Cliente', '2024-11-16 14:45:00', 'Inactivo'),
(4, 'Taquillera', 'soporte123', 'Taquillera', '2024-11-18 12:00:00', 'Activo'),
(5, 'Taquillera2', 'guest123', 'Taquillera', '2024-11-15 09:00:00', 'Pendiente');

select * from Creditos
GO
CREATE VIEW VistaCreditoCliente AS
SELECT 
    c.ID_Cliente,
    c.Nombre,
    c.Apellido,
    c.Correo_Electronico,
    c.Telefono,
    cr.ID_Credito,
    cr.Monto_Total,
    cr.Fecha_Inicio,
    cr.Fecha_Vencimiento,
    cr.Tasa_Interes,
    cr.Estado AS Estado_Credito,
    ISNULL(SUM(p.Monto_Pago), 0) AS PagosRealizados,
    (cr.Monto_Total - ISNULL(SUM(p.Monto_Pago), 0)) AS DeudaActual
FROM 
    Clientes c
JOIN 
    Creditos cr ON c.ID_Cliente = cr.ID_Cliente
LEFT JOIN 
    Pagos p ON cr.ID_Credito = p.ID_Credito
GROUP BY
    c.ID_Cliente,
    c.Nombre,
    c.Apellido,
    c.Correo_Electronico,
    c.Telefono,
    cr.ID_Credito,
    cr.Monto_Total,
    cr.Fecha_Inicio,
    cr.Fecha_Vencimiento,
    cr.Tasa_Interes,
    cr.Estado