package com.example.myapplication;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity {
    private int _contadorPulsaciones = 0;
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

        Button boton = findViewById(R.id.btnPruebaOnClick);
//        boton.setOnClickListener(ManejadorBotonPrueba);
//        boton.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                _contadorPulsaciones++;
//                TextView lableMensaje = findViewById(R.id.lblMensaje);
//                String texto =  ("Pulsado " + _contadorPulsaciones + "Vece(s)");
//                lableMensaje.setText(texto);
//            }
//        });


        boton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView tv2 = findViewById(R.id.tv2);
                EditText et = findViewById(R.id.etNombre);
                tv2.setText(et.getText());

                String nombre = et.getText().toString();



                    if (nombre.contains("a")){
                        Toast toast = Toast.makeText(getApplicationContext(),"El nombre contiene una \"a\"", Toast.LENGTH_LONG);
                        toast.show();
                    }

            }
        });

       

    }


//    public void btnPruebaOnClick(View view) {
//        _contadorPulsaciones++;
//        TextView lableMensaje = findViewById(R.id.lblMensaje);
//        String texto =  ("Pulsado " + _contadorPulsaciones + "Vece(s)");
//        lableMensaje.setText(texto);
//    }

//    private final View.OnClickListener ManejadorBotonPrueba = new View.OnClickListener(){
//        @Override
//        public void onClick(View v) {
//            _contadorPulsaciones++;
//            TextView lableMensaje = findViewById(R.id.lblMensaje);
//            String texto =  ("Pulsado " + _contadorPulsaciones + "Vece(s)");
//            lableMensaje.setText(texto);
//        }
//    }
}