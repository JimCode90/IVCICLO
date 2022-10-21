USE [VentasLeon]
GO

CREATE TABLE [dbo].[Tb_Producto_Aud](
	[Cod_pro] [char](4) NOT NULL,
	[Des_pro] [varchar](50) NULL,
	[Pre_pro] [money] NULL,
	[Stk_act] [int] NULL,
	[Stk_min] [int] NULL,
	[Id_UM] [int] NULL,
	[Id_Cat] [int] NULL,
	[Importado] [int] NULL,
	[Fec_Registro] [datetime] NULL,
	[Usu_Registro] [varchar](20) NULL,
	[Fec_Ult_Mod] [datetime] NULL,
	[Usu_Ult_Mod] [varchar](20) NULL,
	[Est_pro] [int] NULL,
	[Accion] [varchar](20) NULL,
	[FechaAccion] [datetime] NULL,
 ) 
GO

CREATE or ALTER TRIGGER [dbo].[TR_TB_Producto1]
ON [dbo].[Tb_Producto]
FOR INSERT 
AS
INSERT INTO Tb_Producto_Aud 
SELECT [Cod_pro]
      ,[Des_pro]
      ,[Pre_pro]
      ,[Stk_act]
      ,[Stk_min]
      ,[Id_UM]
      ,[Id_Cat]
      ,[Importado]
      ,[Fec_Registro]
      ,[Usu_Registro]
      ,[Fec_Ult_Mod]
      ,[Usu_Ult_Mod]
      ,[Est_pro]
	  ,'INSERTADO'
      ,GETDATE()
  FROM Inserted

GO

CREATE or ALTER TRIGGER [dbo].[TR_TB_Producto2]
ON [dbo].[Tb_Producto]
FOR Delete 
AS
INSERT INTO Tb_Producto_Aud 
SELECT [Cod_pro]
      ,[Des_pro]
      ,[Pre_pro]
      ,[Stk_act]
      ,[Stk_min]
      ,[Id_UM]
      ,[Id_Cat]
      ,[Importado]
      ,[Fec_Registro]
      ,[Usu_Registro]
      ,[Fec_Ult_Mod]
      ,[Usu_Ult_Mod]
      ,[Est_pro]
	  ,'ELIMINADO'
      ,GETDATE()
  FROM Deleted

GO
CREATE or ALTER TRIGGER [dbo].[TR_TB_Producto3]
ON [dbo].[Tb_Producto]
FOR Update 
AS
INSERT INTO Tb_Producto_Aud 
SELECT [Cod_pro]
      ,[Des_pro]
      ,[Pre_pro]
      ,[Stk_act]
      ,[Stk_min]
      ,[Id_UM]
      ,[Id_Cat]
      ,[Importado]
      ,[Fec_Registro]
      ,[Usu_Registro]
      ,[Fec_Ult_Mod]
      ,[Usu_Ult_Mod]
      ,[Est_pro]
	  ,'NUEVA VERSION'
      ,GETDATE()
  FROM Inserted

INSERT INTO Tb_Producto_Aud 
SELECT [Cod_pro]
      ,[Des_pro]
      ,[Pre_pro]
      ,[Stk_act]
      ,[Stk_min]
      ,[Id_UM]
      ,[Id_Cat]
      ,[Importado]
      ,[Fec_Registro]
      ,[Usu_Registro]
      ,[Fec_Ult_Mod]
      ,[Usu_Ult_Mod]
      ,[Est_pro]
	  ,'ANTERIOR VERSION'
      ,GETDATE()
  FROM Deleted

GO





