package com.example.pruebaentorno;

import android.os.Bundle;
import android.util.Log;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Locale;

public class MainActivity extends AppCompatActivity {
    private static  final String TAG = "MainActivity";

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

    }


    @Override
    protected void onStart() { // La actividad está a punto de hacerse visible.
        super.onStart();
        Log.i(TAG, "paso por onStart");
        Toast toast = Toast.makeText(getApplicationContext(),"Se inicio la app",Toast.LENGTH_LONG);
        toast.show();
    }

    @Override
    protected void onResume() { // La actividad se ha hecho visible, se ha reanudado.
        super.onResume();
        Log.i(TAG, "paso por onResume");
    }


    @Override
    protected void onPause() { // Otra actividad está tomando el foco y esta
        // actividad va a ser "pausada".
        super.onPause();
        Log.i(TAG, "paso por onPause");
    }



    @Override
    protected void onStop() { // La actividad ya no es visible y ahora está "parada"
        super.onStop();
        Log.i(TAG, "paso por onStop");
    }


    @Override
    protected void onRestart() { // La actividad, que estaba parada,
        // está a punto de iniciarse.
        super.onRestart();
        Log.i(TAG, "paso por onRestart");
    }


    @Override
    protected void onDestroy() { // La actividad está a punto de ser destruida.
        super.onDestroy();
        Log.i(TAG, "paso por onDestroy");
    }


}