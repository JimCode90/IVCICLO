package pe.isil.moduloseguridad.service;

import org.springframework.stereotype.Service;

@Service("WelcomeCastellano")
public class WelcomeImplEsp implements Welcome {
    @Override
    public String sayHello() {
        return "Hola";
    }

    @Override
    public String sayGoodbye() {
        return "Adios";
    }
}
