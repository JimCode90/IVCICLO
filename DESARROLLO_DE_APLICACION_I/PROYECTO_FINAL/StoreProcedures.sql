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

CREATE PROCEDURE usp_ListarMarcaVehiculo AS BEGIN
SELECT
       Id_Mar_veh,
       Opc_Mar_veh
FROM
       Tb_TipoMarcaVehiculo
ORDER BY
       Id_Mar_veh
END
GO

CREATE PROCEDURE usp_ListarTipoEspecies AS BEGIN
SELECT
       Id_tip_espec,
       Opc_espec
FROM
       Tb_TipoEspecie
ORDER BY
       Id_tip_espec
END
GO