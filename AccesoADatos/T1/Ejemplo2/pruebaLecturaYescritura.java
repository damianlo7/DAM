import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class pruebaLecturaYescritura {

    public static void main(String[] args) throws IOException {
        Cliente c = new Cliente("Ramon", 10, 1);
        Cliente c2 = new Cliente("Juanito", 0, 0);
        Cliente c3 = new Cliente("Rosana", 3330, 200);
        ArrayList<Cliente> datos = new ArrayList<>();
        datos.add(c);
        datos.add(c2);
        datos.add(c3);

        File dir = new File("directorioEscribir/primitivos.dat");
        escribirPrimitivos(dir, datos);
        leerPrimitivos(dir);

        // try {
        // escribirPrimitivos(new File("directorioEscribir/primitivos.dat"), datos);
        // leerPrimitivos(new File("directorioEscribir/primitivos.dat"));
        // } catch (IOException e) {
        // System.out.println(e.getLocalizedMessage());
        // }

    }

    public static void escribirPrimitivos(File fichero, ArrayList<Cliente> datos) throws IOException {
        FileOutputStream fos = null;
        DataOutputStream out = null;
        try {
            fos = new FileOutputStream(fichero);
            out = new DataOutputStream(fos);
            for (Cliente cl : datos) {
                out.writeUTF(cl.getNombre());
                out.writeInt(cl.getNumCompras());
                out.writeFloat(cl.getCredito());
            }
        } catch (IOException e) {
            System.out.println("Error: " +
                    e.getLocalizedMessage());
        } finally {
            if (out != null)
                out.close();
            if (fos != null)
                fos.close();
        }
    }

    public static void leerPrimitivos(File fichero) throws IOException {
        FileInputStream fin = null;
        DataInputStream in = null;
        try {
            fin = new FileInputStream(fichero);
            in = new DataInputStream(fin);
            try { // Los datos se recuperan en el mismo orden en que se guardaron
                while (true) {
                    System.out.printf("Nombre: %s Cantidad: %d Crédito: %f \n", in.readUTF(), in.readInt(),
                            in.readFloat());
                }
            } catch (EOFException e) {
                System.out.println("Fin de fichero");
            }
        } finally {
            if (in != null)
                in.close();
            if (fin != null)
                fin.close();
        }
    }

    public void escribirObjeto(File fichero, ArrayList<Cliente> datos) throws IOException {
        FileOutputStream fos = null;
        ObjectOutputStream out = null;
        try {
            fos = new FileOutputStream(fichero);
            out = new ObjectOutputStream(fos);
            for (Cliente cl : datos) {

                out.writeObject(cl); // Se escribe el objeto de forma directa
            }
        } finally {
            if (out != null)
                out.close();
            if (fos != null)
                fos.close();
        }
    }

}
