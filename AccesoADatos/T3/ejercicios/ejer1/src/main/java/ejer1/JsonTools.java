package ejer1;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.ObjectMapper;

public class JsonTools {
    private static ObjectMapper mapper;
    public static ObjectMapper getMapper(){
        if (mapper != null) {
            return mapper;
        }
        mapper = new ObjectMapper();
        mapper.disable(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES);

        return mapper;
    }
}
