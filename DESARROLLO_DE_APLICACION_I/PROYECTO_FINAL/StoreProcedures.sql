use SistemaDocumentosPNP;

-- Crear Procedimiento Almacenado usp_ListarGrados --
	   
CREATE PROCEDURE usp_ListarGrados AS BEGIN
SELECT
       Id_Gra,
       Opc_Gra,
       Est_Gra
FROM
       Tb_TipoGrado
ORDER BY
       Id_Gra
END
GO

-- Crear Procedimiento Almacenado usp_ListarUnidades --
	   
CREATE PROCEDURE usp_ListarUnidades AS BEGIN
SELECT
       Id_Uni,
       Opc_Uni,
       Est_Uni
FROM
       Tb_Unidades
ORDER BY
       Id_Uni
END
GO