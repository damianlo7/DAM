package com.jsclase.Tools;

import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.ObjectMapper;

public class JsonTools {
    private static ObjectMapper mapper;

    public static ObjectMapper getMapper() {
        if (mapper != null)
            return mapper;
        mapper = new ObjectMapper();
        // Configura para ignorar propiedades desconocidas de forma global.
        mapper.disable(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES);
        // Otras configuraciones.
        return mapper;
    }
}