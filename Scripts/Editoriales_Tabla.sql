-- 1. Creacion de la Base de Datos
CREATE DATABASE sistema_biblioteca;
GO

-- 2. Uso de la Base de Datos
USE sistema_biblioteca;
GO

-- 3. Creacion de la Tabla Editoriales
CREATE TABLE Editoriales (
    id_editoriales INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    direccion VARCHAR(255),
    ciudad VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100),
    estado TINYINT DEFAULT 1,
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP
);
GO

-- 4. Insercion de 15 Registros
INSERT INTO Editoriales
    (nombre, direccion, ciudad, telefono, email, estado)
VALUES
('Editorial Hispamer', 'Rotonda Ruben Dario, 150 metros al sur',
 'Managua', '2255-1234', 'contacto@hispamer.com.ni', 1),

('Editorial Universitaria UNAN-Managua', 'Recinto Universitario Ruben Dario',
 'Managua', '2278-6764', 'editorial@unan.edu.ni', 1),

('Editorial UCA', 'Campus de la Universidad Centroamericana',
 'Managua', '2278-3923', 'editorial@uca.edu.ni', 1),

('Editorial Nuevo Amanecer', 'Barrio El Calvario, calle principal',
 'Leon', '2311-2045', 'nuevamanecer@example.com', 1),

('Editorial Cultural Nicaraguense', 'Avenida Central, zona comercial',
 'Granada', '2552-1876', 'cultural@example.com', 1),

('Editorial del Norte', 'Barrio El Centro, calle principal',
 'Matagalpa', '2772-3410', 'editorialnorte@example.com', 1),

('Editorial Segovia', 'Calle del Comercio, costado del parque',
 'Esteli', '2713-2580', 'segovia@example.com', 1),

('Editorial Chontales', 'Barrio San Pedro, avenida principal',
 'Juigalpa', '2512-4678', 'chontales@example.com', 1),

('Editorial del Pacifico', 'Reparto San Antonio, calle 2',
 'Chinandega', '2341-5678', 'pacifico@example.com', 1),

('Editorial Masaya', 'Calle Real, frente al parque central',
 'Masaya', '2522-3490', 'masaya@example.com', 1),

('Editorial Carazo', 'Barrio Guadalupe, avenida central',
 'Jinotepe', '2532-1865', 'carazo@example.com', 1),

('Editorial Rivas', 'Zona centrica, una cuadra al este del parque',
 'Rivas', '2563-2741', 'rivas@example.com', 1),

('Editorial Las Minas', 'Barrio Central, avenida principal',
 'Siuna', '2794-1357', 'lasminas@example.com', 1),

('Editorial Costa Caribe', 'Barrio Punta Fria, calle principal',
 'Bluefields', '2572-4086', 'costacaribe@example.com', 1),

('Editorial Rio San Juan', 'Barrio Central, cerca del parque municipal',
 'San Carlos', '2583-1964', 'riosanjuan@example.com', 1);
GO

-- 5. Consultar los registros insertados
SELECT * FROM Editoriales;
GO