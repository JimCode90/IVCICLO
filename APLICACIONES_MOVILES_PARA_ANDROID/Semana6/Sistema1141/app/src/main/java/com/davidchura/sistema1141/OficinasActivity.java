package com.davidchura.sistema1141;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.RadioButton;

import com.davidchura.sistema1141.fragments.BarcelonaFragment;
import com.davidchura.sistema1141.fragments.EstocolmoFragment;
import com.davidchura.sistema1141.fragments.TokioFragment;

public class OficinasActivity extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_oficinas);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);


        RadioButton rbTokio = findViewById(R.id.rbTokio);
        RadioButton rbBarcelona = findViewById(R.id.rbBarcelona);
        RadioButton rbEstocolmo = findViewById(R.id.rbEstocolmo);

        rbTokio.setOnClickListener(this);
        rbBarcelona.setOnClickListener(this);
        rbEstocolmo.setOnClickListener(this);

        rbTokio.setChecked(true);
        mostrarTokio();
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId() == android.R.id.home){
            finish();
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.rbBarcelona:
                mostrarBarcelona(); 
                break;
            case R.id.rbEstocolmo:
                mostrarEstocolmo(); 
                break;
            case R.id.rbTokio:
                mostrarTokio();
                break;
        }
    }

    private void mostrarBarcelona() {
        getSupportFragmentManager().beginTransaction()
                .replace(R.id.contenedor, new BarcelonaFragment())
                .commit();
    }

    private void mostrarEstocolmo() {
        getSupportFragmentManager().beginTransaction()
                .replace(R.id.contenedor, new EstocolmoFragment())
                .commit();
    }

    private void mostrarTokio() {
        getSupportFragmentManager().beginTransaction()
                .replace(R.id.contenedor, new TokioFragment())
                .commit();
    }
}