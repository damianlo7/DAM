import java.io.File;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        //Ruta archivo
        // File f = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\Directorios\\D1\\D2\\D3");
        // File f = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\Directorios\\");
        File f = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\Directorios\\D1\\D2\\ej2.txt");
   
        File f2 = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\empresa.dat");
        File f3 = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\prueba100MB.txt");
        //Declaraciones
        Ejercicios ej = new Ejercicios();



        //Ejercicios
        // ej.ejer1(f);
        // ej.ejer2(f);
        // ej.ejer3(f, 'a');
        // ej.ejer4(f);
        // ej.ejer5(f, "text of the printing and typesetting i");
        // ej.ejer6(f);
        // ej.ejer8(f);
        // ej.ejer8ConBuffer(f);
        // ej.ejer9();
        // ej.ejer10(f2);
        ej.ejer11(f3);
    }
}
