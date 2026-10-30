import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/**
 * ejj6
 */
public class ejj6 {

public static void main(String[] args) throws FileNotFoundException, IOException {
    String path = "D:\\2026-27\\AccesoADatos\\T1\\ejemplos";

    File file = new File(path);
    try(FileInputStream input = new FileInputStream(file)){
        // int valorLeido = 0;
        int elementosLeidos = 0;
        byte [] buffer = new byte[10];
        do {
                elementosLeidos = input.read();
                if (elementosLeidos != -1) {
                    System.out.println((char)elementosLeidos);
                }
        } while (elementosLeidos != -1);
    }
}
    
}