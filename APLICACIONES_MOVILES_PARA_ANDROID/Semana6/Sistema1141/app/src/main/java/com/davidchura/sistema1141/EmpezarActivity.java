package com.davidchura.sistema1141;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class EmpezarActivity extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_empezar);
        Button btnLogin = findViewById(R.id.btnLogin);
        Button btnTerminos = findViewById(R.id.btnTerminos);

        btnLogin.setOnClickListener(this);
        btnTerminos.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.btnLogin:
                startActivity(new Intent(this, LoginActivity.class));
                break;
            case R.id.btnTerminos:
                startActivity(new Intent(this, TerminosActivity.class));
                break;
        }
    }
}