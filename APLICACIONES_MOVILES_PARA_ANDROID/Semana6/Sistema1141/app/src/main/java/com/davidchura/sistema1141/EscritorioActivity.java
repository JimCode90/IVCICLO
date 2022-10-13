package com.davidchura.sistema1141;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;

import com.davidchura.sistema1141.databinding.ActivityEscritorioBinding;
import com.davidchura.sistema1141.databinding.ActivityTiendaBinding;

public class EscritorioActivity extends AppCompatActivity implements View.OnClickListener {
    private ActivityEscritorioBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityEscritorioBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        binding.btnTienda.setOnClickListener(this);
        binding.btnEmpleados.setOnClickListener(this);
        binding.btnCerrarSesion.setOnClickListener(this);
        binding.btnSalir.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.btnTienda:
                startActivity(new Intent(this, TiendaActivity.class));
                break;
            case R.id.btnEmpleados:
                startActivity(new Intent(this, EmpleadosActivity.class));
                break;
            case R.id.btnCerrarSesion:
                CerrarSesion();
                break;
            case R.id.btnSalir:
                finish();
                break;
        }

    }

    private void CerrarSesion() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setMessage("Estas a punto de cerrar la sesión ¿Desea continuar?")
                .setPositiveButton("Si", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        // START THE GAME!
                        cerrandoSesion();
                    }
                })
                .setNegativeButton("Cancelar", null);

        builder.create();
        builder.show();
    }

    private void cerrandoSesion()
    {
        SharedPreferences sharedPreferences = getSharedPreferences("datosSesion", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.clear();
        editor.apply();
        startActivity(new Intent(this, LoginActivity.class));
        finish();
    }
}