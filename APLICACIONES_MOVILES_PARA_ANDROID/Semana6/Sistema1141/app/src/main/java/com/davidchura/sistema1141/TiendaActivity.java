package com.davidchura.sistema1141;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.widget.ListAdapter;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.davidchura.sistema1141.adapters.CategoriaAdapter;
import com.davidchura.sistema1141.databinding.ActivityProveedoresBinding;
import com.davidchura.sistema1141.databinding.ActivityTiendaBinding;
import com.davidchura.sistema1141.utils.Total;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;

public class TiendaActivity extends AppCompatActivity implements CategoriaAdapter.OnItemClickListener {
    private ActivityTiendaBinding binding;
    ArrayList arrayList = new ArrayList<HashMap<String,String>>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityTiendaBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        leerDatos();
    }

    private void leerDatos() {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = Total.rutaServicio + "categorias.php";

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
                String idcategoria = jsonArray.getJSONObject(i).getString("idcategoria");
                String nombre = jsonArray.getJSONObject(i).getString("nombre");
                String descripcion = jsonArray.getJSONObject(i).getString("descripcion");
                HashMap<String,String> map = new HashMap<>();
                map.put("idcategoria",idcategoria);
                map.put("nombre",nombre);
                map.put("descripcion",descripcion);
                arrayList.add(map);
            }

            CategoriaAdapter categoriaAdapter = new CategoriaAdapter(arrayList);
            binding.rvCategorias.setAdapter(categoriaAdapter);
            binding.rvCategorias.setLayoutManager(new LinearLayoutManager(this));

            categoriaAdapter.setOnItemClickListener(this);

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

    @Override
    public void onItemClick(int position) {
        //Log.d("POS-ACTI", String.valueOf(position));
        HashMap<String,String> map = (HashMap<String, String>) arrayList.get(position);
        String nombre = map.get("nombre");
        String idcategoria = map.get("idcategoria");
        Toast.makeText(this, nombre, Toast.LENGTH_SHORT).show();

        Bundle bundle = new Bundle();
        bundle.putString("idcategoria",idcategoria);
        bundle.putString("nombre",nombre);

        Intent intent = new Intent(this, ProductosActivity.class);
        intent.putExtras(bundle);
        startActivity(intent);
    }
}