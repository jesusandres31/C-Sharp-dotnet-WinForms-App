USE [GestionVentas]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tel] [varchar](20) NULL,
	[direccion] [varchar](50) NULL,
	[estado] [int] NULL,
	[correo] [varchar](50) NULL,
	[dni] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_cabecera]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_cabecera](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NULL,
	[idusuario] [int] NULL,
	[idtipoventa] [int] NULL,
	[fecha] [date] NULL,
	[total] [decimal](10, 2) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_detalle]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_detalle](
	[idpedido] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NULL,
	[peso] [decimal](10, 2) NULL,
	[cantidad] [decimal](10, 2) NULL,
	[descuento] [decimal](5, 2) NULL,
	[subtotal] [decimal](10, 2) NULL,
	[idfactura] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[idproveedor] [int] NULL,
	[stock] [decimal](10, 2) NULL,
	[unidad] [varchar](2) NULL,
	[precio] [decimal](10, 2) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tel] [varchar](20) NULL,
	[estado] [int] NULL,
	[correo] [varchar](50) NULL,
	[dni] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_usuario]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_usuario](
	[idtipousuario] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtipousuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_venta]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_venta](
	[idtipoventa] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtipoventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[apeynom] [varchar](50) NULL,
	[tel] [varchar](20) NULL,
	[nomusuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[idtipousuario] [int] NULL,
	[estado] [int] NULL,
	[correo] [varchar](50) NULL,
	[dni] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[factura_cabecera] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[proveedor] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[factura_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[factura_cabecera] CHECK CONSTRAINT [FK_factura_cliente]
GO
ALTER TABLE [dbo].[factura_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_factura_tipo] FOREIGN KEY([idtipoventa])
REFERENCES [dbo].[tipo_venta] ([idtipoventa])
GO
ALTER TABLE [dbo].[factura_cabecera] CHECK CONSTRAINT [FK_factura_tipo]
GO
ALTER TABLE [dbo].[factura_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_factura_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[factura_cabecera] CHECK CONSTRAINT [FK_factura_usuario]
GO
ALTER TABLE [dbo].[pedido_detalle]  WITH CHECK ADD  CONSTRAINT [FK_pedido_factura] FOREIGN KEY([idfactura])
REFERENCES [dbo].[factura_cabecera] ([idfactura])
GO
ALTER TABLE [dbo].[pedido_detalle] CHECK CONSTRAINT [FK_pedido_factura]
GO
ALTER TABLE [dbo].[pedido_detalle]  WITH CHECK ADD  CONSTRAINT [FK_pedido_producto] FOREIGN KEY([idproducto])
REFERENCES [dbo].[producto] ([idproducto])
GO
ALTER TABLE [dbo].[pedido_detalle] CHECK CONSTRAINT [FK_pedido_producto]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_proveedor]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_tipo] FOREIGN KEY([idtipousuario])
REFERENCES [dbo].[tipo_usuario] ([idtipousuario])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_tipo]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [CK_unidad] CHECK  (([unidad]='Kg' OR [unidad]='Ud'))
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [CK_unidad]
GO
/****** Object:  StoredProcedure [dbo].[factura]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[factura]
@id int
as
begin
select c.nombre as "Cliente", c.direccion, c.tel, c.dni, c.correo, d.cantidad, d.peso, d.descuento, d.subtotal, p.descripcion as "Producto",
p.precio, p.unidad, u.apeynom as "Vendedor", u.dni, f.fecha, f.total, f.idfactura, t.descripcion "Tipo"

from pedido_detalle d
inner join factura_cabecera f on f.idfactura = d.idfactura
inner join producto p on d.idproducto = p.idproducto
inner join usuario u on f.idusuario = u.idusuario
inner join cliente c on f.idcliente = c.idcliente 
inner join tipo_venta t on f.idtipoventa = t.idtipoventa
where f.idfactura = @id
end;
GO
/****** Object:  StoredProcedure [dbo].[mejores_clientes]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mejores_clientes]
as
begin
select top 5 c.nombre, c.dni, count(f.idfactura) "cantidad"

from cliente c
inner join factura_cabecera f on f.idcliente = c.idcliente
group by c.nombre, c.dni
order by count(f.idfactura) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[mejores_fechas]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mejores_fechas]
as
begin
select top 5 f.fecha, count(f.idfactura) "cantidad"

from factura_cabecera f
group by f.fecha
order by count(f.idfactura) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[mejores_vendedores]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mejores_vendedores]
as
begin
select top 5 u.apeynom, u.dni, count(f.idfactura) "cantidad"

from usuario u
inner join factura_cabecera f on f.idusuario = u.idusuario
where u.idtipousuario = 2
group by u.apeynom, u.dni
order by count(f.idfactura) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[producto_fecha]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[producto_fecha]
@fecha date
as
begin
select top 5 p.descripcion, sum(d.cantidad) "cantidad"

from producto p
inner join pedido_detalle d on p.idproducto = d.idproducto
inner join factura_cabecera f on d.idfactura = f.idfactura
where f.fecha = @fecha
group by p.descripcion
order by sum(d.cantidad) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[producto_mas_vend]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[producto_mas_vend]
as
begin
select top 10 p.descripcion, sum(d.cantidad) "cantidad"

from producto p
inner join pedido_detalle d on p.idproducto = d.idproducto
group by p.descripcion
order by sum(d.cantidad) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[producto_proveedor]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[producto_proveedor]
@id int
as
begin
select top 5 p.descripcion, r.nombre "Proveedor", sum(d.cantidad) "cantidad"

from producto p
inner join proveedor r on p.idproveedor = r.idproveedor
inner join pedido_detalle d on p.idproducto = d.idproducto
where r.idproveedor = @id
group by r.nombre, p.descripcion
order by sum(d.cantidad) desc
end;
GO
/****** Object:  StoredProcedure [dbo].[RealizarBackUp]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RealizarBackUp]
AS
SET DATEFORMAT 'dmy'

DECLARE @filename VARCHAR(256), @nombre VARCHAR (50)

SET @nombre = 'GestionVentas'+REPLACE(CONVERT(VARCHAR (10), GETDATE(), 103),'/','-')+'_'+REPLACE(CONVERT(VARCHAR (10), GETDATE(), 108),':','.')

SET @filename = 'D:\' + @nombre + '.bak'

BACKUP DATABASE GestionVentas
TO DISK = @filename

SELECT Exito = CONVERT(bit,1),
		Mensaje = 'El backup se realizo con exito, el archivo está ubicado en:' +@filename,
		Id = 0
GO
/****** Object:  StoredProcedure [dbo].[reparto]    Script Date: 15/11/2019 11:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reparto]
@fecha date
as
begin 
select p.descripcion as "Productos", sum(d.peso) "Peso", p.unidad, f.fecha, sum(d.cantidad) "Cantidad"

from
pedido_detalle d
inner join producto p on d.idproducto = p.idproducto
inner join factura_cabecera f on d.idfactura = f.idfactura 
where f.fecha = @fecha
group by p.descripcion, p.unidad, f.fecha
end;
GO
