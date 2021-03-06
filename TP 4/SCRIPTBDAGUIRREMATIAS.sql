USE [TP4]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/11/2020 22:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Numero Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 19/11/2020 22:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL,
	[Sueldo] [float] NOT NULL,
	[Fecha Ingreso] [date] NOT NULL,
	[Pass] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos_Electrodomesticos]    Script Date: 19/11/2020 22:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_Electrodomesticos](
	[Codigo] [int] IDENTITY(1,200) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Stock] [int] NOT NULL,
	[Potencia] [int] NOT NULL,
	[Control] [smallint] NOT NULL,
	[Categoria] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos_Informatica]    Script Date: 19/11/2020 22:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_Informatica](
	[Codigo Producto] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Stock] [numeric](18, 0) NOT NULL,
	[Memoria RAM] [numeric](18, 0) NOT NULL,
	[Almacenamiento] [numeric](18, 0) NOT NULL,
	[Perifericos] [smallint] NULL,
	[Gamer] [smallint] NULL,
	[Conexion 5G] [smallint] NULL,
	[Tamaño Pantalla] [float] NULL,
 CONSTRAINT [PK_Productos_Informatica] PRIMARY KEY CLUSTERED 
(
	[Codigo Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (1, N'Ruben', N'Martinez', CAST(95123453 AS Numeric(18, 0)), N'Masculino', N'Extranjero')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (2, N'Claudia', N'Garcia', CAST(46512754 AS Numeric(18, 0)), N'Femenino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (3, N'Ezequiel', N'Ramirez', CAST(46512748 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (4, N'Maria', N'Gaitan', CAST(46512739 AS Numeric(18, 0)), N'Femenino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (5, N'Matias', N'Aguirre', CAST(39375098 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (6, N'Marcos', N'Gonzalez', CAST(45987638 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (7, N'Marta', N'Anido', CAST(45678978 AS Numeric(18, 0)), N'Femenino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (8, N'Harry', N'Potter', CAST(55987312 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (9, N'Benjamin', N'Aguirre', CAST(45798123 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (10, N'Nicolas', N'Soste', CAST(50789457 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (11, N'Carla', N'Gomez', CAST(60789712 AS Numeric(18, 0)), N'Femenino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (14, N'Ron', N'Weasley', CAST(12899787 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (12, N'Ignacio', N'Perez', CAST(59781356 AS Numeric(18, 0)), N'Masculino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (13, N'Claudia', N'Barraza', CAST(65797154 AS Numeric(18, 0)), N'Femenino', N'Argentino')
INSERT [dbo].[Clientes] ([Numero Cliente], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad]) VALUES (15, N'Ron ', N'Weasley', CAST(12456789 AS Numeric(18, 0)), N'Masculino', N'Argentino')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad], [Sueldo], [Fecha Ingreso], [Pass]) VALUES (1, N'Marcos', N'Acuña', CAST(45689785 AS Numeric(18, 0)), N'Masculino', N'Argentino', 45000, CAST(N'2020-05-17' AS Date), N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad], [Sueldo], [Fecha Ingreso], [Pass]) VALUES (2, N'Miguel', N'Palermo', CAST(45689878 AS Numeric(18, 0)), N'Masculino', N'Argentino', 50000.8, CAST(N'2020-02-27' AS Date), N'250cf8b51c773f3f8dc8b4be867a9a02')
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [DNI], [Sexo], [Nacionalidad], [Sueldo], [Fecha Ingreso], [Pass]) VALUES (3, N'Karina', N'Fernandez', CAST(95666483 AS Numeric(18, 0)), N'Femenino', N'Extranjero', 40000, CAST(N'2020-01-17' AS Date), N'68053af2923e00204c3ca7c6a3150cf7')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos_Electrodomesticos] ON 

INSERT [dbo].[Productos_Electrodomesticos] ([Codigo], [Nombre], [Precio], [Stock], [Potencia], [Control], [Categoria]) VALUES (1, N'Licuadora', 5000, 48, 800, 1, N'Cocina')
INSERT [dbo].[Productos_Electrodomesticos] ([Codigo], [Nombre], [Precio], [Stock], [Potencia], [Control], [Categoria]) VALUES (201, N'Ventilador', 8000, 18, 1600, 0, N'Ventilacion')
INSERT [dbo].[Productos_Electrodomesticos] ([Codigo], [Nombre], [Precio], [Stock], [Potencia], [Control], [Categoria]) VALUES (401, N'Heladera', 10000, 12, 3200, 0, N'Refrigeracion')
INSERT [dbo].[Productos_Electrodomesticos] ([Codigo], [Nombre], [Precio], [Stock], [Potencia], [Control], [Categoria]) VALUES (801, N'Batidora', 12500, 300, 800, 1, N'Cocina')
INSERT [dbo].[Productos_Electrodomesticos] ([Codigo], [Nombre], [Precio], [Stock], [Potencia], [Control], [Categoria]) VALUES (1001, N'Secarropa', 15800, 800, 100, 0, N'Cocina')
SET IDENTITY_INSERT [dbo].[Productos_Electrodomesticos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos_Informatica] ON 

INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (1, N'Lenovo 4578', 200000.99, CAST(3 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(240 AS Numeric(18, 0)), 1, 1, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (2, N'Dell 5000', 250000.99, CAST(1 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), 1, 0, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (3, N'HP M4', 180000, CAST(11 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), 0, 0, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (4, N'Asus 8000', 3000000, CAST(1 AS Numeric(18, 0)), CAST(32 AS Numeric(18, 0)), CAST(480 AS Numeric(18, 0)), 1, 1, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (5, N'MSI 1234', 100000, CAST(12 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), 0, 1, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (6, N'Samsung 4578', 10000, CAST(9 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(240 AS Numeric(18, 0)), NULL, NULL, 1, 8)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (7, N'Nokia 1100', 15000, CAST(2 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), NULL, NULL, 1, 10.5)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (9, N'Motorola C115', 18000, CAST(12 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), NULL, NULL, 0, 9)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (10, N'Motrola V3', 20000, CAST(0 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), NULL, NULL, 1, 5)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (11, N'Xiaomi 1234', 40000, CAST(16 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), NULL, NULL, 0, 9)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (12, N'Nokia', 500, CAST(97 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(32 AS Numeric(18, 0)), NULL, NULL, 1, 0)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (14, N'Motorola G5', 80000, CAST(199 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), NULL, NULL, 1, 7)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (15, N'Lenovo 789', 25000098, CAST(499 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(480 AS Numeric(18, 0)), 1, 0, NULL, NULL)
INSERT [dbo].[Productos_Informatica] ([Codigo Producto], [Modelo], [Precio], [Stock], [Memoria RAM], [Almacenamiento], [Perifericos], [Gamer], [Conexion 5G], [Tamaño Pantalla]) VALUES (16, N'Lenovo Thinkpad', 80000, CAST(494 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(800 AS Numeric(18, 0)), 1, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Productos_Informatica] OFF
GO
