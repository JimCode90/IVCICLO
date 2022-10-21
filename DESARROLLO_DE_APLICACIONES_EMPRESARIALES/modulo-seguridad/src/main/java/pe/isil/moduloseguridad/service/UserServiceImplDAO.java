package pe.isil.moduloseguridad.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import pe.isil.moduloseguridad.dao.UserDAO;
import pe.isil.moduloseguridad.model.User;

import java.util.List;


@Service("userServiceDAO")
public class UserServiceImplDAO implements UserService {

    @Autowired
    private UserDAO userDAO;
    @Override
    public List<User> getUsers() {

        try{
            return userDAO.getUsers();
        }catch (Exception e){
            e.printStackTrace();
            return null;
        }
    }
}
