CREATE procedure [dbo].[USP_Completa_Jefe]
as
begin
declare @JefeKey int,
		@Empleado_SuperiorSKey int,
		@Empleado_Superior nvarchar(70)

declare c_lee_jefe cursor for
	select distinct Empleado_ReportID from dbo.Stg_Empleado
	 where Empleado_ReportID is not null

Open c_lee_jefe
Fetch next from c_lee_jefe into @JefeKey
while @@fetch_status = 0
Begin
	Select @Empleado_SuperiorSKey = Empleado_SKey,
		   @Empleado_Superior = Empleado_NombreCompleto
      from dbo.Stg_Empleado
	 where Empleado_SKey = @JefeKey

	update dbo.Stg_Empleado
	   set Empleado_SuperiorSKey = @Empleado_SuperiorSKey,
		   Empleado_Superior = @Empleado_Superior
	 where Empleado_ReportID = @JefeKey

   Fetch next from c_lee_jefe into @JefeKey
end

Close c_lee_jefe
deallocate c_lee_jefe

end
