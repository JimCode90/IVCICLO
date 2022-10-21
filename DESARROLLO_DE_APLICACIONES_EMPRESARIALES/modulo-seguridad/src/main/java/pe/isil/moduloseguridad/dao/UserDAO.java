package pe.isil.moduloseguridad.dao;

import org.springframework.stereotype.Repository;
import pe.isil.moduloseguridad.model.User;

import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;


@Repository
public class UserDAO {

    public List<User> getUsers() throws Exception {
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/bd_question", "root", "");

        Statement statement = connection.createStatement();
        ResultSet rs = statement.executeQuery("SELECT name, email FROM users");
        List<User> users = new ArrayList<>();
        int count = 1;
        while (rs.next()){
            User user = new User(count, rs.getString("email"), rs.getString("name"), "Paytan", "Villavicencio", "Jr las micas 252", "", LocalDate.of(1990,05,4));
            count++;
            users.add(user);
        }

        return users;


    }
}
