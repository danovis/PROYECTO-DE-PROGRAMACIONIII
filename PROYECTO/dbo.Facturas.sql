CREATE TABLE [dbo].[Facturas] (
    [Id]             VARCHAR (50) NOT NULL,
    [NombreCliente]  VARCHAR (50) NOT NULL,
    [NombreEmpleado] VARCHAR (50) NOT NULL,
    [Producto]       VARCHAR (50) NOT NULL,
    [Cantidad]       VARCHAR (50) NOT NULL,
    [Valor]          VARCHAR (50) NOT NULL,
    [Fecha]          VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

