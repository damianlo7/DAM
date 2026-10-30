package ejer1;

import java.io.File;
import java.io.InputStream;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;
import java.time.LocalDate;
import java.util.Scanner;

import com.fasterxml.jackson.databind.ObjectMapper;

/**
 * GestionFrankfurter
 */
public class GestionFrankfurter {
    Scanner sc = new Scanner(System.in);

    public void cambioDivisa(ExchangeDto[] datos) {
        String div1;
        String div2;

        System.out.println("Escribe la primera divisa: ");
        div1 = sc.nextLine();
        System.out.println("Escribe la segunda divisa: ");
        div2 = sc.nextLine();

        try {
            double cambio = buscarRate(datos, div2) / buscarRate(datos, div1);
            System.out.println("1 " + div1 + " = " + cambio + " " + div2);
        } catch (Exception e) {
            System.out.println("Error: " + e);
        }

    }

    public void suma(ExchangeDto[] datos) {
        Double cant1;
        String cod1;
        String cod2;

        System.out.println("Escribe la cantidad: ");
        cant1 = sc.nextDouble();
        sc.nextLine();

        System.out.println("Escribe el codigo de su divisa: ");
        cod1 = sc.nextLine();
        System.out.println("Escribe el codigo de la divisa a la que lo quieres convertir");
        cod2 = sc.nextLine();
        try {
            double cambio = buscarRate(datos, cod2) / buscarRate(datos, cod1);
            System.out.println(cant1 * cambio);
        } catch (Exception e) {
            System.out.println("Error: " + e);
        }
    }

    // public void guardarEvolucion() {
    //     String div1;
    //     String div2;
    //     String nAnhos;

    //     System.out.println("Escribe el coodigo de la divisa 1: ");
    //     div1 = sc.nextLine();

    //     System.out.println("Escribe el codigo de la divisa 2: ");
    //     div2 = sc.nextLine();

    //     System.out.println("Escribe cuantos años atras quieres ir: ");
    //     nAnhos = sc.nextLine();

    //     try {
    //         int anios = Integer.parseInt(nAnhos);
    //         LocalDate fechaFin = LocalDate.now();
    //         LocalDate fechaInicio = fechaFin.minusYears(anios);

    //         String urlStr = String.format("", null)
    //     } catch (Exception e) {
    //         // TODO: handle exception
    //     }
    // }

    public Double buscarRate(ExchangeDto[] datos, String divisa) {
        for (ExchangeDto exchange : datos) {
            if (exchange.quote().equals(divisa)) {
                return exchange.rate();
            }
        }
        throw new IllegalArgumentException("Divisa no encontrada" + divisa);
    }

    public static void main(String[] args) throws URISyntaxException {
        URI frankfurteUrl = new URI("https://api.frankfurter.dev/v2/rates?base=EUR");

        try {
            ObjectMapper mapper = JsonTools.getMapper();
            URI frankfurterUrl = new URI("https://api.frankfurter.dev/v2/rates?base=EUR");
            try (InputStream inputStream = frankfurteUrl.toURL().openStream()) {
                ExchangeDto[] datos = mapper.readValue(inputStream, ExchangeDto[].class);

                GestionFrankfurter gestion = new GestionFrankfurter();
                // gestion.cambioDivisa(datos);
                gestion.suma(datos);
            }
        } catch (Exception e) {
            System.out.println("error: " + e);
        }
    }

}