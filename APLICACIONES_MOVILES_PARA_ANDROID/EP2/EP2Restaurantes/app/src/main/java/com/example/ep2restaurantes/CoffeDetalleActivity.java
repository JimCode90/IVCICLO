package com.example.ep2restaurantes;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.ep2restaurantes.databinding.ActivityCoffeDetalleBinding;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class CoffeDetalleActivity extends AppCompatActivity implements View.OnClickListener {

    private ActivityCoffeDetalleBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityCoffeDetalleBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        getSupportActionBar().hide();

        binding.btnRegresar2.setOnClickListener(this);

        Bundle bundle = getIntent().getExtras();
        String idtipo = bundle.getString("idtipo");
        String nombre = bundle.getString("nombre");
        this.setTitle(nombre);
        leerDatos(idtipo);
    }

    private void leerDatos(String idtipo) {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "https://servicioscafe2022.000webhostapp.com/tipoxid.php";
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
                map.put("id", idtipo);
                return map;
            }
        };
        queue.add(stringRequest);
    }

    private void llenarLista(String response) {
        System.out.println(response);
        TextView tvNombre, tvPrecio, tvPrecioTotal;
        tvNombre = (TextView) findViewById(R.id.tvNombre);
        tvPrecio = (TextView) findViewById(R.id.tvPrecio);
        tvPrecioTotal = (TextView) findViewById(R.id.tvPrecioTotal);

        try {
            JSONArray jsonArray = new JSONArray(response);
            String nombre= jsonArray.getJSONObject(0).getString("nombre");
            String precio= jsonArray.getJSONObject(0).getString("precio");
            tvNombre.setText(nombre);
            tvPrecio.setText(precio + " SOL");
            tvPrecioTotal.setText(precio + " SOL");

        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void onClick(View v) {

        startActivity(new Intent(this, MenuActivity.class));
        finish();
    }
}