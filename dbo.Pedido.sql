CREATE TABLE [dbo].[Pedido] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [nombreCliente]         VARCHAR (50)  NOT NULL,
    [fechaPedido]           DATETIME      NOT NULL,
    [cantidadTotal]         INT           NOT NULL,
    [cantidadDineroUsuario] INT           NOT NULL,
	[dimensionJardin]		FLOAT NOT NULL, 
    [comentario]            VARCHAR (250) NULL,
    [idPlanta]              INT           NOT NULL,
    [idAdorno]              INT           NOT NULL,
   
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pedido_To_Adorno] FOREIGN KEY ([idAdorno]) REFERENCES [dbo].[Adorno] ([Id]),
    CONSTRAINT [FK_Pedido_To_Planta] FOREIGN KEY ([idPlanta]) REFERENCES [dbo].[Planta] ([Id])
);

