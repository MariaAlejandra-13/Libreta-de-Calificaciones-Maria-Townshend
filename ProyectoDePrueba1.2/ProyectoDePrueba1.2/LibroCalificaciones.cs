using System;
using System.Collections.Generic;
using System.Text;

// Fig. 5.7: LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase usando la repeticion controlada por un centinela.

public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso para este LibroCalificaciones
    
    // constructor que inicializa nombreCurso con un argumento String
    public LibroCalificaciones(string nombre)
    {
        nombreCurso = nombre; // inicializa nombreCurso
    } // fin del constructor de LibroCalificaciones

    // propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get 
        { 
            return nombreCurso; 
        } // fin de get
        set 
        { 
            nombreCurso = value;
        } // fin de set
    } // fin de la propiedad NombreCurso

    // muestra un mensaje de bienvenida al usuario de LibroCalificaciones
    public void mostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!\n",
            NombreCurso);
    } // fin del metodo mostrarMensaje

    // determina el promedio de un numero arbitrario de calificaciones
    public void DeterminarPromedioClase()
    {
        int total; // suma de las calificaciones
        int contadorCalif; // numero de calificaciones introducidas 
        int calificacion; // valor de la calificacion
        double promedio; // numero con punto decimal para el promedio

        // fase de inicializacion
        total = 0; // inicializa total
        contadorCalif = 0; // inicializa contador de ciclo

        // fase de procesamiento
        // mensaje para recibir como entrada la calificacion del usuario
        Console.WriteLine("Escriba calificacion o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        // itera hasta que se lee el valor centinela del usuario
        while (calificacion != -1)
        {
            total = total + calificacion; // suma calificacion a total
            contadorCalif = contadorCalif + 1; // incrementa el contador

            // mensaje para recibir como entrada la siguiente calificacion del usuario
            Console.Write("Escriba calificacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        } // fin de while

        //fase de terminacion
        // si el usuario introdujo al menos una calificacion...
        if (contadorCalif != 0)
        {
            // calcula el promedio de todas las calificaciones introducidas 
            promedio = (double)total / contadorCalif;

            // muestra el total y el promedio (con dos digitos de precision)
            Console.WriteLine("\nEl total de las {0} calificaciones es {1}",
                contadorCalif, total);
            Console.WriteLine("El promedio de la clase es {0:F}\n",
                promedio);
        } // fin de if
        else // no se introdujeron calificaciones, entonces mostrar mensaje de error
            Console.WriteLine("No se introdujeron calificaciones");
    } // fin del metodo DeterminarPromedioClase
} // fin de la clase LibroCalificaciones