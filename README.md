# Universidad Tecnológica de Panamá

# Facultad de Ingeniería de Sistemas Computacionales

## Libreta de Calificaciones - Estructuras de Repetición en C#

### Herramientas de Programación Aplicada III

## Fecha de Ejecución:

7 de septiembre de 2026

---

## Objetivos

* Aplicar estructuras de repetición `while` en programas desarrollados en C#.
* Comprender el funcionamiento de la repetición controlada por contador.
* Comprender el funcionamiento de la repetición controlada por centinela.
* Utilizar variables acumuladoras y contadoras para procesar datos.
* Crear clases y objetos para organizar la lógica de una aplicación.
* Utilizar propiedades `get` y `set` para acceder a los atributos de una clase.
* Calcular el total y promedio de las calificaciones introducidas por el usuario.
* Aplicar conversiones de datos mediante `Convert.ToInt32()`.
* Utilizar estructuras condicionales para controlar la presentación de resultados.
* Desarrollar aplicaciones de consola utilizando C# y .NET.

---

## Introducción

C# permite desarrollar aplicaciones utilizando diferentes estructuras de control que facilitan la ejecución repetitiva de instrucciones. Entre estas estructuras se encuentra el ciclo `while`, el cual ejecuta un bloque de instrucciones mientras una determinada condición sea verdadera.

En esta práctica se desarrollaron dos programas de **Libreta de Calificaciones**. Ambos programas permiten introducir calificaciones y calcular el total y el promedio de una clase, pero utilizan métodos diferentes para controlar la repetición.

El primer problema utiliza una **repetición controlada por contador**, en la cual el programa solicita exactamente diez calificaciones antes de realizar los cálculos.

El segundo problema utiliza una **repetición controlada por centinela**, permitiendo introducir una cantidad variable de calificaciones. En este caso, el valor `-1` funciona como centinela para indicar que el usuario ha terminado de ingresar datos.

Estas actividades permiten comprender la diferencia entre los ciclos que conocen previamente la cantidad de repeticiones que deben realizarse y aquellos cuya cantidad de repeticiones depende directamente de las entradas realizadas por el usuario.

---

## Requisitos Previos

Para desarrollar y ejecutar estos programas se requiere contar con el siguiente entorno:

### Tecnologías utilizadas

* **Lenguaje de programación:** C#
* **Framework:** .NET 10.0
* **Tipo de aplicación:** Aplicación de consola
* **Entorno de desarrollo:** Visual Studio Community 2026
* **Control de versiones:** Git
* **Repositorio:** GitHub

### Sistema Operativo

* Windows 10 / Windows 11

---

# Contenido del Repositorio

Este repositorio contiene dos proyectos relacionados con el cálculo del promedio de calificaciones utilizando diferentes métodos de repetición.

Los proyectos incluidos son:

1. **ProyectoDePrueba1:** cálculo del promedio de exactamente 10 calificaciones mediante repetición controlada por contador.
2. **ProyectoDePrueba1.2:** cálculo del promedio de una cantidad variable de calificaciones mediante repetición controlada por centinela.

Cada proyecto contiene principalmente los siguientes archivos:

* `Program.cs`
* `LibroCalificaciones.cs`
* Archivo del proyecto `.csproj`

---

# Problema #1 - Libreta de Calificaciones con Repetición Controlada por Contador

## Descripción

El primer programa consiste en una aplicación de consola que permite introducir exactamente **10 calificaciones**.

Para controlar la cantidad de calificaciones introducidas se utiliza un ciclo `while` junto con una variable contador.

La aplicación crea inicialmente un objeto de la clase `LibroCalificaciones` y le proporciona el nombre del curso:

```text
CS101 Introduccion a la Programacion en C#
```

Posteriormente se muestra un mensaje de bienvenida y se ejecuta el método encargado de solicitar las diez calificaciones y calcular el promedio.

---

## Clase `LibroCalificaciones`

La clase `LibroCalificaciones` contiene la lógica principal del programa.

Dentro de ella se utiliza la variable privada:

```csharp
private string nombreCurso;
```

Esta variable permite almacenar el nombre del curso relacionado con la libreta de calificaciones.

El valor es recibido mediante el constructor de la clase.

```csharp
public LibroCalificaciones(string nombre)
{
    NombreCurso = nombre;
}
```

---

## Propiedad `NombreCurso`

Para obtener y modificar el nombre del curso se utiliza una propiedad con métodos `get` y `set`.

```csharp
public string NombreCurso
{
    get
    {
        return nombreCurso;
    }

    set
    {
        nombreCurso = value;
    }
}
```

El método `get` devuelve el valor almacenado.

El método `set` permite asignar un nuevo valor utilizando `value`.

---

## Mensaje de Bienvenida

El método:

```csharp
mostrarMensaje()
```

presenta en pantalla un mensaje indicando el curso correspondiente a la libreta de calificaciones.

Por ejemplo:

```text
Bienvenido al libro de calificaciones de
CS101 Introduccion a la Programacion en C#!
```

---

## Determinación del Promedio

El cálculo se realiza mediante el método:

```csharp
DeterminarPromedioClase()
```

Dentro del método se utilizan cuatro variables principales:

```csharp
int total;
int calificacion;
int contadorCalif;
int promedio;
```

### Función de cada variable

| Variable        | Función                                            |
| --------------- | -------------------------------------------------- |
| `total`         | Almacena la suma de todas las calificaciones       |
| `calificacion`  | Almacena la calificación introducida actualmente   |
| `contadorCalif` | Controla cuántas calificaciones se han introducido |
| `promedio`      | Almacena el promedio final de las calificaciones   |

---

## Inicialización

Antes de comenzar el ciclo se inicializan las variables:

```csharp
total = 0;
contadorCalif = 1;
```

El acumulador `total` comienza en cero debido a que inicialmente no se ha introducido ninguna calificación.

El contador comienza en `1` debido a que se van a solicitar exactamente diez calificaciones.

---

## Repetición Controlada por Contador

La estructura principal utilizada es:

```csharp
while (contadorCalif <= 10)
```

Esto significa que las instrucciones incluidas dentro del ciclo se ejecutarán mientras el contador sea menor o igual a 10.

Dentro del ciclo se solicita una calificación:

```csharp
Console.Write("Escriba la calificacion: ");
```

Posteriormente se lee el dato y se convierte a un número entero:

```csharp
calificacion = Convert.ToInt32(Console.ReadLine());
```

Después se agrega la calificación al acumulador:

```csharp
total = total + calificacion;
```

Finalmente se incrementa el contador:

```csharp
contadorCalif = contadorCalif + 1;
```

Este procedimiento se repite hasta completar las diez calificaciones.

---

## Fórmula Utilizada

Una vez finalizado el ciclo, el programa calcula el promedio mediante:

```text
Promedio = Total de Calificaciones / 10
```

En el programa:

```csharp
promedio = total / 10;
```

---

## Ejemplo de Funcionamiento

Si el usuario introduce las siguientes calificaciones:

```text
80
90
75
100
85
95
70
88
92
85
```

El total sería:

```text
860
```

El promedio sería:

```text
86
```

Por lo tanto, el programa presenta:

```text
El total de las 10 calificaciones es 860
El promedio de la clase es 86
```

---

## Elementos de C# utilizados

En este problema se utilizaron:

* Clases.
* Objetos.
* Constructores.
* Propiedades.
* Métodos `get` y `set`.
* Variables de tipo `int`.
* Método `Console.Write()`.
* Método `Console.WriteLine()`.
* Método `Console.ReadLine()`.
* Método `Convert.ToInt32()`.
* Estructura repetitiva `while`.
* Operadores de comparación.
* Operadores aritméticos.
* Variables contadoras.
* Variables acumuladoras.

---

## Resultado - Problema #1


<img width="356" height="266" alt="image" src="https://github.com/user-attachments/assets/1c9fa7b9-8f95-446a-95f9-b321b762b90a" />


---

# Problema #2 - Libreta de Calificaciones con Repetición Controlada por Centinela

## Descripción

El segundo programa utiliza nuevamente una clase denominada `LibroCalificaciones`, pero modifica la manera en la que se controla la cantidad de calificaciones introducidas.

En este caso no es necesario introducir exactamente diez calificaciones.

El usuario puede introducir **cualquier cantidad de calificaciones** y utilizar el valor:

```text
-1
```

para indicar que ha terminado.

Este valor se conoce como **valor centinela**.

---

## Repetición Controlada por Centinela

A diferencia del primer problema, el programa no conoce previamente cuántas calificaciones serán introducidas.

Antes de iniciar el ciclo se solicita la primera calificación:

```csharp
Console.WriteLine("Escriba calificacion o -1 para salir: ");
calificacion = Convert.ToInt32(Console.ReadLine());
```

Posteriormente se utiliza la condición:

```csharp
while (calificacion != -1)
```

Esto significa que el ciclo continuará ejecutándose mientras la calificación introducida sea diferente de `-1`.

---

## Variables Utilizadas

Dentro del método `DeterminarPromedioClase()` se utilizan las siguientes variables:

```csharp
int total;
int contadorCalif;
int calificacion;
double promedio;
```

### Función de cada variable

| Variable        | Función                                           |
| --------------- | ------------------------------------------------- |
| `total`         | Acumula la suma de las calificaciones             |
| `contadorCalif` | Cuenta cuántas calificaciones fueron introducidas |
| `calificacion`  | Almacena la calificación actual                   |
| `promedio`      | Almacena el promedio calculado                    |

En este problema el promedio se declara como `double`, permitiendo obtener resultados que contengan decimales.

---

## Inicialización

Antes de iniciar la repetición se establecen los valores:

```csharp
total = 0;
contadorCalif = 0;
```

En este caso el contador comienza en cero debido a que todavía no se ha procesado ninguna calificación.

---

## Procesamiento de las Calificaciones

Mientras el valor introducido sea diferente de `-1`, el programa agrega la calificación al total:

```csharp
total = total + calificacion;
```

Posteriormente incrementa el contador:

```csharp
contadorCalif = contadorCalif + 1;
```

Luego solicita la siguiente calificación:

```csharp
Console.Write("Escriba calificacion o -1 para salir: ");
calificacion = Convert.ToInt32(Console.ReadLine());
```

Este proceso continúa hasta que el usuario introduce:

```text
-1
```

El valor `-1` no es agregado al total, ya que únicamente se utiliza para finalizar la entrada de datos.

---

## Cálculo del Promedio

Después de finalizar el ciclo, el programa verifica si se introdujo al menos una calificación:

```csharp
if (contadorCalif != 0)
```

Si existen calificaciones, el promedio se calcula mediante:

```csharp
promedio = (double)total / contadorCalif;
```

La fórmula utilizada es:

```text
Promedio = Total de Calificaciones / Cantidad de Calificaciones
```

La conversión:

```csharp
(double)
```

permite realizar una división decimal y evitar que el resultado se limite únicamente a números enteros.

---

## Ejemplo de Funcionamiento

Si el usuario introduce:

```text
90
80
75
95
-1
```

El valor `-1` indica al programa que debe finalizar la entrada.

La cantidad de calificaciones introducidas es:

```text
4
```

El total es:

```text
340
```

El promedio es:

```text
85.00
```

Por lo tanto, el programa presenta un resultado similar a:

```text
El total de las 4 calificaciones es 340
El promedio de la clase es 85.00
```

---

## Caso sin Calificaciones

El programa también contempla el caso en que el usuario introduzca inmediatamente:

```text
-1
```

Debido a que el contador permanece en cero, no es posible calcular un promedio.

Por esta razón se utiliza:

```csharp
if (contadorCalif != 0)
```

Si no se introdujo ninguna calificación, se ejecuta el `else`:

```csharp
Console.WriteLine("No se introdujeron calificaciones");
```

Esto evita realizar una división entre cero.

---

## Elementos de C# utilizados

En este segundo problema se aplicaron:

* Clases.
* Objetos.
* Constructores.
* Propiedades.
* Métodos.
* `get`.
* `set`.
* Variables de tipo `int`.
* Variables de tipo `double`.
* Ciclo `while`.
* Repetición controlada por centinela.
* Estructura condicional `if`.
* Estructura `else`.
* Operadores de comparación.
* Operadores matemáticos.
* Conversión mediante `Convert.ToInt32()`.
* Conversión explícita `(double)`.
* Variables acumuladoras.
* Variables contadoras.
* Formato de números decimales.

---

## Resultado - Problema #2

El programa permite introducir una cantidad variable de calificaciones.

La entrada de datos finaliza únicamente cuando el usuario introduce el valor centinela `-1`.

Luego el programa presenta:

* Cantidad de calificaciones introducidas.
* Total de las calificaciones.
* Promedio de la clase.

<img width="395" height="229" alt="image" src="https://github.com/user-attachments/assets/a0ef3a85-902e-4721-8369-e7a5c497068a" />


---

# Comparación de los Dos Problemas

Aunque ambos programas tienen como finalidad calcular el promedio de las calificaciones de una clase, utilizan diferentes métodos para controlar la repetición.

| Característica                   | Problema #1             | Problema #2               |
| -------------------------------- | ----------------------- | ------------------------- |
| Tipo de repetición               | Controlada por contador | Controlada por centinela  |
| Ciclo utilizado                  | `while`                 | `while`                   |
| Cantidad de calificaciones       | Exactamente 10          | Cantidad variable         |
| Valor para terminar              | El contador llega a 10  | El usuario introduce `-1` |
| Tipo de promedio                 | `int`                   | `double`                  |
| Contador inicial                 | 1                       | 0                         |
| División                         | `total / 10`            | `total / contadorCalif`   |
| Permite decimales en el promedio | No                      | Sí                        |
| Verifica si existen datos        | No es necesario         | Sí                        |

---

# Resultados Obtenidos

Al finalizar ambos ejercicios se logró comprender y aplicar diferentes formas de controlar una estructura repetitiva.

Mediante los programas desarrollados se pudo implementar:

* Creación de clases en C#.
* Creación de objetos.
* Uso de constructores.
* Utilización de propiedades `get` y `set`.
* Creación y ejecución de métodos.
* Entrada de información mediante `Console.ReadLine()`.
* Presentación de información mediante `Console.Write()` y `Console.WriteLine()`.
* Conversión de datos mediante `Convert.ToInt32()`.
* Uso del ciclo `while`.
* Repetición controlada por contador.
* Repetición controlada por centinela.
* Uso de variables acumuladoras.
* Uso de variables contadoras.
* Cálculo del total de diferentes valores.
* Cálculo del promedio.
* Uso de estructuras `if` y `else`.
* Conversión de valores enteros a `double`.
* Prevención de una división entre cero.

---

# Dificultades y Soluciones

Durante el desarrollo de los programas se presentan varios conceptos importantes que requieren especial atención.

### Controlar exactamente diez calificaciones

En el primer problema era necesario garantizar que el usuario introdujera exactamente diez calificaciones.

Para realizar este control se utilizó:

```csharp
contadorCalif = 1;
```

junto con:

```csharp
while (contadorCalif <= 10)
```

Después de procesar cada calificación el contador aumenta:

```csharp
contadorCalif = contadorCalif + 1;
```

De esta manera el ciclo se ejecuta exactamente diez veces.

---

### Acumular las calificaciones

Para calcular el promedio primero es necesario conocer la suma de todas las calificaciones.

Para esto se utiliza una variable acumuladora llamada:

```csharp
total
```

Después de introducir cada calificación se ejecuta:

```csharp
total = total + calificacion;
```

De esta manera cada nueva calificación se agrega al valor acumulado anteriormente.

---

### Trabajar con una cantidad desconocida de calificaciones

En el segundo problema no se conoce previamente cuántas calificaciones introducirá el usuario.

Para resolverlo se utiliza el valor centinela:

```text
-1
```

junto con la condición:

```csharp
while (calificacion != -1)
```

Mientras el usuario no introduzca `-1`, el programa continúa solicitando y procesando calificaciones.

---

### Evitar incluir el centinela en los cálculos

El valor `-1` únicamente indica que la entrada ha terminado y no debe formar parte del promedio.

Por esta razón la condición se verifica antes de ejecutar:

```csharp
total = total + calificacion;
```

Cuando la variable contiene `-1`, el ciclo termina y el valor no se suma.

---

### Evitar una división entre cero

En el segundo programa existe la posibilidad de que el usuario introduzca `-1` antes de ingresar una calificación.

En este caso:

```csharp
contadorCalif = 0;
```

Para evitar una división entre cero se utiliza:

```csharp
if (contadorCalif != 0)
```

Solamente cuando existe al menos una calificación se calcula el promedio.

Si no se introducen calificaciones se presenta:

```text
No se introdujeron calificaciones
```

---

### Obtener un promedio con decimales

En el segundo problema el promedio se almacena utilizando:

```csharp
double promedio;
```

Además se convierte explícitamente el total a `double`:

```csharp
promedio = (double)total / contadorCalif;
```

Esto permite obtener un resultado decimal cuando la división no produce un número entero.

---

# Conclusión

El desarrollo de estos dos programas permitió observar dos maneras diferentes de utilizar una estructura repetitiva `while`.

En el primer problema se utilizó una repetición controlada por contador debido a que se conocía previamente que debían introducirse exactamente diez calificaciones. El contador permitió determinar cuándo debía finalizar el ciclo.

En el segundo problema se utilizó una repetición controlada por centinela, ya que no se conocía previamente la cantidad de calificaciones que serían introducidas. El valor `-1` permitió que el usuario decidiera cuándo finalizar el ingreso de información.

También se reforzó el uso de clases, objetos, constructores, propiedades, variables acumuladoras, contadores, estructuras condicionales y conversiones de datos. Ambos ejercicios permiten comprender cómo seleccionar el tipo de repetición adecuado dependiendo de las condiciones de un problema.

---

# Referencias

Material utilizado para el desarrollo de la práctica:

* Código y ejercicios proporcionados para la asignatura Herramientas de Programación Aplicada III.
* Material proporcionado por la Ing. Irina Fong.

---

# Información del Estudiante

**Nombre:** Maria Townshend
**Curso:** Herramientas de Programación Aplicada III
**Institución:** Universidad Tecnológica de Panamá
**Facultad:** Facultad de Ingeniería de Sistemas Computacionales
**Instructor:** Ing. Irina Fong
