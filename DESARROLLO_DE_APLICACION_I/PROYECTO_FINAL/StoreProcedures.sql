use SistemaDocumentosPNP;

-- Crear Procedimiento Almacenado usp_ListarGrados --
	   
CREATE PROCEDURE usp_ListarGrados AS BEGIN
SELECT
       idTipoGrado,
       descripcion,
       estado
FROM
       TipoGrado
ORDER BY
       idTipoGrado
END
GO

-- Crear Procedimiento Almacenado usp_ListarUnidades --
	   
CREATE PROCEDURE usp_ListarUnidades AS BEGIN
SELECT
       idUnidad,
       nombre,
       estado
FROM
       Unidades
ORDER BY
       idUnidad
END
GO