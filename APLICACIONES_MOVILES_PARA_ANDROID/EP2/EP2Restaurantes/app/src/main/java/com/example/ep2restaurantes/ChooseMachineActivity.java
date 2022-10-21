package com.example.ep2restaurantes;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.ep2restaurantes.databinding.ActivityChooseMachineBinding;

public class ChooseMachineActivity extends AppCompatActivity implements View.OnClickListener  {

    private ActivityChooseMachineBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityChooseMachineBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        getSupportActionBar().hide();

        binding.btnVerMenu.setOnClickListener(this);
    }


    @Override
    public void onClick(View v) {
        startActivity(new Intent(this, MenuActivity.class));
        finish();
    }
}