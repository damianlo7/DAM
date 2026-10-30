import javax.swing.text.Document;
import javax.swing.text.html.parser.Element;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

/**
 * XmlDom
 */
public class XmlDom {

    private static final String ruta = "D:\\2026-27\\AccesoADatos\\T2\\Apuntes\\Peliculas.xml";

    public static void main(String[] args) throws Exception {
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        factory.setIgnoringComments(true);

        DocumentBuilder documentBuilder = factory.newDocumentBuilder();
        Document doc = documentBuilder.parse(ruta);

        Node peliculasNode = doc.getFirstChild();
        NodeList peliculas = peliculasNode.getChildNodes();
        for (int i = 0; i < peliculas.getLength; i++) {
            Node peliculaNodo = peliculas.item(i);
            int tipoNodo = peliculaNodo.getNodeType();
            if (tipoNodo != Node.ELEMENT_NODE)
                continue;

            Element peliculaElement = (Element)peliculaNodo;
            string nombreNodo = peliculaElement.getNodeName();
            String genero = peliculaNodo.getAttribute("genero");
            System.out.println("Tipo nodo: "+nombreNodo);
            System.out.println("Genero: "+genero);

            NodeList informaciones = peliculaElement.getChildNodes();
            for (int j = 0; j < informaciones.getLength(); j++) {
                Node infoNodo = informaciones.item(j);

                //ignorar nodos texto
                if (infoNodo.getNodeType() != Node.ELEMENT_NODE) 
                    continue;
                String nombreInfo = infoNodo.getNodeName();
                System.out.println("Informacion "+nombreInfo);

                Node nodoTexto = infoNodo.getFirstChild();
                String valor = nodoTexto.getNodeValue();
                System.out.println("Informacion: " + nombreInfo + " Valor: "+valor);
            }

            
            // switch (tipoNodo) {
            // case Node.ELEMENT_NODE:
            // System.out.println("Encontrado nodo Elemento");
            // break;
            // case Node.TEXT_NODE:
            // System.out.println("Encontrado nodo texto");
            // break;

            // default:
            // break;
            // }

        }

        // int cuentaNodosPeliculas = peliculas.getLength();
        // System.out.println("");
        NodeList listaTitulos = doc.getElementsByTagName("Titulo");
        int cuenta = listaTitulos.getLength();
        for (int i = 0; i < listaTitulos.getLength(); i++) {
            Node tituloNode = listaTitulos.item(i);
            int tipoNodo = tituloNode.getNodeType();
            if (tipoNodo != Node.ELEMENT_NODE) {
                
            } 
        }
    }

}