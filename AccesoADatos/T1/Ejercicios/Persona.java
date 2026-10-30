
import java.io.Serializable;

public class Persona implements Serializable {
    private static final long serialVersionUID = 1L;

    private int codigo;
    private String nombre;
    private int edad;
    private int codDepart;

    public Persona(int codigo, String nombre, int edad, int codDepart) {
        this.codigo = codigo;
        this.nombre = nombre;
        this.edad = edad;
        this.codDepart = codDepart;
    }

    public int getCodigo() { return codigo; }
    public String getNombre() { return nombre; }
    public int getEdad() { return edad; }
    public int getCodDepart() { return codDepart; }
    public void setCodDepart(int codDepart) { this.codDepart = codDepart; }

    @Override
    public String toString() {
        return codigo + " - " + nombre + " - " + edad + " años - Departamento: " + codDepart;
    }
}