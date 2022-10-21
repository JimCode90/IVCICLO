package com.davidchura.sistema1141;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class TerminosActivity extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_terminos);
        Button btnCerrar = findViewById(R.id.btnCerrar);
        btnCerrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        finish(); //Cierra el activity
    }
}