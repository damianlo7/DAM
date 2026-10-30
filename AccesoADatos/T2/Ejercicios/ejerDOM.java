import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.lang.annotation.Documented;
import java.util.ArrayList;
import java.util.List;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.w3c.dom.bootstrap.DOMImplementationRegistry;
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSOutput;
import org.w3c.dom.ls.LSSerializer;

/**
 * ejer1
 */
public class ejerDOM {
    private static final String ruta = "D:\\2026-27\\AccesoADatos\\T2\\Ejercicios\\Peliculas.xml";

    public Document ej1(String ruta) {
        Document doc = null;
        try {
            DocumentBuilderFactory factoria = DocumentBuilderFactory.newInstance();
            factoria.setIgnoringComments(true);
            DocumentBuilder builder = factoria.newDocumentBuilder();
            doc = builder.parse(ruta);
        } catch (Exception e) {
            System.out.println("Error generando el arbol DOM: " + e.getMessage());
        }
        return doc;
    }

    public void ej2() {
        Document doc = ej1(ruta);
        NodeList titulos;
        titulos = doc.getElementsByTagName("titulo");
        for (int i = 0; i < titulos.getLength(); i++) {
            System.out.println(titulos.item(i).getTextContent());
        }
    }

    public void ej3() {
        Document doc = ej1(ruta);
        NodeList peliculas = doc.getElementsByTagName("pelicula");

        for (int i = 0; i < peliculas.getLength(); i++) {
            Element pelicula = (Element) peliculas.item(i);
            String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();
            NodeList directores = pelicula.getElementsByTagName("director");
            for (int j = 0; j < directores.getLength(); j++) {
                Element director = (Element) directores.item(j);
                String nombre = director.getElementsByTagName("nombre").item(0).getTextContent();
                String apellido = director.getElementsByTagName("apellido").item(0).getTextContent();
                System.out.println("Titulo: " + titulo);
                System.out.println("Diretor: " + director + "Apellido: " + apellido);
            }
            System.out.println("Genero: " + pelicula.getAttribute("genero"));
        }

    }

    // public void ej4() {
    // Document doc = ej1(ruta);
    // NodeList peliculas = doc.getElementsByTagName("filmoteca");
    // for (int i = 0; i < peliculas.getLength(); i++) {
    // System.out.println("1" + peliculas);
    // String titulo =
    // peliculas.getElementsByTagName("titulo").item(i).getTextContent();
    // }
    // }

    public void ej5(int n) {
        Document doc = ej1(ruta);
        NodeList peliculas = doc.getElementsByTagName("pelicula");
        for (int i = 0; i < peliculas.getLength(); i++) {
            Element pelicula = (Element) peliculas.item(i);
            String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();
            NodeList directores = pelicula.getElementsByTagName("director");
            int cont = 0;
            //TODO SE PUEDE SIMPLIFICAR (NO HACE FALTA FOR)

            for (int j = 0; j < directores.getLength(); j++) {
                Element director = (Element) directores.item(j);
                String nombre = director.getElementsByTagName("nombre").item(0).getTextContent();
                String apellido = director.getElementsByTagName("apellido").item(0).getTextContent();
                cont++;

            }
            if (cont > n) {
                System.out.println("Titulo: " + titulo);
            }
        }
    }

    public void ej6() {
        Document doc = ej1(ruta);
        List<String> generos = new ArrayList<>();
        NodeList peliculas = doc.getElementsByTagName("pelicula");
        for (int i = 0; i < peliculas.getLength(); i++) {
            Element pelicula = (Element) peliculas.item(i);
            String genero = pelicula.getAttribute("genero");
            if (!generos.contains(genero)) {
                generos.add(genero);
            }

        }
        System.out.println("Hay " + generos.size() + " generos, son: ");
        for (String genero : generos) {
            System.out.println(genero);
        }
    }

    public void ej7a(String tituloPelicula, String atributo, String valor)
            throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        Document doc = ej1(ruta);
        NodeList titulos = doc.getElementsByTagName("titulo");
        boolean encontrada = false;
        for (int i = 0; i < titulos.getLength(); i++) {
            if (titulos.item(i).getTextContent().equals(tituloPelicula)) {
                encontrada = true;
                Element pelicula = (Element) titulos.item(i).getParentNode();
                if (pelicula.hasAttribute(atributo)) {
                    System.out.println("La pelicula ya tiene el atriuto");
                } else {
                    pelicula.setAttribute(atributo, valor);
                    System.out.println("Atributo: " + atributo + " engadido a " + tituloPelicula);
                    grabarDOM(doc, ruta);
                }
            }
        }
        if (!encontrada) {
            System.out.println("No existe la pelicula: " + tituloPelicula);
        }
    }

    public void ejer7b(String tituloPelicula, String atributo)
            throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        Document doc = ej1(ruta);
        NodeList titulos = doc.getElementsByTagName("titulo");
        boolean encontrada = false;
        for (int i = 0; i < titulos.getLength(); i++) {
            if (titulos.item(i).getTextContent().equals(tituloPelicula)) {
                encontrada = true;
                Element pelicula = (Element) titulos.item(i).getParentNode();
                if (pelicula.hasAttribute(atributo)) {
                    pelicula.removeAttribute(atributo);
                    grabarDOM(doc, ruta);
                } else {
                    System.out.println("No tiene ese atributo");
                }
            }
        }
        if (!encontrada) {
            System.out.println("La pelicula no existe");
        }
    }

    public void ejer8(String titulo, int anho, String director, String genero, String idioma) throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        Document doc = ej1(ruta);
        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");
        boolean peliculaAnhadida = false;
        for (int i = 0; i < listaPeliculas.getLength(); i++) {
            Node pelicula = listaPeliculas.item(i);
            NodeList nodosHijos = pelicula.getChildNodes();
            for (int j = 0; j < nodosHijos.getLength(); j++) {
                Node nodo = nodosHijos.item(j);
                if (nodo.getNodeName().equals("titulo") && nodo.getTextContent().equals(titulo)) {
                    peliculaAnhadida = true;
                    break;
                }
            }
            if (peliculaAnhadida) {
                break;
            }
        }
        if (!peliculaAnhadida) {
            Element nuevaPelicula = doc.createElement("pelicula");
            nuevaPelicula.setAttribute("año", String.valueOf(anho));
            nuevaPelicula.setAttribute("genero", genero);
            nuevaPelicula.setAttribute("idioma", idioma);

            Element nuevoTitulo = doc.createElement("titulo");
            nuevoTitulo.appendChild(doc.createTextNode(titulo));
            nuevaPelicula.appendChild(nuevoTitulo);

            Element nuevoDirector = doc.createElement("director");

            Element nombre = doc.createElement("nombre");
            nombre.appendChild(doc.createTextNode(director.split("")[0]));
            nuevoDirector.appendChild(nombre);

            Element apellido = doc.createElement("appellido");
            apellido.appendChild(doc.createTextNode(director.split("")[1]));
            nuevoDirector.appendChild(apellido);

            nuevaPelicula.appendChild(nuevoDirector);

            Node filmoteca = doc.getElementsByTagName("filmoteca").item(0);
            filmoteca.appendChild(nuevaPelicula);
            grabarDOM(doc, ruta);
            System.out.println("Pelicula añadida");

        }else{
            System.out.println("La pelicula ya existe");
        }
    }

    public static void grabarDOM(Document document, String ficheroSalida)
            throws ClassNotFoundException, InstantiationException,
            IllegalAccessException, FileNotFoundException {
        try {
            // Obtener la implementación DOM
            DOMImplementationRegistry registry = DOMImplementationRegistry.newInstance();
            DOMImplementationLS ls = (DOMImplementationLS) registry.getDOMImplementation("XML 3.0 LS 3.0");

            // Se crea un destino vacio
            LSOutput output = ls.createLSOutput();
            output.setEncoding("UTF-8");
            output.setByteStream(new FileOutputStream(ficheroSalida)); // Guardar en el archivo

            // Permite escribir un documento DOM en XML
            LSSerializer serializer = ls.createLSSerializer();
            // Se establecen las propiedades del serializador
            serializer.setNewLine("\r\n");
            serializer.getDomConfig().setParameter("format-pretty-print", true);

            // Se escribe el documento ya sea en un fichero o en una cadena de texto
            serializer.write(document, output);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}