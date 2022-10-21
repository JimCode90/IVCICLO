USE [VentasLeon]
GO

CREATE OR ALTER PROCEDURE [dbo].[usp_ActualizarCategoria]
@Id_Cat int,
@Des_Cat varchar(50),
@Foto_Cat image
AS
update Tb_Categoria set Des_Cat=@Des_Cat,Foto_Cat =@Foto_Cat
where Id_Cat=@Id_Cat
GO

CREATE OR ALTER PROCEDURE [dbo].[usp_EliminarCategoria]
@Id_Cat int
AS
Delete from Tb_Categoria
where Id_Cat=@Id_Cat
GO

CREATE OR ALTER PROCEDURE [dbo].[usp_InsertarCategoria]
@Des_Cat varchar(100),
@Foto_Cat image
AS
insert into Tb_Categoria values(@Des_Cat,@Foto_Cat)
go

CREATE OR ALTER PROCEDURE [dbo].[usp_ConsultarCategoria]
@Id_Cat int
AS
Select Id_Cat, Des_Cat, isnull(Foto_Cat,'') as Foto_Cat  
from Tb_Categoria
where Id_Cat=@Id_Cat
GO


CREATE OR ALTER PROCEDURE [dbo].[usp_ListarCategoria]
AS
Select Id_Cat, Des_Cat, Foto_Cat 
from Tb_Categoria
order by Des_cat
GO



