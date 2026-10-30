import java.io.File;
import java.util.Arrays;

public class App {
    public static void main(String[] args) {

        // File fichero = new File("D:\\2026-27\\AccesoADatos\\T1\\Arch1.txt");

        String dir = "D:\\2026-27\\AccesoADatos\\T1";
        File directorio = new File(dir);

        // var filesInDir = directorio.listFiles();
        File[] filesInDir = directorio.listFiles();

        for (File fichero : filesInDir) {
            System.out.println("Nombre: " + fichero.getName());
            System.out.println("Longitud archivo: " + fichero.length());
            System.out.println("Ruta relativa: " + fichero.getPath());
            System.out.println("Ruta absoluta: " + fichero.getAbsolutePath());
            System.out.println("Existe?: " + fichero.exists());
            System.out.println("Es archivo?: " + fichero.isFile());
            System.out.println("Es directorio?: " + fichero.isDirectory());
            System.out.println("Se puede leer?: " + directorio.canRead());
            System.out.println("Se puede escribir?: " + directorio.canWrite());
            System.out.println("Directorio padre?: " + directorio.getParent());

        }
        int profundidad = 0;
        inspeccionaDirectorio(directorio,profundidad);
    }

    private static void inspeccionaDirectorio(File directorio, int profundidad) {
        File [] archivosDirectorio = directorio.listFiles();
        int nuevaProfundidad = profundidad +1;
        
        for (File file : archivosDirectorio) {
            if (file.isDirectory()) {
                inspeccionaDirectorio(file, profundidad);
            }
            System.out.println("\n\r");
            System.out.println("Profundiad: "+profundidad+" Nombre archivo: " + file.getName());
        }
        }
    }
