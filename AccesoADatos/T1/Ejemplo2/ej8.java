import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URL;

public class ej8 {

    public static void main(String[] args) throws MalformedURLException, IOException {
        // InputStream is = new URL("https://www.youtube.com/watch?v=H19fL7Xz32M").openStream();
        // InputStream is = new URL("https://www.carmodel.com/autoart/75989/1-18/mazda/rx-7-fd-spirit-r-type-a-coupe-2-door-2002/71325?srsltid=AU7gw4Wy11lGSAxuYDFIJ1y61vi4zgRfSMmI2zZRUJCZ4t9ALQVEckDM").openStream();
        InputStream is = new URL("https://upload.wikimedia.org/wikipedia/commons/4/47/PNG_transparency_demonstration_1.png?utm_source=es.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled").openStream();
        // FileOutputStream fout = new FileOutputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejemplo2\\descargas\\nombre.mp3");
        FileOutputStream fout = new FileOutputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejemplo2\\descargas\\img.png");
        int i;
        byte[] buffer = new byte[1000];
        while ((i = is.read(buffer)) != -1) {
            fout.write(buffer, 0, i);
        }
        fout.close();
        is.close();
    }
}