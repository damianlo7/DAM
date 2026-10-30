package com.example.ejer1;


import android.app.Activity;
import android.app.ComponentCaller;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ToggleButton;

import androidx.activity.EdgeToEdge;
import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContract;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private int cont;
    private TextView tvButton;
    private RatingBar ratingBar;

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
        ToggleButton tg = findViewById(R.id.toggleButton);
        Button btn1 = findViewById(R.id.btn1);
        CheckBox cb1 = findViewById(R.id.cb1);
        CheckBox cb2 = findViewById(R.id.cb2);
        CheckBox cb3 = findViewById(R.id.cb3);
        RadioButton rb1 = findViewById(R.id.radioButton4);
        RadioButton rb2 = findViewById(R.id.radioButton5);
        RadioGroup rg = findViewById(R.id.rg);
        SeekBar sb = findViewById(R.id.seekBar);
        TextView lbSeek = findViewById(R.id.lbSeek);
        Switch sw = findViewById(R.id.switch1);
        ratingBar = findViewById(R.id.ratingBar);
        EditText editText = findViewById(R.id.editTextText);
        Button ib = findViewById(R.id.btn3);
        ImageButton imageButton = findViewById(R.id.imButton);
        tvButton = findViewById(R.id.textViewButton);

        ActivityResultLauncher<Intent> launcher = registerForActivityResult(new ActivityResultContracts.StartActivityForResult(), new ActivityResultCallback<ActivityResult>() {
            @Override
            public void onActivityResult(ActivityResult result) {
                if (result.getResultCode() == RESULT_OK && result.getData() != null) {
                    float rating = result.getData().getFloatExtra("rating", 0f);

                    tvButton.setText(String.valueOf(rating));
                    ratingBar.setRating(rating);
                    Log.i("Ejer1", "Valor recivido: " + rating);
                } else if (result.getResultCode() == RESULT_CANCELED) {
                    Toast.makeText(MainActivity.this, "Cancelado", Toast.LENGTH_SHORT).show();
                }
            }
        });

        tg.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {
                if (tg.isChecked()) {
                    cb1.setChecked(false);
                }

                if (!tg.isChecked()) {
                    cb1.setChecked(true);
                }

            }
        });

        sb.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                lbSeek.setText(Integer.toString(sb.getProgress()));
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
        sw.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {
                if (sw.isChecked()) {
                    sw.setText("Activo");
                } else {
                    sw.setText("Desactivado");
                }
            }
        });
        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                tg.setChecked(false);
                cb1.setChecked(false);
                cb2.setChecked(false);
                cb3.setChecked(false);
                sb.setProgress(0);
                ratingBar.setProgress(0);
                editText.setText("");
                sw.setChecked(false);
            }
        });

        ib.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                int mensaje;

                if (cb2.isChecked()) {
                    cont--;
//                ib.setText(""+cont);
                    mensaje = R.string.toast2;
                } else {
//                ib.setText(""+cont);
                    cont++;
                    mensaje = R.string.toast1;
                }
                ib.setText(String.valueOf(cont));
                Toast toast2 = Toast.makeText(MainActivity.this, getString(mensaje, cont), Toast.LENGTH_LONG);
                toast2.show();
            }
        });

        rb1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast toast = Toast.makeText(MainActivity.this, "Seleccionado el primer radioButton ", Toast.LENGTH_SHORT);
                toast.show();
            }
        });
        rb2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast toast = Toast.makeText(MainActivity.this, "Seleccionado el segundo radioButton ", Toast.LENGTH_SHORT);
                toast.show();
            }
        });

        imageButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(MainActivity.this, Secundaria.class);
                intent.putExtra("nombre", editText.getText().toString());
                intent.putExtra("rating", ratingBar.getRating());
//                startActivityForResult(intent, 1);
                launcher.launch(intent);
            }
        });


    }


    //    @Override
//    public void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
//        super.onActivityResult(requestCode, resultCode, data);
//
//        if (requestCode == 1) {
//            if (resultCode == RESULT_OK && data != null) {
//
//                float rating = data.getFloatExtra("rating", 0f);
//                tvButton.setText(String.valueOf(rating));
//                ratingBar.setRating(rating);
//                Log.i("Ejer1", "Valor recivido: " + rating);
//            } else if (resultCode == RESULT_CANCELED) {
//                Toast.makeText(this, "Cancelado", Toast.LENGTH_SHORT).show();
//            }
//        }
//
//    }
}