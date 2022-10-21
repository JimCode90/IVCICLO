package pe.isil.moduloseguridad.service;

import org.springframework.stereotype.Service;
import pe.isil.moduloseguridad.model.User;

import java.time.LocalDate;
import java.util.List;

@Service("userServiceLocal")
public class UserServiceImpl implements UserService{
    @Override
    public List<User> getUsers() {
        User user1 = new User(1, "jimmy@correo.com", "Jimmy", "Paytan", "Villavicencio", "jr ica", "123456", LocalDate.of(1990,05,4));

        User user2 = new User(2, "jorge@correo.com", "Jorge", "Paytan", "Villavicencio", "jr ica", "123456", LocalDate.of(1990,05,4));

        User user3 = new User(3, "maria@correo.com", "Maria", "Paytan", "Villavicencio", "jr ica", "123456", LocalDate.of(1990,05,4));

        return List.of(user1, user2, user3);

    }
}
