// Fig.5.6: PruebaLibroCalificaciones.cs
// Crea el objeto LibroCalificaciones e invoca a su metodo DeterminarPromedio 
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        // crea el objeto miLibroCalificaciones de LibroCalificaciones y 
        // pasa el nombre del curso al constructor
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introduccion a la Programacion en C#");

        miLibroCalificaciones.mostrarMensaje(); // muestra el mensaje de bienvenida
        miLibroCalificaciones.DeterminarPromedioClase(); // determina el promedio de la clase
    } // fin de Main
} // fin de la clase PruebaLibroCalificaciones
