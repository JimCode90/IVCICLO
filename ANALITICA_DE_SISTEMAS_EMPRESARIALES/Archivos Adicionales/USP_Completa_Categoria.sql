Create procedure [dbo].[USP_Completa_Categoria]
as
begin
declare @Categoria_SKey int,
		@Categoria_Codigo int

declare c_lee_categoria cursor for
	select Categoria_Codigo, Categoria_SKey from dbo.Stg_CategoriaProducto

Open c_lee_categoria
Fetch next from c_lee_categoria into @Categoria_Codigo, @Categoria_SKey
while @@fetch_status = 0
Begin
	update dbo.Stg_Producto
	   set Categoria_SKey = @Categoria_SKey
	 where CategoriaProducto_Codigo = @Categoria_Codigo

   Fetch next from c_lee_categoria into @Categoria_Codigo, @Categoria_SKey
end

Close c_lee_categoria
deallocate c_lee_categoria

end
