<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Home Page</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    </head>

    <body>
        <div id="container">
            <div class="row justify-content-center">
                <h1 class="mt-3 text-center text-info">Bienvenido</h1>
                <h1 class="mt-3 text-center text-primary">Usted ha iniciado sesión de manera correcta</h1>
                <div class="col-8 text-center">
                    <img src="https://images.emojiterra.com/google/android-10/512px/1f60a.png" class="img-fluid" alt="logo isil">
                </div>
                <div class="col-8 text-center">
                    <a class="btn btn-info" href="<%= request.getContextPath()%>/">Regresar a Menu Principal</a>
                </div>
            </div>
        </div>
    </body>
</html>