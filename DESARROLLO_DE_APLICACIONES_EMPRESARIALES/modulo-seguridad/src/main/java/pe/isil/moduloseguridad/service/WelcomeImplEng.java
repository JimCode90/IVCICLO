package pe.isil.moduloseguridad.service;

import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

@Primary
@Service("WelcomeIngles")
public class WelcomeImplEng implements Welcome {
    @Override
    public String sayHello() {
        return "Hello";
    }

    @Override
    public String sayGoodbye() {
        return "Goodbye";
    }
}
