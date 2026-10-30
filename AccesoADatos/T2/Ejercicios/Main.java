import java.io.FileNotFoundException;

/**
 * Main
 */
public class Main {
    private static final String ruta = "D:\\2026-27\\AccesoADatos\\T2\\Ejercicios\\Peliculas.xml";

    public static void main(String[] args) throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        ejerDOM ej = new ejerDOM();
        // ej.ej1(ruta);
        // ej.ej2();
        // ej.ej3();
        // ej.ej4();
        // ej.ej5(1);
        // ej.ej6();
        // ej.ej7a("El Señor de los Anillos", "inspiracion", ruta);
        // ej.ejer7b("El Señor de los Anillos", ruta);
        ej.ejer8("Depredador", 2020, "Director Apellido5 Apellido3", "accion", "español"); // no se modifica depredador
    }
}