using EjecutarPractico;
internal class Program
{
    private static void Main(string[] args)
    {
        int practico = FuncionesComunes.Leer("Ingrese el practico que desea ejecutar: ");
        FuncionesComunes.EjecutarPractico(practico);
    }
}