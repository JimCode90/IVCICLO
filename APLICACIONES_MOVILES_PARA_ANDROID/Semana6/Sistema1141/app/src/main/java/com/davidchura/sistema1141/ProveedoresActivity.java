package com.davidchura.sistema1141;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.widget.ListAdapter;
import android.widget.SimpleAdapter;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.davidchura.sistema1141.databinding.ActivityInformacionBinding;
import com.davidchura.sistema1141.databinding.ActivityProveedoresBinding;
import com.davidchura.sistema1141.utils.Total;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;

public class ProveedoresActivity extends AppCompatActivity {
    private ActivityProveedoresBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityProveedoresBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        leerDatos();
    }

    private void leerDatos() {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = Total.rutaServicio + "proveedores.php";

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
                String nombreempresa = jsonArray.getJSONObject(i).getString("nombreempresa");
                String nombrecontacto = jsonArray.getJSONObject(i).getString("nombrecontacto");
                String cargocontacto = jsonArray.getJSONObject(i).getString("cargocontacto");
                HashMap<String,String> map = new HashMap<>();
                map.put("nombreempresa",nombreempresa);
                map.put("nombrecontacto",nombrecontacto);
                map.put("cargocontacto",cargocontacto);
                arrayList.add(map);
            }
            String[] origen = {"nombreempresa", "nombrecontacto", "cargocontacto" };
            int[] destino = {R.id.tvProveedorEmpresa, R.id.tvProveedorContacto, R.id.tvProveedorCargo };

            ListAdapter listAdapter =  new SimpleAdapter(
                    this,
                    arrayList,
                    R.layout.item_proveedor,
                    origen,
                    destino
            );
            binding.lvProveedores.setAdapter(listAdapter);

        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId() == android.R.id.home){
            finish();
        }
        return super.onOptionsItemSelected(item);
    }
}