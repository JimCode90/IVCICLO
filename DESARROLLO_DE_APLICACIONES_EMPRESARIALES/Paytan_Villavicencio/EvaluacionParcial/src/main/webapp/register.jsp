<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Usuario Register Form</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    </head>

    <body>
        <div id="container">
            <h1 class="mt-3 text-center text-info">Registrar nuevo usuario</h1>
            <div class="row justify-content-center mt-3">
                <div class="col-4">
                    <form action="<%= request.getContextPath()%>/RegisterUsuarioServlet" method="post">
                        <div class="mb-3 row">
                            <label for="correo" class="col-sm-2 col-form-label">Correo</label>
                            <div class="col-sm-10">
                                <input type="correo" class="form-control" id="correo" name="correo">
                            </div>
                        </div>
                         <div class="mb-3 row">
                            <label for="nombre" class="col-sm-2 col-form-label">Nombre</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="nombre" name="nombre">
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="apePaterno" class="col-sm-2 col-form-label">Apellido Paterno</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="apePaterno" name="apePaterno">
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="apeMaterno" class="col-sm-2 col-form-label">Apellido Materno</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="apeMaterno" name="apeMaterno">
                            </div>
                        </div><!-- comment -->
                        <div class="mb-3 row">
                            <label for="direccion" class="col-sm-2 col-form-label">Dirección</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="direccion" name="direccion">
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="password" class="col-sm-2 col-form-label">Password</label>
                            <div class="col-sm-10">
                                <input type="password" class="form-control" id="password" name="password">
                            </div>
                        </div>
                        <input class="btn btn-info w-100" id="button" type="submit" value="Registrar" />    
                    </form>
                </div>
            </div>

           <div class="row justify-content-center mt-3">
                <div class="col-4">
                    <a class="btn btn-success w-100" href="<%= request.getContextPath()%>/LoginServlet">Regresar a Login</a>
                </div>
            </div>
        </div>
    </body>
</html>