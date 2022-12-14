package com.example.examenfinal;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import com.example.examenfinal.databinding.ActivityDetalleProductoBinding;
import com.example.examenfinal.databinding.ActivityProductosBinding;

public class DetalleProductoActivity extends AppCompatActivity {

    private ActivityDetalleProductoBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityDetalleProductoBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        getSupportActionBar().setDisplayOptions(ActionBar.DISPLAY_SHOW_CUSTOM);
        getSupportActionBar().setCustomView(R.layout.abs_layout);

        Bundle bundle = getIntent().getExtras();
        String nombre = bundle.getString("nombre");
        binding.txvNombreProducto.setText(nombre);
    }
}