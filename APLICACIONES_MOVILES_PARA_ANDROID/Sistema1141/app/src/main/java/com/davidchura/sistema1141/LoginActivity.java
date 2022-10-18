package com.davidchura.sistema1141;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.davidchura.sistema1141.databinding.ActivityLoginBinding;
import com.davidchura.sistema1141.utils.Total;
import com.squareup.picasso.Picasso;

import java.util.HashMap;
import java.util.Map;

public class LoginActivity extends AppCompatActivity implements View.OnClickListener {

    private ActivityLoginBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_login);
        binding = ActivityLoginBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        binding.btnIniciarSesion.setOnClickListener(this);
        String ruta = "https://365psd.com/images/istock/previews/9058/90581657-people-large-group.jpg";
        Picasso.get().load(ruta).into(binding.ivFotoLogin);

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
        EditText etUsuario = findViewById(R.id.etUsuario);
        EditText etClave = findViewById(R.id.etClave);
        String usuario = etUsuario.getText().toString();
        String clave = etClave.getText().toString();

        RequestQueue queue = Volley.newRequestQueue(this);
        String url = Total.rutaServicio + "iniciarsesion.php";

        StringRequest stringRequest = new StringRequest(Request.Method.POST, url,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        //Log.d("DATOS",response);
                        verficarLogin(response);
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Log.d("DATOSERROR",error.getMessage());
            }
        }){
            @Nullable
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                HashMap<String,String> map = new HashMap<>();
                map.put("usuario", usuario);
                map.put("clave", clave);
                return map;
            }
        };
        queue.add(stringRequest);
    }

    private void verficarLogin(String response) {
        switch (response){
            case "-1":
                Toast.makeText(this, "El usuario no existe", Toast.LENGTH_SHORT).show();
                break;
            case "-2":
                Toast.makeText(this, "La contraseña es incorrecta", Toast.LENGTH_SHORT).show();
                break;
            default:
                Toast.makeText(this, "Bienvenido", Toast.LENGTH_SHORT).show();
                startActivity(new Intent(this, EscritorioActivity.class));
                verificarGuardarSesion(response);
                finish();
        }
    }

    private void verificarGuardarSesion(String response) {
        if(binding.swGuardarSesion.isChecked()){
            SharedPreferences sharedPreferences = getSharedPreferences("datosSesion", Context.MODE_PRIVATE);
            SharedPreferences.Editor editor = sharedPreferences.edit();
            editor.putString("datosUsuario", response);
            editor.apply();
        }
    }
}