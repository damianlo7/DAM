public class Alumno {
    private String nombre;
    private int codigo;
    private double altura;

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public Alumno(String nombre, int codigo, double altura) {
        this.nombre = nombre;
        this.altura = altura;
        this.codigo = codigo;
        // super();
    }


}
