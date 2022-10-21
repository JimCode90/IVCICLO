package com.davidchura.sistema1141;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;
import android.util.Log;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.davidchura.sistema1141.adapters.EmpleadoAdapter;
import com.davidchura.sistema1141.adapters.ProductoAdapter;
import com.davidchura.sistema1141.databinding.ActivityProductosBinding;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class ProductosActivity extends AppCompatActivity {
    private ActivityProductosBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityProductosBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        Bundle bundle = getIntent().getExtras();
        String idcategoria = bundle.getString("idcategoria");
        String nombre = bundle.getString("nombre");
        this.setTitle(nombre);
        leerDatos(idcategoria);
    }

    private void leerDatos(String idcategoria) {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "https://servicios.campus.pe/servicioproductos.php";

        StringRequest stringRequest = new StringRequest(Request.Method.POST, url,
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
        }){
            @Nullable
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                HashMap<String,String> map = new HashMap<>();
                map.put("caty", idcategoria);
                return map;
            }
        };
        queue.add(stringRequest);
    }
    private void llenarLista(String response) {
        ArrayList arrayList = new ArrayList<HashMap<String,String>>();
        try {
            JSONArray jsonArray = new JSONArray(response);
            for(int i = 0; i< jsonArray.length(); i++ ){
                String idproducto = jsonArray.getJSONObject(i).getString("idproducto");
                String nombre = jsonArray.getJSONObject(i).getString("nombre");
                String precio = jsonArray.getJSONObject(i).getString("precio");
                String imagenchica = jsonArray.getJSONObject(i).getString("imagenchica");
                HashMap<String,String> map = new HashMap<>();
                map.put("idproducto",idproducto);
                map.put("nombre",nombre);
                map.put("precio",precio);
                map.put("imagenchica",imagenchica);
                arrayList.add(map);
            }


            ProductoAdapter productoAdapter = new ProductoAdapter(arrayList);
            binding.rvProductos.setAdapter(productoAdapter);

<<<<<<< HEAD:APLICACIONES_MOVILES_PARA_ANDROID/Semana6/Sistema1141/app/src/main/java/com/davidchura/sistema1141/ProductosActivity.java
//            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
//            linearLayoutManager.setOrientation(LinearLayoutManager.HORIZONTAL);
            binding.rvProductos.setLayoutManager(new GridLayoutManager(this, 2));

=======
            binding.rvProductos.setLayoutManager(new GridLayoutManager(this, 3));
>>>>>>> b5bce6c2b79b6b8d20e75acab9bddb59332a248b:APLICACIONES_MOVILES_PARA_ANDROID/Sistema1141/app/src/main/java/com/davidchura/sistema1141/ProductosActivity.java

        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}