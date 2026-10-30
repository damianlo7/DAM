package com.jsclase;

import java.io.File;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.jsclase.Tools.JsonTools;

/**
 * Hello world!
 */
public final class App {
    private App() {
    }

    /**
     * Says hello to the world.
     * @param args The arguments of the program.
     */
    public static void main(String[] args) throws Exception{
        System.out.println("Hello World!");

        ObjectMapper mapper = JsonTools.createMapper();

        File archivosPaises = new File("src/resoucers/pasises.json");
        PaisDto[]paises = mapper.readValue(archivosPaises, PaisDto[].class);
        
        for (PaisDto paisDto : paises) {
            System.out.println("Pais: "+ paisDto);
        }

        paises[0].setPais("españa");
        File 
    }
}
