--Agregamos el inicio de sesion
EXEC sp_grantlogin 'IIS APPPOOL\DefaultAppPool' 
go
--Agregamos el usuario a la BD VentasLeon
use VentasLeon
go
EXEC sp_grantdbaccess 'IIS APPPOOL\DefaultAppPool'
go

-- No olvidar luego asignarle la autorizacion del rol  db_owner al usuario
--'IIS APPPOOL\DefaultAppPool'

EXEC sp_addrolemember 'db_owner','IIS APPPOOL\DefaultAppPool'
go

