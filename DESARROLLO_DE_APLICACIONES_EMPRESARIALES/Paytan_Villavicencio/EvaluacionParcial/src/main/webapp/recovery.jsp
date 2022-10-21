<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Usuario Recovery Form</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    </head>
    <body>
        <div id="container">
            <h1 class="mt-3 text-center text-info">Recuperar Contraseña</h1>
            <div class="row justify-content-center mt-3">
                <div class="col-4">
                   <form action="<%= request.getContextPath()%>/RecoveryPasswordServlet" method="post">
                        <div class="mb-3 row">
                            <label for="correo" class="col-sm-4 col-form-label">Ingrese su email</label>
                            <div class="col-sm-8">
                                <input type="correo" class="form-control" id="correo" name="correo">
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="password" class="col-sm-4 col-form-label">Su contraseña es: </label>
                            <div class="col-sm-8">
                                <input type="text" class="form-control" id="password" name="password" value="${recovery_passw_usu}">
                            </div>
                        </div>
                        <input class="btn btn-info w-100" id="button" type="submit" value="Recuperar" />    
                    </form>
                </div>
            </div>
            <div class="row justify-content-center mt-3">
              
                <div class="col-4">
                    <a class="btn btn-warning w-100" href="<%= request.getContextPath()%>/LoginServlet">Regresar a Login</a>
                </div>
            </div>


        </div>
    
    </body>
</html>