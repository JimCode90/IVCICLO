Use VentasLeon
go
CREATE OR ALTER   Procedure [dbo].[usp_ListarProductosProveedor]
@cod_prv char(4)
as
-- SP que muestra los datos de productos activos abastecidos por un proveedor
-- Elaborado por Jose Leon (10-02-2022)
-- Sistema de Ventas
Select P.cod_pro,des_pro,A.pre_aba 
from Tb_Producto P inner join Tb_Abastecimiento A on P.Cod_pro =A.Cod_pro 
where Est_pro =1 and cod_prv =@cod_prv
order by des_pro
GO
-- Vista para el SP ListarOrden
Create or alter view vw_VistaOrdenes
as
SELECT     Num_oco, Fec_oco, Fec_ate, OC.Cod_prv, Raz_soc_prv, Dir_prv, Tel_prv,
		departamento + '-' + provincia + '-' + distrito as Ubicacion,
                      CASE
                          WHEN  est_oco = '1' THEN 'Pendiente' 
                          WHEN est_oco = '2' THEN 'Atendida' 
                          WHEN est_oco = '3' THEN 'Anulada' 
                       END AS Estado
FROM         Tb_Orden_Compra  OC INNER JOIN Tb_Proveedor P 
                   ON OC.Cod_prv = P.Cod_prv
				   INNER JOIN Tb_Ubigeo  U on P.Id_Ubigeo = U.Id_Ubigeo 
 GO                  

 -- SP para el listado de Ordenes de Compra.
Create or Alter procedure usp_ListarOrden
as
--SP que permite listar las OC desde la vista vw_VistaOrdenes
--Modulo : Ventas
--Autor : Jose Leon Cabel (3-07-2022)

SELECT [Num_oco]
      ,[Fec_oco]
      ,[Fec_ate]
      ,[Cod_prv]
      ,[Raz_soc_prv]
      ,[Dir_prv]
      ,[Tel_prv]
      ,[Ubicacion]
      ,[Estado]
  FROM [dbo].[vw_VistaOrdenes]
  order by Num_oco desc
GO



