package pe.isil.moduloseguridad;

import com.mysql.jdbc.Driver;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.sql.*;

@SpringBootApplication
public class Application {
    public static void main(String[] args) throws Exception {
        SpringApplication.run(Application.class, args);
        //load driver
//        Class.forName("com.mysql.cj.jdbc.Driver");
//
//        //Crear Conexion
//        Connection connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/moduloseg", "root", "root");

        //Crear Stament
//        Statement statement = connection.createStatement();
//        PreparedStatement pt = connection.prepareStatement("select * from users where id = ?");
//        pt.setInt(1, 1);

        //Ejectar Sentencia

//        ResultSet resultSet = statement.executeQuery("select * from users");
//        ResultSet resultSet = pt.executeQuery();

        //Recorrer Resultado
//        while (resultSet.next()){
//            System.out.println(resultSet.getString("name"));
//        }

        //Llamamos al storeprocedure
//        CallableStatement callableStatement = connection.prepareCall("{call validarLogin(?, ?, ?)}");
//        callableStatement.setString(1, "DNI46292623");
//        callableStatement.setString(2, "1234586");
//        callableStatement.registerOutParameter(3, Types.INTEGER);
//
//        callableStatement.execute();
//        int resultado = callableStatement.getInt(3);
//
//        if (resultado == 1) {
//            System.out.println("El usuario existe");
//        }else{
//            System.out.println("Las credenciales no concuerdan con nuestros registros!");
//        }
//
//        CallableStatement callableStatement1 = connection.prepareCall("{call listarAllUsers()}");
//        ResultSet resultSet = callableStatement1.executeQuery();
//
//        while (resultSet.next())
//        {
//            System.out.println(resultSet.getString("username"));
//        }
//
//        CallableStatement callableStatement2 = connection.prepareCall("{call listarUserPerId(?)}");
//        callableStatement2.setInt(1, 2);
//        ResultSet resultSet1 = callableStatement2.executeQuery();
//        while (resultSet1.next()){
//            System.out.println(resultSet1.getString("name"));
//        }


    }
}
