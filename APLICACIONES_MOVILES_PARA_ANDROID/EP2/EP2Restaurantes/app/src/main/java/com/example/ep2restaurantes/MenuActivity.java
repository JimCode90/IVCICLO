package com.example.ep2restaurantes;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.ep2restaurantes.adapters.CoffeAdapter;
import com.example.ep2restaurantes.databinding.ActivityMenuBinding;
import com.example.ep2restaurantes.utils.Total;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;

public class MenuActivity extends AppCompatActivity implements CoffeAdapter.OnItemClickListener {
    private ActivityMenuBinding binding;
    ArrayList arrayList = new ArrayList<HashMap<String,String>>();


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        binding = ActivityMenuBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        getSupportActionBar().hide();
        leerDatos();
    }

    private void leerDatos(){
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = Total.rutaServicio + "tipos.php";
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

        try {
            JSONArray jsonArray = new JSONArray(response);
            for(int i = 0; i< jsonArray.length(); i++ ){
                String idtipo = jsonArray.getJSONObject(i).getString("idtipo");
                String nombre = jsonArray.getJSONObject(i).getString("nombre");
                String imagenchica = jsonArray.getJSONObject(i).getString("foto");

                HashMap<String,String> map = new HashMap<>();
                map.put("idtipo",idtipo);
                map.put("nombre",nombre);
                map.put("imagenchica",imagenchica);

                arrayList.add(map);
            }

            CoffeAdapter coffeAdapter = new CoffeAdapter(arrayList);
            binding.rvCoffes.setAdapter(coffeAdapter);
            binding.rvCoffes.setLayoutManager(new LinearLayoutManager(this));

            coffeAdapter.setOnItemClickListener(this);

        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
//        if(item.getItemId() == android.R.id.home){
//            finish();
//        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onItemClick(int position) {
        //Log.d("POS-ACTI", String.valueOf(position));
        HashMap<String,String> map = (HashMap<String, String>) arrayList.get(position);
        String nombre = map.get("nombre");
        String idtipo = map.get("idtipo");
        Toast.makeText(this, nombre, Toast.LENGTH_SHORT).show();

        Bundle bundle = new Bundle();
        bundle.putString("idtipo",idtipo);
        bundle.putString("nombre",nombre);

        Intent intent = new Intent(this, CoffeDetalleActivity.class);
        intent.putExtras(bundle);
        startActivity(intent);
    }
}