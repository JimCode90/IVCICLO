package com.jimcode.evaluacionpermanente1;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;

import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.navigation.NavigationBarView;

public class MainActivity extends AppCompatActivity {

    PerfilFragment perfilFragment = new PerfilFragment();
    SettingsFragment settingsFragment = new SettingsFragment();
    MenuFragment menuFragment = new MenuFragment();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().setDisplayShowTitleEnabled(false);
        BottomNavigationView navigation = findViewById(R.id.botton_navigation);
        navigation.setOnItemSelectedListener(new NavigationBarView.OnItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                switch (item.getItemId()){
                    case R.id.perfilFragment      :
                        loadFragment(perfilFragment);
                        return true;
                    case R.id.menuFragment:
                        loadFragment(menuFragment);
                        return true;
                    case R.id.settingFragment:
                        loadFragment(settingsFragment);
                        return true;
                }
                return false;
            }
        });

        if (savedInstanceState == null) {
            navigation.setSelectedItemId(R.id.perfilFragment); // change to whichever id should be default
        }
    }

    public void loadFragment(Fragment fragment){
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.frame_container, fragment);
        transaction.commit();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_inicio, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()) {
            case R.id.menu_temperatura:
                mostrarTemperatura();
                return true;
            case R.id.menu_presion:
                mostrarPresion();
                return true;
            case R.id.menu_temperatura_list:
                mostrarTemperaturaLista();
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

    private void mostrarTemperatura(){
        startActivity(new Intent(this, TemperaturaActivity.class));
    }

    private void mostrarPresion()
    {
        startActivity(new Intent(this, PresionActivity.class));
    }

    private void mostrarTemperaturaLista(){
        startActivity(new Intent(this, TemperaturaListActivity.class));
    }
}