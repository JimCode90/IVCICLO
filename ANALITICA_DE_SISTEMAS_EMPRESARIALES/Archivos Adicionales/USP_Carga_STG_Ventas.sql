CREATE PROCEDURE USP_Carga_STG_Ventas
as
BEGIN
	insert into STG_VENTAS (
		Cliente_Codigo, Cliente_SKey,
		Empleado_Codigo, Empleado_SKey,
		Producto_Codigo, Producto_SKey,
		Tiempo_Skey,Ventas_OrderDate,
		Ventas_NOrden,
		Ventas_Monto,Ventas_Unidades,
		Ventas_PUnitario,Ventas_Descuento)
	SELECT
	  Cliente_Codigo, Cliente_SKey,
	  Empleado_Codigo, Empleado_SKey,
	  Producto_Codigo, Producto_SKey,
	  Tiempo_Skey, OrderDate,
	   O.OrderID,
	  (UnitPrice*Quantity) as MontoVenta, Quantity,
	  UnitPrice, (Discount*UnitPrice*Quantity)
	  FROM Northwind..Orders O
		   INNER JOIN Northwind..[Order Details] D ON O.OrderID = D.OrderID 
		   INNER JOIN dbo.Stg_Cliente SC ON SC.Cliente_Codigo = O.CustomerID
		   INNER JOIN dbo.Stg_Empleado SE ON SE.Empleado_Codigo = O.EmployeeID
		   INNER JOIN dbo.Stg_Producto SP ON SP.Producto_Codigo = D.ProductID
		   INNER JOIN dbo.Stg_Tiempo ST ON ST.Tiempo_FechaActual = O.ShippedDate
	 WHERE (O.ShippedDate IS NOT NULL)
END