package com.davidchura.sistema1141;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;
import android.util.Log;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.davidchura.sistema1141.adapters.CategoriaAdapter;
import com.davidchura.sistema1141.adapters.EmpleadoAdapter;
import com.davidchura.sistema1141.databinding.ActivityEmpleadosBinding;
import com.davidchura.sistema1141.databinding.ActivityLoginBinding;
import com.davidchura.sistema1141.utils.Total;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;

public class EmpleadosActivity extends AppCompatActivity {
    private ActivityEmpleadosBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityEmpleadosBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        leerDatos();
    }

    private void leerDatos() {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = Total.rutaServicio + "empleados.php";

        StringRequest stringRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        Log.d("DATOS",response);
                        llenarLista(response);
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Log.d("DATOSERROR",error.getMessage());
            }
        });
        queue.add(stringRequest);
    }
    private void llenarLista(String response) {
        ArrayList arrayList = new ArrayList<HashMap<String,String>>();
        try {
            JSONArray jsonArray = new JSONArray(response);
            for(int i = 0; i< jsonArray.length(); i++ ){
                String apellidos = jsonArray.getJSONObject(i).getString("apellidos");
                String nombres = jsonArray.getJSONObject(i).getString("nombres");
                String cargo = jsonArray.getJSONObject(i).getString("cargo");
                String foto = jsonArray.getJSONObject(i).getString("foto");
                HashMap<String,String> map = new HashMap<>();
                map.put("apellidos",apellidos);
                map.put("nombres",nombres);
                map.put("cargo",cargo);
                map.put("foto",foto);
                arrayList.add(map);
            }

            EmpleadoAdapter empleadoAdapter = new EmpleadoAdapter(arrayList);
            binding.rvEmpleados.setAdapter(empleadoAdapter);

            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
            linearLayoutManager.setOrientation(LinearLayoutManager.HORIZONTAL);
            binding.rvEmpleados.setLayoutManager(linearLayoutManager);

        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}