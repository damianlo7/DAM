package com.example.ejer3;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Terciaria extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_terciaria);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        Intent intent = getIntent();
        boolean marcado = false;
        if (intent.getBooleanExtra("cb1", false)) {
            Log.i("Terciaria", "CheckBox seleccionado: " + intent.getStringExtra("txt1"));
            marcado = true;
        }
        if (intent.getBooleanExtra("cb2", false)) {
            Log.i("Terciaria", "CheckBox seleccionado: " + intent.getStringExtra("txt2"));
            marcado = true;
        }
        if (intent.getBooleanExtra("cb3", false)) {
            Log.i("Terciaria", "CheckBox seleccionado: " + intent.getStringExtra("txt3"));
            marcado = true;
        }
        if (!marcado) {
            Log.i("Terciaria", "Ningún CheckBox seleccionado");
        }

    }
}