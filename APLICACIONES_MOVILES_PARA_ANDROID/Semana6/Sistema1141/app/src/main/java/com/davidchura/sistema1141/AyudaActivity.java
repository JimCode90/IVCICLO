package com.davidchura.sistema1141;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.ListAdapter;

import com.davidchura.sistema1141.databinding.ActivityAyudaBinding;
import com.davidchura.sistema1141.databinding.ActivityLoginBinding;

public class AyudaActivity extends AppCompatActivity {

    private ActivityAyudaBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_ayuda);
        binding = ActivityAyudaBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);


        String consejos[] = {
                "Cambie su contraseña periódicamente",
                "No permanezca demasiado tiempo frente a la pantalla",
                "Lea el manual de procedimientos",
                "Apaque la computadora si no la usa",
                "Su contraseña debe ser dificil de adivinar"
        };

        ListAdapter listAdapter = new ArrayAdapter(
          this,
                android.R.layout.simple_list_item_1,
                consejos
        );
        binding.lvConsejos.setAdapter(listAdapter);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId() == android.R.id.home){
            finish();
        }
        return super.onOptionsItemSelected(item);
    }
}