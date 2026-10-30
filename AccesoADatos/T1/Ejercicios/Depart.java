import java.io.Serializable;

public class Depart implements Serializable {
    private static final long serialVersionUID = 1L;

    private int codigo;
    private String nombre;

    public Depart(int codigo, String nombre) {
        this.codigo = codigo;
        this.nombre = nombre;
    }

    public int getCodigo() { return codigo; }
    public String getNombre() { return nombre; }
    public void setCodigo(int codigo) { this.codigo = codigo; }
    public void setNombre(String nombre) { this.nombre = nombre; }

    @Override
    public String toString() {
        return "Departamento " + codigo + " - " + nombre;
    }
}