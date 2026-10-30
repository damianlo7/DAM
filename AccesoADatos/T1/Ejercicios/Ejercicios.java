import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOError;
import java.io.IOException;
import java.io.InputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.nio.Buffer;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;
import java.util.Timer;

public class Ejercicios {

    Alumno a;

    public void ejer1(File nombreDirectorio) {
        System.out.println("DIRECTORIOS: ");
        for (int i = 0; i < nombreDirectorio.listFiles().length; i++) {

            if (nombreDirectorio.listFiles()[i].isDirectory()) {
                System.out.println(nombreDirectorio.listFiles()[i].getName());
            } else {
                System.out.println("ARCHIVOS: ");
                if (nombreDirectorio.listFiles()[i].isFile()) {
                    System.out.println(nombreDirectorio.listFiles()[i].getName());
                }
            }
        }
    }

    public void ejer2(File nombreDirectorio) {
        for (int i = 0; i < nombreDirectorio.listFiles().length; i++) {
            if (nombreDirectorio.listFiles()[i].isFile()) {
                System.out.println(nombreDirectorio.listFiles()[i].getPath());
            } else if (nombreDirectorio.listFiles()[i].isDirectory()) {
                System.out.println(nombreDirectorio.listFiles()[i]);
                ejer2(nombreDirectorio.listFiles()[i]);
            }
        }
    }

    public void ejer3(File nombreDirectorio, char caracter) {

        int cont = 0;
        if (nombreDirectorio.isFile()) {
            try (FileReader fr = new FileReader(nombreDirectorio)) {
                int i;
                while ((i = fr.read()) != -1) {
                    if ((char) i == caracter) {
                        cont++;
                    }
                }
            } catch (IOException e) {
                // TODO: handle exception
            }
        }
        System.out.println("Aparece: " + cont + " veces");
    }

    public void ejer4(File nombreDirectorio) {
        // int[] frecuencias = new int[256];
        int[] frecuencias = new int[65535];
        int i;
        try (FileReader fr = new FileReader(nombreDirectorio)) {
            while ((i = fr.read()) != -1) {
                if (i != ' ' && i != 10 && i != 13) {
                    frecuencias[i]++;
                }

            }
        } catch (Exception e) {
            System.out.println("Error");
        }

        int maxFrecuencia = 0;
        int caracterMasUsado = 0;

        for (int j = 0; j < frecuencias.length; j++) {
            if (frecuencias[j] > maxFrecuencia) {
                maxFrecuencia = frecuencias[j];
                caracterMasUsado = j;
            }
        }

        System.out.println("El caracter mas usado: " + (char) caracterMasUsado);

    }

    public void ejer4ConHashMap(File nombreDirectorio) {
        Map<Character, Integer> frecuencias = new HashMap<>();
        int i;

        try (FileReader fr = new FileReader(nombreDirectorio)) {
            while ((i = fr.read()) != -1) {
                if (i != ' ' && i != 10 && i != 13) {
                    frecuencias.merge((char) i, 1, Integer::sum);
                }
            }
        } catch (Exception e) {
            System.out.println("Error");
        }
        int maxFrecuencia = 0;
        char caracterMasUsado = 0;
        for (Map.Entry<Character, Integer> e : frecuencias.entrySet()) {
            if (e.getValue() > maxFrecuencia) {
                caracterMasUsado = e.getKey();
            }
        }
        System.out.println("El caracter mas usado: " + caracterMasUsado);
    }

    public void ejer5(File nombreDirectorio, String cadena) {
        int cont = 0;
        int aparece = 0;
        int i;
        String frase = cadena.toLowerCase();
        String linea;
        Scanner sc = new Scanner(System.in);

        // try (Scanner sc2 = new Scanner(new File(nombreDirectorio))){

        // } catch (Exception e) {
        // // TODO: handle exception
        // }

        try (BufferedReader br = new BufferedReader(new FileReader(nombreDirectorio))) {
            while ((linea = br.readLine()) != null) {
                cont++;
                String lineaMin = linea.toLowerCase();
                int pos = lineaMin.indexOf(frase);

                while (pos != -1) {
                    aparece++;
                    System.out.println("Aparece en la linea: " + cont);
                    pos = lineaMin.indexOf(frase, pos + 1);

                }

            }
            System.out.println("Aparece: " + aparece + " veces");
        } catch (Exception e) {
            System.out.println("Error");
        }
    }

    public void ejer6(File nombreDirectorio) throws IOException {

        Scanner sc = new Scanner(System.in);
        int opcion;
        int nCaracteres;
        int cLineas;
        System.out.println("Elige una opcion: ");
        System.out.println("1. Dividir fichero por numero de caracteres");
        System.out.println("2. Dividir fichero por numero de lineas");
        System.out.println("3. Unir ficheros");
        opcion = sc.nextInt();
        switch (opcion) {
            case 1: // dividir en caracteres
                System.out.println("Escribe la cantidad de caracteres que quieres por ficheros");
                nCaracteres = sc.nextInt();
                try (FileReader fr = new FileReader(nombreDirectorio)) {
                    char buffer[] = new char[nCaracteres];
                    int i = 1;
                    int numAr = 1;
                    while ((i = fr.read(buffer)) != -1) {
                        try (PrintWriter pw = new PrintWriter("ejer6Ar" + numAr + ".txt")) {
                            pw.print(new String(buffer, 0, i));
                        }
                        numAr++;
                    }
                }

                break;
            case 2: // dividir en lineas
                System.out.println("Escribe la cantidad de lineas: ");
                cLineas = sc.nextInt();
                int partes = 0;
                int contador = 0;
                PrintWriter pwFil = null;
                try (Scanner sc2 = new Scanner((nombreDirectorio))) {
                    while (sc2.hasNextLine()) {
                        String fila = sc2.nextLine();
                        if (contador == 0) {
                            partes++;
                            pwFil = new PrintWriter("pruebaLineas" + partes + ".txt");
                        }
                        pwFil.println(fila);
                        contador++;
                        if (contador == cLineas) {
                            pwFil.close();
                            contador = 0;
                        }

                    }
                    if (contador != 0) {
                        pwFil.close();
                    }
                }

                break;
            case 3:

                String[] fichero = { "pruebaLineas1.txt", "pruebaLineas2.txt", "pruebaLineas3.txt" };
                try (PrintWriter pw = new PrintWriter(new File("ficheroUnido.txt"))) {
                    for (String nombre : fichero) {
                        File f = new File(nombre);
                        if (f.exists()) {
                            try (FileReader fr = new FileReader(f)) {
                                char[] buffer = new char[1024];
                                int leidos;
                                while ((leidos = fr.read(buffer)) != -1) {
                                    pw.print(new String(buffer, 0, leidos));
                                }
                            }
                        } else {
                            System.out.println("El fichreo " + nombre + " no existe");
                        }
                    }
                    System.out.println("Ficheros unidos correctamente");
                } catch (IOException e) {
                    System.out.println("Error al unir los ficheros");
                }

                break;
            default:
                break;
        }
    }

    // public void ejer7(File nombreDirectorio, String operacion) {

    // System.out.println("Elige una opcion: ");
    // System.out.println("n - Contar numero lineas y palabras del archivo");
    // System.out.println("A- crear un nuevo archivo con las líneas del archivo
    // inicial ordenadas\r\n" + //
    // "forma ascendente");
    // System.out.println("D- ");
    // switch (operacion) {
    // case 'n':

    // break;
    // case 'A':

    // break;
    // case 'D':

    // break;
    // case 'a':

    // break;

    // break;

    // default:
    // break;
    // }
    // }

    // Copia archivos binarios sin buffer
    public void ejer8(File nombreDirectorio) throws IOException {
        try (FileInputStream in = new FileInputStream(nombreDirectorio);
                FileOutputStream out = new FileOutputStream(
                        "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\ficheroUnido.txt")) {
            int c;
            while ((c = in.read()) != -1) {
                out.write(c);
            }
        }
    }

    // Copia archivos binarios con buffer
    public void ejer8ConBuffer(File nombreDirectorio) throws IOException {
        try (FileInputStream fichIn = new FileInputStream(nombreDirectorio);
                FileOutputStream out = new FileOutputStream(
                        "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\ficheroUnido.txt")) {
            byte buffer[] = new byte[50];
            int leidos;
            while ((leidos = fichIn.read(buffer)) != -1) {
                out.write(buffer, 0, leidos);
                // System.out.println(new String(buffer, 0, leidos));
            }
        }

    }

    public void ejer9() throws IOException {
        Scanner sc = new Scanner(System.in);
        int option;
        int codigo;
        String nombre;
        double altura;
        do {

            System.out.println("Elige una opcion: ");
            System.out.println("1- Dar de alta a nuevo alumno");
            System.out.println("2- Consultar alumnos");
            System.out.println("3- Modificar alumnos");
            System.out.println("4- Borrar alumnos");
            System.out.println("5- Salir");
            option = sc.nextInt();
            sc.nextLine();
            switch (option) {
                case 1:
                    System.out.println("Introduce los datos del alumno: ");
                    System.out.println("Escribe el codigo del alumno: ");
                    codigo = Integer.parseInt(sc.nextLine());
                    System.out.println("Escribe el nombre del alumno");
                    nombre = sc.nextLine();
                    System.out.println("Escribe su altura: ");
                    altura = Double.parseDouble(sc.nextLine());

                    a = new Alumno(nombre, codigo, altura);
                    try (DataOutputStream out = new DataOutputStream(
                            new FileOutputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat", true))) {
                        out.writeInt(a.getCodigo());
                        out.writeUTF(a.getNombre());
                        out.writeDouble(a.getAltura());
                    }
                    break;
                case 2:
                    File f = new File("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat");
                    if (!f.exists() || f.length() == 0) {
                        System.out.println("No hay alumnos registrados");
                        break;
                    }

                    try (DataInputStream in = new DataInputStream(
                            new FileInputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat"))) {

                        while (true) {
                            codigo = in.readInt();
                            nombre = in.readUTF();
                            altura = in.readDouble();
                            System.out.printf("Codigo: %d Nombre: %s Altura: %.2f \n", codigo, nombre, altura);
                        }
                    } catch (EOFException e) {

                    }
                    break;

                case 3:
                    System.out.println("Escribe el codigo del alumno que quieres modificar");
                    codigo = Integer.parseInt(sc.nextLine());
                    System.out.println("Escribe el nuevo nombre: ");
                    nombre = sc.nextLine();
                    System.out.println("Escribe la nueva altura: ");
                    altura = Double.parseDouble(sc.nextLine());

                    boolean flag = false;
                    try (DataInputStream in = new DataInputStream(
                            new FileInputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat"));
                            DataOutputStream out = new DataOutputStream(
                                    new FileOutputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\temporal.dat"))) {
                        while (true) {
                            int c = in.readInt();
                            String n = in.readUTF();
                            double h = in.readDouble();
                            if (c == codigo) {
                                n = nombre;
                                h = altura;
                                flag = true;
                            }
                            out.writeInt(c);
                            out.writeUTF(n);
                            out.writeDouble(h);
                        }
                    } catch (EOFException e) {

                    }

                    if (flag) {
                        try (FileInputStream in2 = new FileInputStream(
                                "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\temporal.dat");
                                FileOutputStream out2 = new FileOutputStream(
                                        "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat")) {
                            byte[] buffer = new byte[1024];
                            int leidos;
                            while ((leidos = in2.read(buffer)) != -1) {
                                out2.write(buffer, 0, leidos);
                            }
                        }
                        System.out.println("Alumno modificado");

                    } else {
                        System.out.println("No se encontro al alumno");
                    }
                    break;
                case 4:
                    System.out.println("Escribe el codigo del alumno que quieres eliminar:");
                    int codBorrar = Integer.parseInt(sc.nextLine());
                    flag = false;
                    try (DataInputStream in = new DataInputStream(
                            new FileInputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat"));
                            DataOutputStream out = new DataOutputStream(
                                    new FileOutputStream("D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\temporal.dat"))) {

                        while (true) {
                            int c = in.readInt();
                            String n = in.readUTF();
                            double h = in.readDouble();
                            if (c == codBorrar) {
                                flag = true;
                                continue;
                            }
                            out.writeInt(c);
                            out.writeUTF(n);
                            out.writeDouble(h);
                        }
                    } catch (EOFException e) {
                        // TODO: handle exception
                    }
                    if (flag) {
                        try (FileInputStream in2 = new FileInputStream(
                                "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\temporal.dat");
                                FileOutputStream out2 = new FileOutputStream(
                                        "D:\\2026-27\\AccesoADatos\\T1\\Ejercicios\\alumnos.dat")) {
                            byte[] buffer = new byte[1024];
                            int leidos;
                            while ((leidos = in2.read(buffer)) != -1) {
                                out2.write(buffer, 0, leidos);
                            }
                        }
                        System.out.println("Alumno borrado");
                    } else {
                        System.out.println("No se encontro al alumno");
                    }
                    break;
                case 5:
                    System.out.println("Hasta luego");
                    break;

                default:
                    break;
            }
        } while (option != 5);
    }

    public void ejer10(File fichero) throws IOException {
        Scanner sc = new Scanner(System.in);
        int opcion;
        do {
            List<Persona> personas = new ArrayList<>();
            List<Depart> departs = new ArrayList<>();
            cargar(fichero, personas, departs);

            System.out.println("\n--- MENU ---");
            System.out.println("1- Alta de persona");
            System.out.println("2- Alta de departamento");
            System.out.println("3- Consultar personas");
            System.out.println("4- Consultar departamentos");
            System.out.println("5- Borrar persona");
            System.out.println("6- Borrar departamento");
            System.out.println("7- Salir");
            opcion = leerEntero(sc, "Opcion: ");

            switch (opcion) {
                case 1: {
                    int codigo = leerEntero(sc, "Codigo de la persona: ");
                    boolean repetido = false;
                    for (Persona p : personas) {
                        if (p.getCodigo() == codigo) {
                            repetido = true;
                        }
                    }
                    if (repetido) {
                        System.out.println("Ya existe una persona con ese codigo");
                        break;
                    }
                    System.out.print("Nombre: ");
                    String nombre = sc.nextLine();
                    int edad = leerEntero(sc, "Edad: ");
                    int codDep = leerEntero(sc, "Codigo de departamento: ");

                    boolean depExiste = false;
                    for (Depart d : departs) {
                        if (d.getCodigo() == codDep) {
                            depExiste = true;
                        }

                    }
                    if (!depExiste) {
                        System.out.println("El departamento no existe. Da de alta primero el departamento");
                        break;
                    }
                    personas.add(new Persona(codigo, nombre, edad, codDep));
                    guardar(fichero, personas, departs);
                    System.out.println("Persona dada de alta");
                    break;
                }
                case 2: {
                    int codigo = leerEntero(sc, "Codigo del departamento: ");
                    boolean repetido = false;
                    for (Depart d : departs) {
                        if (d.getCodigo() == codigo) {
                            repetido = true;
                        }

                    }
                    if (repetido) {
                        System.out.println("Ya existe un departamento con ese codigo");
                        break;
                    }
                    System.out.print("Nombre del departamento: ");
                    String nombre = sc.nextLine();
                    departs.add(new Depart(codigo, nombre));
                    guardar(fichero, personas, departs);
                    System.out.println("Departamento dado de alta");
                    break;
                }
                case 3: {
                    if (personas.isEmpty()) {
                        System.out.println("No hay personas registradas");
                    }
                    for (Persona p : personas) {
                        System.out.println(p);
                    }
                    break;
                }
                case 4: {
                    if (departs.isEmpty()) {
                        System.out.println("No hay departamentos registrados");
                    }
                    for (Depart d : departs) {
                        int cont = 0;
                        for (Persona p : personas) {
                            if (p.getCodDepart() == d.getCodigo()) {
                                cont++;
                            }

                        }
                        System.out.println(d + " (" + cont + " personas)");
                    }
                    break;
                }
                case 5: {
                    int codigo = leerEntero(sc, "Codigo de la persona a borrar: ");
                    boolean borrada = false;
                    for (int i = 0; i < personas.size(); i++) {
                        if (personas.get(i).getCodigo() == codigo) {
                            personas.remove(i);
                            borrada = true;
                            break;
                        }
                    }
                    if (borrada) {
                        guardar(fichero, personas, departs);
                        System.out.println("Persona borrada");
                    } else {
                        System.out.println("No se encontro a la persona");
                    }
                    break;
                }
                case 6: {
                    int codigo = leerEntero(sc, "Codigo del departamento a borrar: ");
                    boolean enUso = false;
                    for (Persona p : personas) {
                        if (p.getCodDepart() == codigo) {
                            enUso = true;
                        }

                    }
                    if (enUso) {
                        System.out.println("No se puede borrar: hay personas en ese departamento");
                        break;
                    }
                    boolean borrado = false;
                    for (int i = 0; i < departs.size(); i++) {
                        if (departs.get(i).getCodigo() == codigo) {
                            departs.remove(i);
                            borrado = true;
                            break;
                        }
                    }
                    if (borrado) {
                        guardar(fichero, personas, departs);
                        System.out.println("Departamento borrado");
                    } else {
                        System.out.println("No se encontro el departamento");
                    }
                    break;
                }
                case 7:
                    System.out.println("Hasta luego");
                    break;
                default:
                    System.out.println("Opcion no valida");
            }
        } while (opcion != 7);
    }

    private void cargar(File fichero, List<Persona> personas, List<Depart> departs) throws IOException {
        if (!fichero.exists() || fichero.length() == 0) {
            return;
        }
        try (ObjectInputStream in = new ObjectInputStream(new FileInputStream(fichero))) {
            while (true) {
                Object o = in.readObject();
                if (o instanceof Persona) {
                    personas.add((Persona) o);
                } else if (o instanceof Depart) {
                    departs.add((Depart) o);
                }
            }
        } catch (EOFException e) {
        } catch (ClassNotFoundException e) {
            throw new IOException("Clase no encontrada", e);
        }
    }

    private void guardar(File fichero, List<Persona> personas, List<Depart> departs) throws IOException {
        try (ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream(fichero))) {
            for (Depart d : departs) {
                out.writeObject(d);
            }
            for (Persona p : personas) {
                out.writeObject(p);
            }
        }
    }

    private int leerEntero(Scanner sc, String mensaje) {
        while (true) {
            System.out.print(mensaje);
            try {
                return Integer.parseInt(sc.nextLine().trim());
            } catch (NumberFormatException e) {
                System.out.println("Introduce un numero valido");
            }
        }
    }

    // sin acabar
    public void ejer11(File archivo) throws FileNotFoundException {
        int[] tamanhosBuffer = { 10, 100, 1000 };
        long inicio = System.nanoTime();

        try (BufferedInputStream in = new BufferedInputStream(new FileInputStream("prueba100MB.txt"));
                BufferedOutputStream out = new BufferedOutputStream(
                        new FileOutputStream("copia_buffered_" + tam + ".txt"))) {

            int bytesLeidos;
            while ((bytesLeidos = in.read()) != -1) {
                out.write(bytesLeidos);
            }

        } catch (IOException e) {
            // TODO: handle exception
        }
        
        long fin1 = System.nanoTime();
        System.out.println("Buffered con buffer " + tam + " tarda: " + (fin1 - inicio1) / 1_000_000 + " ms");

        for (int tam : tamanhosBuffer) {
            long inicio2 = System.nanoTime();
            try (FileInputStream in = new FileInputStream("prueba100MB.txt");
                    FileOutputStream out = new FileOutputStream("copia_file_" + tam + ".txt")) {

                byte[] buffer = new byte[tam];
                int bytesLeidos;
                while ((bytesLeidos = in.read(buffer)) != -1) {
                    out.write(buffer, 0, bytesLeidos);
                }

            } catch (IOException e) {
                // TODO: handle exception
            }
            long fin2 = System.nanoTime();
            System.out.println("File con buffer " + tam + " tarda: " + (fin2 - inicio2) / 1_000_000 + " ms");
        }

    }
}