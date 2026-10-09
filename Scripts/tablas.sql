-- 1. Creacion de la Base de Datos
CREATE DATABASE sistema_biblioteca;
GO

-- 2. Uso de la Base de Datos
USE sistema_biblioteca;
GO

-- 3. Creacion de la Tabla Editoriales
CREATE TABLE  Editoriales (
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


-- 4. Creacion de la Tabla Categorias
CREATE TABLE Categorias (
    id_categorias INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(255),
    estado TINYINT DEFAULT 1,
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP
);
GO

-- =======================================================
-- REGISTROS PARA LA TABLA CATEGORIAS (15)
-- =======================================================
INSERT INTO Categorias (nombre, descripcion) VALUES
('Poesía y Modernismo', 'Obras poéticas y líricas del modernismo y vanguardismo'),
('Novela y Narrativa', 'Novelas de ficción histórica, social y contemporánea'),
('Historia de Nicaragua', 'Textos sobre épocas precolombina, colonial y contemporánea'),
('Folclore y Tradición Oral', 'Mitos, leyendas, teatro popular y costumbres nicaragüenses'),
('Cuento y Prosa Breve', 'Relatos cortos, antologías y crónicas de narrativa breve'),
('Geografía y Recursos Naturales', 'Estudios de biodiversidad, flora, fauna y vulcanología'),
('Ensayo y Crítica Literaria', 'Análisis académico sobre literatura e identidad cultural'),
('Informática y Programación', 'Desarrollo de software, algoritmos y gestión de bases de datos'),
('Administración y Negocios', 'Gestión empresarial, contabilidad y emprendimiento'),
('Derecho y Ciencias Jurídicas', 'Leyes, códigos procesales y Constitución política nacional'),
('Educación y Pedagogía', 'Metodologías pedagógicas y formación docente técnica'),
('Ciencias Agropecuarias', 'Cultivo, ganadería sostenible y agricultura tropical'),
('Sociología y Humanidades', 'Dinámicas sociales, memoria colectiva e identidad nacional'),
('Teatro y Dramaturgia', 'Obras dramáticas, guiones y comedias populares'),
('Investigación Científica', 'Compilaciones de monografías y memorias técnicas');
GO

-- 5. Creacion de la Tabla Autores
CREATE TABLE Autores (
    id_autores INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    nacionalidad VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100),
    estado TINYINT DEFAULT 1,
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP
);
GO

-- =======================================================
-- REGISTROS PARA LA TABLA AUTORES (15)
-- =======================================================
INSERT INTO Autores (nombre, nacionalidad, telefono, email) VALUES
('Rubén Darío', 'Nicaragüense', '8811-2233', 'ruben.dario@literatura.ni'),
('Gioconda Belli', 'Nicaragüense', '8822-3344', 'gioconda.belli@autores.ni'),
('Sergio Ramírez Mercado', 'Nicaragüense', '8833-4455', 'sergio.ramirez@narrativa.org'),
('Ernesto Cardenal', 'Nicaragüense', '8844-5566', 'ernesto.cardenal@poesia.ni'),
('Claribel Alegría', 'Nicaragüense', '8855-6677', 'claribel.alegria@letras.ni'),
('Pablo Antonio Cuadra', 'Nicaragüense', '8866-7788', 'pacuadra@literatura.ni'),
('Daisy Zamora', 'Nicaragüense', '8877-8899', 'daisy.zamora@poetas.ni'),
('José Coronel Urtecho', 'Nicaragüense', '8888-9900', 'coronel.urtecho@letras.ni'),
('Salomón de la Selva', 'Nicaragüense', '8899-0011', 'sdelaselva@poesia.ni'),
('Lizandro Chávez Alfaro', 'Nicaragüense', '8701-1122', 'chavez.alfaro@cuentos.ni'),
('Fernando Silva', 'Nicaragüense', '8702-2233', 'fernando.silva@lingua.ni'),
('Rosario Aguilar', 'Nicaragüense', '8703-3344', 'rosario.aguilar@novelas.ni'),
('Milagros Palma', 'Nicaragüense', '8704-4455', 'milagros.palma@antropologia.ni'),
('Carlos Alemán Ocampo', 'Nicaragüense', '8705-5566', 'carlos.aleman@folclore.ni'),
('Guillermo Rothschuh Tablada', 'Nicaragüense', '8706-6677', 'rothschuh@educacion.ni');
GO

-- 6. Creacion de la Tabla Libros
-- (Adaptada sin email/telefono, pero vinculada a editorial, autor y categoria)
CREATE TABLE Libros (
    id_libros INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(200) NOT NULL,
    anio_publicacion INT,
    descripcion VARCHAR(255),
    id_editoriales INT NOT NULL,
    id_autores INT NOT NULL,
    id_categorias INT NOT NULL,
    estado TINYINT DEFAULT 1,
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP,

    -- Llaves foraneas
    CONSTRAINT FK_Libros_Editoriales FOREIGN KEY (id_editoriales) REFERENCES Editoriales(id_editoriales),
    CONSTRAINT FK_Libros_Autores FOREIGN KEY (id_autores) REFERENCES Autores(id_autores),
    CONSTRAINT FK_Libros_Categorias FOREIGN KEY (id_categorias) REFERENCES Categorias(id_categorias)
);
GO

-- =======================================================
-- REGISTROS PARA LA TABLA LIBROS (15)
-- =======================================================
INSERT INTO Libros (titulo, anio_publicacion, descripcion, id_editoriales, id_autores, id_categorias) VALUES
('Azul...', 1888, 'Cuentos y poemas que iniciaron el movimiento modernista', 1, 1, 1),
('Cantos de Vida y Esperanza', 1905, 'Obra cumbre de la lírica modernista en español', 2, 1, 1),
('La Mujer Habitada', 1988, 'Novela que entrelaza la historia y la resistencia contemporánea', 3, 2, 2),
('El País de las Mujeres', 2010, 'Sátira política y utopía ambientada en Faguas', 1, 2, 2),
('Castigo Divino', 1988, 'Novela policíaca e histórica sobre los crímenes de León en los años 30', 2, 3, 2),
('Margarita, está linda la mar', 1998, 'Premio Alfaguara de Novela sobre la historia y Rubén Darío', 3, 3, 2),
('Cántico Cósmico', 1989, 'Poema extenso sobre ciencia, creación y contemplación mística', 4, 4, 1),
('El Estrecho Dudoso', 1966, 'Poema épico-documental de la conquista de Centroamérica', 6, 4, 3),
('Cenizas de Izalco', 1966, 'Novela testimonial y memorial sobre Centroamérica', 1, 5, 2),
('El Nicaragüense', 1967, 'Ensayo sobre la psicología, identidad y carácter nacional', 5, 6, 7),
('La Ciudad Doliente', 1992, 'Crónicas y poemas del terremoto de Managua de 1972', 2, 7, 1),
('Panoplia Lírica', 1934, 'Ensayos y aportes de la vanguardia nicaragüense', 6, 8, 7),
('El Soldado Desconocido', 1922, 'Poemas inspirados en las trincheras de la Primera Guerra Mundial', 4, 9, 1),
('Los Monos de San Telmo', 1963, 'Colección de cuentos premiada por Casa de las Américas', 7, 10, 5),
('El Güegüense: Estudio y Versión', 1980, 'Estudio crítico del primer drama satírico de América Latina', 5, 14, 4);
GO
-- 7. Creacion de la Tabla CatalogoLibros
-- (Gestiona los ejemplares fisicos, copias disponibles y su ubicacion en estantes)
CREATE TABLE CatalogoLibros (
    id_catalogolibros INT IDENTITY(1,1) PRIMARY KEY,
    id_libros INT NOT NULL,
    codigo_ejemplar VARCHAR(50) NOT NULL,  -- Codigo de barra o codigo de inventario fisico
    ubicacion_estante VARCHAR(100),       -- Ej: "Estante A - Fila 2"
    numero_edicion VARCHAR(50),
    disponible TINYINT DEFAULT 1,         -- 1 = Disponible, 0 = Prestado/Ocupado
    estado TINYINT DEFAULT 1,             -- 1 = Activo, 0 = De baja/Dañado
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Catalogo_Libros FOREIGN KEY (id_libros) REFERENCES Libros(id_libros)
);
GO

-- =======================================================
-- REGISTROS PARA LA TABLA CATALOGOLIBROS (15)
-- =======================================================
INSERT INTO CatalogoLibros (id_libros, codigo_ejemplar, ubicacion_estante, numero_edicion, disponible, estado) VALUES
(1, 'EJ-AZUL-01', 'Estante A1 - Literatura', '1ra Edición Especial', 1, 1),
(1, 'EJ-AZUL-02', 'Estante A1 - Literatura', 'Edición de Bolsillo', 1, 1),
(2, 'EJ-CANT-01', 'Estante A1 - Literatura', '2da Edición', 0, 1), -- Prestado
(3, 'EJ-MHAB-01', 'Estante B2 - Novela', '1ra Edición', 1, 1),
(3, 'EJ-MHAB-02', 'Estante B2 - Novela', 'Reimpresión 2018', 0, 1), -- Prestado
(4, 'EJ-PMUJ-01', 'Estante B2 - Novela', '1ra Edición', 1, 1),
(5, 'EJ-CDIV-01', 'Estante B3 - Narrativa', 'Edición Conmemorativa', 1, 1),
(6, 'EJ-MARG-01', 'Estante B3 - Narrativa', 'Alfaguara 1ra Ed.', 0, 1), -- Prestado
(7, 'EJ-CCOS-01', 'Estante A2 - Poesía', 'Edición Universitaria', 1, 1),
(8, 'EJ-EDUD-01', 'Estante A2 - Poesía', '1ra Edición', 1, 1),
(9, 'EJ-CIZA-01', 'Estante B1 - Novela', 'Edición Crítica', 1, 1),
(10, 'EJ-ENIC-01', 'Estante C1 - Ensayos', '5ta Edición Ampliada', 0, 1), -- Prestado
(11, 'EJ-CDOL-01', 'Estante A3 - Poesía', '1ra Edición', 1, 1),
(14, 'EJ-MSTL-01', 'Estante B4 - Cuentos', 'Edición Colección', 1, 1),
(15, 'EJ-GUEG-01', 'Estante C2 - Folclore', 'Edición Ilustrada', 1, 1);
GO

-- 8. Creacion de la Tabla Prestamos
CREATE TABLE Prestamos (
    id_prestamos INT IDENTITY(1,1) PRIMARY KEY,
    id_catalogolibros INT NOT NULL,       -- Ejemplar fisico especifico que se presta
    nombre_solicitante VARCHAR(150) NOT NULL,
    identificacion VARCHAR(50),           -- Cedula, carnet o DNI
    telefono VARCHAR(20),
    fecha_prestamo DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    fecha_devolucion_esperada DATE NOT NULL,
    fecha_devolucion_real DATETIME2 NULL,
    observaciones VARCHAR(255),
    estado TINYINT DEFAULT 1,             -- 1 = Prestado/Activo, 2 = Devuelto, 0 = Vencido/Cancelado
    fecha_registro DATETIME2 DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Prestamos_Catalogo FOREIGN KEY (id_catalogolibros) REFERENCES CatalogoLibros(id_catalogolibros)
);
GO

-- =======================================================
-- 6. REGISTROS PARA LA TABLA PRESTAMOS (15)
-- =======================================================
-- Préstamos activos (estado = 1) y devueltos (estado = 2)
INSERT INTO Prestamos (id_catalogolibros, nombre_solicitante, identificacion, telefono, fecha_prestamo, fecha_devolucion_esperada, fecha_devolucion_real, observaciones, estado) VALUES
(3, 'Kevin Alexander Mendoza Gómez', '441-120302-1004D', '8745-1290', '2026-10-01 08:30:00', '2026-10-15', NULL, 'Préstamo para monografía de literatura', 1),
(5, 'Karla Patricia Blandón Ruiz', '001-150601-1002A', '8834-5678', '2026-10-02 09:15:00', '2026-10-16', NULL, 'Ejemplar en buen estado con forro', 1),
(8, 'Marcos Antonio Vallejos Ríos', '281-220803-1005K', '8912-3456', '2026-10-03 10:00:00', '2026-10-17', NULL, 'Préstamo regular a domicilio', 1),
(12, 'Andrea Sofía Castro Morales', '441-050402-1001M', '8423-7789', '2026-10-04 11:20:00', '2026-10-18', NULL, 'Estudiante de segundo año técnico', 1),
(1, 'Byron José Palacios Martínez', '001-180900-1008P', '8654-9912', '2026-09-10 14:00:00', '2026-09-24', '2026-09-22 10:15:00', 'Devuelto a tiempo y sin rayones', 2),
(2, 'Fátima Lucía Centeno Zeledón', '448-251101-1003V', '8789-0123', '2026-09-12 15:30:00', '2026-09-26', '2026-09-25 16:00:00', 'Entrega puntual en biblioteca', 2),
(4, 'Jorge Luis Altamirano Mairena', '441-030103-1007T', '8867-4321', '2026-09-15 08:45:00', '2026-09-29', '2026-09-28 11:30:00', 'Ejemplar entregado completo', 2),
(6, 'Valeria Nicole Sequeira Jarquín', '121-140702-1002S', '8534-7890', '2026-09-18 10:10:00', '2026-10-02', '2026-10-01 14:40:00', 'Revisado por encargado de recepción', 2),
(7, 'Nelson Enrique Guadamuz Solís', '201-300401-1004Y', '8976-5432', '2026-09-20 12:00:00', '2026-10-04', '2026-10-03 09:20:00', 'Sin tachaduras ni páginas dobladas', 2),
(9, 'Tatiana Marcela López Obando', '001-091202-1009B', '8712-3344', '2026-09-22 13:45:00', '2026-10-06', '2026-10-05 15:10:00', 'Devolución conforme en ventanilla', 2),
(10, 'Cristian Eduardo Picado Zamora', '441-190503-1006R', '8645-6677', '2026-09-25 09:00:00', '2026-10-09', '2026-10-08 12:00:00', 'Revisión técnica conforme', 2),
(11, 'Yessenia Margarita Toruño Leiva', '281-081001-1001L', '8890-1122', '2026-09-01 11:00:00', '2026-09-15', '2026-09-15 16:30:00', 'Entregado en la fecha límite', 2),
(13, 'Gabriel Alejandro Fonseca Urbina', '361-270302-1005H', '8521-9988', '2026-09-05 14:15:00', '2026-09-19', '2026-09-18 10:00:00', 'Buen estado de conservación', 2),
(14, 'Adriana Carolina Rivas Mayorga', '001-110203-1008F', '8765-4433', '2026-09-08 16:00:00', '2026-09-22', '2026-09-21 11:45:00', 'Devolución sin observaciones', 2),
(15, 'David Alberto Salgado Espinoza', '441-210800-1002W', '8812-7766', '2026-09-10 10:30:00', '2026-09-24', '2026-09-24 15:00:00', 'Entregado puntualmente', 2);
GO