package com.jsclase.Models;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
@JsonIgnoreProperties 
public class PaisDto {
    @JsonProperty("país")
    private String pais;
    
    @JsonProperty("población")
    private long poblacion;
    private List<String> animales;
    private boolean visado;

    public String getPais() {
        return pais;
    }

    public void setPais(String pais) {
        this.pais = pais;
    }

    public long getPoblacion() {
        return poblacion;
    }

    public void setPoblacion(long poblacion) {
        this.poblacion = poblacion;
    }

    public List<String> getAnimales() {
        return animales;
    }

    public void setAnimales(List<String> animales) {
        this.animales = animales;
    }

    public boolean isVisado() {
        return visado;
    }

    public void setVisado(boolean visado) {
        this.visado = visado;
    }

}
