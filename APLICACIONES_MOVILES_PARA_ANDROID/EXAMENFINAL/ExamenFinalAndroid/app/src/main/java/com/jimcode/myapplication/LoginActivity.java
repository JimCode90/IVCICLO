package com.jimcode.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import com.jimcode.myapplication.databinding.ActivityLoginBinding;

public class LoginActivity extends AppCompatActivity {

    private ActivityLoginBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityLoginBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        getSupportActionBar().hide();
    }
}