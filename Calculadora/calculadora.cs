namespace EspacioCalculadora{

public class Calculadora
{
    private double dato;

    public Calculadora(double datoParametro = 0)
    {
        dato = datoParametro;
    }

    public void Sumar(double termino)
    {
        dato+=termino;
    }
    public double GetResultado()
    {
        return dato;
    }
    public void Restar (double termino)
    {
        dato-=termino;
    }
    public void Multiplicar (double termino)
    {
        dato*=termino;
    }
    public void Dividir (double termino)
    {
        if (termino != 0) dato = dato/termino;
        
    }
    public void Limpiar ()
    {

    }
}
}
