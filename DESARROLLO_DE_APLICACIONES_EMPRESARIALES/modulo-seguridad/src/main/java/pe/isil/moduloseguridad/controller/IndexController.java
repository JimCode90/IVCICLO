package pe.isil.moduloseguridad.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
public class IndexController {

    @GetMapping({"/", "/index", "/inicio"})
    public String index(Model model){
        model.addAttribute("name", "Jimmy Niels");
        return "index";
    }

    @GetMapping("/home")
    public String home(){
        return "home";
    }

}
