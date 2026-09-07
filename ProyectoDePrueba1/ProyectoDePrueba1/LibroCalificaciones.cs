using System;
using System.Collections.Generic;
using System.Text;
//Fig. 5.5 LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase
// utilizando la repeticion controlada por contador.


public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones
   
    // el constructor inicializa nombreCurso
    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
    } // fin del constructor

    // propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get
        {
            return nombreCurso; 
        } // fin de get
        set
        {
            nombreCurso = value; // set deberia validar
        } // fin de set
    } // fin de la propiedad NombreCurso

    // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    public void mostrarMensaje()
    {
        // la propiedad nombreCurso obtine el nombre del curso.
        Console.WriteLine("Bienvenido al libro de calificaciones de\n{0}!\n",
            nombreCurso);
    } // fin del metodo mostrarMensaje

    // determina el promedio de la clase con base en las 10 calificaciones introducidas por el usuario
    public void DeterminarPromedioClase()
    {
        // inicializa el valor acumulado, el contador y la calificacion
        int total; // suma de las calificaciones introducidas por el usuario
        int calificacion; // calificacion actual
        int contadorCalif; // numero de calificaciones introducidas
        int promedio; // promedio de las calificaciones

        // fase de inicializacion
        total = 0; // establece el valor inicial de total
        contadorCalif = 1; // inicializa el contador del ciclo

        // fase de procesamiento
        // solicita entrada y obtiene 10 calificaciones del usuario
        while (contadorCalif <= 10) // itera 10 veces
        {
            Console.Write("Escriba la calificacion: "); //mensaje para el usuario
            calificacion = Convert.ToInt32(Console.ReadLine()); //lee calificacion
            total = total + calificacion; // suma la calificacion a total
            contadorCalif = contadorCalif + 1; // incrementa el contador en 1
        } // fin de while

        // fase de terminacion
        promedio = total / 10; // division entera produce resultado entero
            Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
            Console.WriteLine("El promedio de la clase es {0}", promedio);
    } // fin del metodo DeterminarPromedioClase
} // fin de la clase LibroCalificaciones