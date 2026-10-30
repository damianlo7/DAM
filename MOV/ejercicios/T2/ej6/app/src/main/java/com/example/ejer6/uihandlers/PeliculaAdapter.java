package com.example.ejer6.uihandlers;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ejer6.R;
import com.example.ejer6.models.Pelicula;

import java.util.ArrayList;

public class PeliculaAdapter extends RecyclerView.Adapter<PeliculaAdapter.PeliculaViewHolder> {
    private final ArrayList<Pelicula> datosPelicula;

    public PeliculaAdapter(ArrayList<Pelicula> peliculas) {
        datosPelicula = peliculas;
    }

    /**
     * Se invoca una vez para cada delda que tene que crear, y debemos especificar cual es
     * el elemento UI que hay que representar.
     *
     * @param parent   The ViewGroup into which the new View will be added after it is bound to
     *                 an adapter position.
     * @param viewType The view type of the new View.
     * @return
     */
    @NonNull
    @Override
    public PeliculaViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View elemento = LayoutInflater.from(parent.getContext()).inflate(R.layout.celda,
                parent, false);
        return new PeliculaViewHolder(elemento);
        // return new MyViewHolder(elemento);
    }

    /**
     * Este metodo se llama cada vez que se necesita actualizar los datos de una celda. Como
     * minimo la primera vez que se representan los datos se llamará una vez por cada posicion
     * @param holder   The ViewHolder which should be updated to represent the contents of the
     *                 item at the given position in the data set.
     * @param position The position of the item within the adapter's data set.
     */
    @Override
    public void onBindViewHolder(@NonNull PeliculaViewHolder holder, int position) {

        Pelicula peliculaArepresentar = this.datosPelicula.get(position);

        String tituloARepresentar = peliculaArepresentar.getTitulo();
        TextView textoDondeMostrarTitulo = holder.getTextViewTitulo();
        textoDondeMostrarTitulo.setText(tituloARepresentar);

        String directorARepresentar = peliculaArepresentar.getDirector();
        TextView textoDondeMostrarDirector = holder.getTextViewDirector();
        textoDondeMostrarDirector.setText(directorARepresentar);

        int imagenArepresentar = peliculaArepresentar.getPortada();
        int ivDondeMostrarPortada = holder.getImageViewPortadaPelicula();
        ivDondeMostrarPortada.setImageBitmap(imagenArepresentar);

    }

    /**
     * Este metodo le va a decir al RecyclerView cuantas celdas tiene que representar
     *
     * @return número de celdas a representar
     */
    @Override
    public int getItemCount() {
        return this.datosPelicula.size();
    }

    public class PeliculaViewHolder extends RecyclerView.ViewHolder {

        private TextView textViewTitulo;
        private TextView textViewDirector;
        private ImageView imageViewPortadaPelicula;

//        private TextView

        public PeliculaViewHolder(@NonNull View itemView) {
            super(itemView);
            this.textViewTitulo = itemView.findViewById(R.id.tvTitulo);
            this.textViewDirector = itemView.findViewById(R.id.tvDirector);
            this.imageViewPortadaPelicula = itemView.findViewById(R.id.imgPortada);

        }

        public TextView getTextViewTitulo() {
            return textViewTitulo;
        }

        public TextView getTextViewDirector(){
            return textViewDirector;
        }
        public ImageView getImageViewPortadaPelicula(){
            return imageViewPortadaPelicula;
        }

        public
    }

}
