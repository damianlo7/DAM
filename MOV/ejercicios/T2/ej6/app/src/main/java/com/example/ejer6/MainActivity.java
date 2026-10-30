package com.example.ejer6;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ejer6.models.Pelicula;
import com.example.ejer6.repositorios.datos;
import com.example.ejer6.uihandlers.PeliculaAdapter;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private ArrayList<Pelicula> peliculas;
    private RecyclerView peliculasRV;
    private PeliculaAdapter adaptadorPelicula;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        ArrayList<Pelicula> peliculas = datos.rellenaPeliculas();

        peliculas = datos.rellenaPeliculas();
        peliculasRV = findViewById(R.id.rvPeliculas);

        adaptadorPelicula = new PeliculaAdapter(peliculas);
        peliculasRV.setAdapter(adaptadorPelicula);
        LinearLayoutManager layoutLineal = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL,false);

        peliculasRV.setLayoutManager(layoutLineal);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater menuInflater = getMenuInflater();
        menuInflater.inflate(R.menu.menu,menu);
        return true;
    }


}