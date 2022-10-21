package com.davidchura.sistema1141;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;

public class SplashActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash);
        new Handler(Looper.getMainLooper()).postDelayed(()->{
            mostrarMain();
        },3000);
    }

    private void mostrarMain() {
<<<<<<< HEAD:APLICACIONES_MOVILES_PARA_ANDROID/Semana6/Sistema1141/app/src/main/java/com/davidchura/sistema1141/SplashActivity.java

        SharedPreferences sharedPreferences = getSharedPreferences("datosSesion", Context.MODE_PRIVATE);
        String datos = sharedPreferences.getString("datosUsuario", "nn");

        if (datos.equals("nn")){
            startActivity(new Intent(this, MainActivity.class));
        }
        else
        {
            startActivity(new Intent(this, EscritorioActivity.class));
        }

        finish();


=======
        SharedPreferences sharedPreferences = getSharedPreferences("datosSesion", Context.MODE_PRIVATE);
        String datos = sharedPreferences.getString("datosUsuario","nn");
        if(datos.equals("nn")){
            startActivity(new Intent(this, MainActivity.class));
        }
        else{
            startActivity(new Intent(this, EscritorioActivity.class));
        }
        finish();
>>>>>>> b5bce6c2b79b6b8d20e75acab9bddb59332a248b:APLICACIONES_MOVILES_PARA_ANDROID/Sistema1141/app/src/main/java/com/davidchura/sistema1141/SplashActivity.java
    }
}