package com.davidchura.sistema1141;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;

import com.davidchura.sistema1141.databinding.ActivityLoginBinding;

public class LoginActivity extends AppCompatActivity implements View.OnClickListener {

    private ActivityLoginBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_login);
        binding = ActivityLoginBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        binding.btnIniciarSesion.setOnClickListener(this);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_inicio, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle item selection
        switch (item.getItemId()) {
            case R.id.nav_ayuda:
                mostrarAyuda(); 
                return true;
            case R.id.nav_informacion:
                mostrarInformacion(); 
                return true;
            case R.id.nav_oficinas:
                mostrarOficinas(); 
                return true;
            case R.id.nav_proveedores:
                mostrarProveedores(); 
                return true;
            case R.id.nav_colaboradores:
                mostrarColaboradores();
                return true;
            case R.id.nav_contactos:
                mostrarContactos();
                return true;
            case R.id.nav_calendario:
                mostrarCalendario();
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

    private void mostrarColaboradores() {
        startActivity(new Intent(this, ColaboradoresActivity.class));
    }


    private void mostrarAyuda() {
        startActivity(new Intent(this, AyudaActivity.class));
    }

    private void mostrarInformacion() {
        startActivity(new Intent(this, InformacionActivity.class));
    }

    private void mostrarOficinas() {
        startActivity(new Intent(this, OficinasActivity.class));
    }

    private void mostrarProveedores() {
        startActivity(new Intent(this, ProveedoresActivity.class));
    }

    private void mostrarContactos() {
        Intent intent = new Intent();
        intent.setAction(Intent.ACTION_MAIN);
        intent.addCategory(Intent.CATEGORY_APP_CONTACTS);
        startActivity(intent);
    }

    private void mostrarCalendario() {
        Intent intent = new Intent();
        intent.setAction(Intent.ACTION_MAIN);
        intent.addCategory(Intent.CATEGORY_APP_CALENDAR);
        startActivity(intent);
    }

    @Override
    public void onClick(View view) {
        startActivity(new Intent(this, EscritorioActivity.class));
    }
}