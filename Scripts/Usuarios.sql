USE sistema_biblioteca;
GO

IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
BEGIN
	CREATE TABLE dbo.Usuarios
	(
		Id INT IDENTITY(1,1) NOT NULL
			CONSTRAINT PK_Usuarios PRIMARY KEY,
		Nombre VARCHAR(150) NOT NULL,
		Usuario VARCHAR(50) NOT NULL,
		[Password] VARCHAR(255) NOT NULL,
		Rol VARCHAR(20) NOT NULL
			CONSTRAINT DF_Usuarios_Rol DEFAULT 'normal',
		FotoPerfil VARBINARY(MAX) NULL,
		CONSTRAINT UQ_Usuarios_Usuario UNIQUE (Usuario),
		CONSTRAINT CK_Usuarios_Rol CHECK (Rol IN ('admin', 'normal'))
	);
END;
GO
