<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    </head>

    <body>
        <div id="container">
            <h1 class="mt-3 text-center text-info">Ingresar a la plataforma</h1>
            <div class="row justify-content-center mt-3">
                <div class="col-4">
                    <form action="<%= request.getContextPath()%>/LoginServlet" method="post">
                        <div class="mb-3 row">
                            <label for="correo" class="col-sm-2 col-form-label">Email</label>
                            <div class="col-sm-10">
                                <input type="correo" class="form-control" id="correo" name="correo">
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="password" class="col-sm-2 col-form-label">Password</label>
                            <div class="col-sm-10">
                                <input type="password" class="form-control" id="password" name="password">
                            </div>
                        </div>
                        <input class="btn btn-info w-100" id="button" type="submit" value="Ingresar" />    
                    </form>
                </div>
            </div>
            <div class="row justify-content-center mt-3">
                <div class="col-2">
                    <a class="btn btn-success w-100" href="<%= request.getContextPath()%>/RegisterUsuarioServlet">Crear usuario</a>
                </div>
                <div class="col-2">
                    <a class="btn btn-warning w-100" href="<%= request.getContextPath()%>/RecoveryPasswordServlet">Recuperar Contraseña</a>
                </div>
            </div>


        </div>
    </body>
</html>