import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Ejemplo2 {
    public static void main(String[] args) throws IOException {
        String dir = "D:\\2026-27\\AccesoADatos\\T1\\Arch1.txt";
        File directorio = new File(dir);
        // try (FileReader fichIn = new FileReader(directorio)) {
        // int i;
        // while ((i = fichIn.read()) != -1) {
        // System.out.print((char) i);
        // }
        // }

        try (FileReader fichIn = new FileReader(directorio)) {
            int i;
            char buffer[] = new char[50];
            while ((i = fichIn.read(buffer)) != -1) {
                System.out.print(new String(buffer, 0, 10));
            }
        }

    }
}
