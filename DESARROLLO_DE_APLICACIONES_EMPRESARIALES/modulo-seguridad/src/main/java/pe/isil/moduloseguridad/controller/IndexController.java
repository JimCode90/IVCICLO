package pe.isil.moduloseguridad.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import pe.isil.moduloseguridad.model.User;
import pe.isil.moduloseguridad.service.UserService;
import pe.isil.moduloseguridad.service.Welcome;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@Controller
public class IndexController {


//    @Autowired
//    private Welcome welcome;
    @Qualifier("userServiceDAO")
    @Autowired
    private UserService userService;

    @GetMapping({"/", "home"})
    public String index(Model model){
//        List<String> list = new ArrayList<>();
//        list.add("Primer elemento");
//        list.add("Segundo elemento");
//
//        String name = "Jimmy";
//        model.addAttribute("list", list);

//        int number = getRandomNumber();
//        model.addAttribute("num", number);

//        model.addAttribute("saludo", welcome.sayHello());
//        model.addAttribute("despedida", welcome.sayGoodbye());
        model.addAttribute("lstusers", userService.getUsers());

        return "index";
    }

//    public int getRandomNumber(){
//        return (int) (Math.random() * 100);
//    }
}
