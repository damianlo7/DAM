import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Ejemplo4 {

    public static void copiaFichero(File fichero, File fichero2) throws FileNotFoundException, IOException {

        try (FileReader fichIn = new FileReader(fichero);FileWriter fichOut = new FileWriter(fichero2) ) {
            int i;
            while ((i = fichIn.read()) != -1) {
                    fichOut.write((char) i);  
            }
        }
    }
    public static void copiaFicheroConBuffer(File fichero, File fichero2) throws FileNotFoundException, IOException {

        try (FileReader fichIn = new FileReader(fichero);FileWriter fichOut = new FileWriter(fichero2) ) { {
            int i;
            char buffer[] = new char[50];
            while ((i = fichIn.read(buffer)) != -1) {
                fichOut.write(new String(buffer, 0, 10));
                // System.out.print();
            }
        }
        }
    }

    public static void cambiaFicheroCadenas(File fichero, File fichero2) throws FileNotFoundException{

        try (Scanner sc = new Scanner(fichero);
            PrintWriter pw = new PrintWriter(fichero2)){
                while (sc.hasNextLine()) {

                    String linea = sc.nextLine();
                    pw.println(linea);
                    
                    // if (sc.hasNext()) {
                    //     pw.print("\n");
                    // }
                }
            }
        }
    

    public static void main(String[] args) throws FileNotFoundException, IOException {
        String f1 = "D:\\2026-27\\AccesoADatos\\T1\\Arch1.txt";
        String f2 = "D:\\2026-27\\AccesoADatos\\T1\\Arch2.txt";
        File F1 = new File(f1);
        File F2 = new File(f2);
        // copiaFichero(F1, F2);
        // copiaFicheroConBuffer(F1, F2);
        cambiaFicheroCadenas(F1, F2);
    }
}
