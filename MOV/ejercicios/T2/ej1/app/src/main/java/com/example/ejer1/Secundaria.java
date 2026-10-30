package com.example.ejer1;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RatingBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.activity.OnBackPressedCallback;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Secundaria extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.secundaria);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        TextView tvNombre = findViewById(R.id.tvNombre);
        TextView tvRating = findViewById(R.id.tvRating);
        RatingBar ratingBar = findViewById(R.id.ratingBar2);
        Button btnSecundario = findViewById(R.id.buttonSecundario);
        Button btnVolver = findViewById(R.id.btnVolver);

        Intent intent = getIntent();
        String nombre = intent.getStringExtra("nombre");
        float rating = intent.getFloatExtra("rating",0f);
        tvNombre.setText("Nombre: "+nombre);
        tvRating.setText("Rating: "+ rating);

        ratingBar.setRating(rating);

    btnSecundario.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            Intent intent = new Intent();
            intent.putExtra("rating", ratingBar.getRating());
            setResult(RESULT_OK,intent);
            finish();
        }
    });

    getOnBackPressedDispatcher().addCallback(this, new OnBackPressedCallback(true) {
        @Override
        public void handleOnBackPressed() {
            Intent intent = new Intent();
            intent.putExtra("rating", ratingBar.getRating());
            setResult(RESULT_CANCELED,intent);
            finish();
        }
    });

    btnVolver.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            getOnBackPressedDispatcher().onBackPressed();
        }
    });
    }







}