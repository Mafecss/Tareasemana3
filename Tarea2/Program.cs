using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio;
            int cantidad;
            int opcion;

            do
            {
                Console.WriteLine("1- Ejercicio1");
                Console.WriteLine("2- Ejercicio2");
                Console.WriteLine("3- Ejercicio3");
                Console.WriteLine("4-Salir");
                Console.WriteLine("*************");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite el costo de las camisas por unidad");
                        float valor = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad de camisas que va a comprar");
                        float camisas = float.Parse(Console.ReadLine());
                        if (camisas <= 1)
                        {
                            float costo = camisas * valor;
                            Console.WriteLine($"El precio de la camisa es de {costo} colones");
                            Console.WriteLine();
                        }
                        else if (camisas > 1 && camisas <= 5)
                        {
                            float desc = (valor * camisas) * 0.15f;
                            float costo = (valor * camisas) - desc;
                            Console.WriteLine($"El precio de las camisas es de {costo} colones con un 15% de descuento");
                            Console.WriteLine();
                        }
                        else if (camisas > 5)

                        {
                            float desc = (valor * camisas) * 0.20f;
                            float costo = (valor * camisas) - desc;
                            Console.WriteLine($"El precio de las camisas es de {costo} colones con un 20% de descuento");
                            Console.WriteLine();
                        }

                        Console.ReadLine();

                        break;

                    case 2:

                        Console.WriteLine("Ingrese el carnet del estudiante:");
                        string carnet = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del estudiante:");
                        string nombre = Console.ReadLine();
                        
                        Console.WriteLine("Ingrese las calificaciones de los quizes (separadas por espacios):");
                        string[] quizInput = Console.ReadLine().Split(' ');
                        float quiz1 = float.Parse(quizInput[0]);
                        float quiz2 = float.Parse(quizInput[1]);
                        float quiz3 = float.Parse(quizInput[2]);

                       Console.WriteLine("Ingrese las calificaciones de las tareas (separadas por espacios):");
                       string[] tareaInput = Console.ReadLine().Split(' ');
                       float tarea1 = float.Parse(tareaInput[0]);
                       float tarea2 = float.Parse(tareaInput[1]);
                       float tarea3 = float.Parse(tareaInput[2]);

                       Console.WriteLine("Ingrese las calificaciones de los exámenes (separadas por espacios):");
                       string[] examenInput = Console.ReadLine().Split(' ');
                       float examen1 = float.Parse(examenInput[0]);
                       float examen2 = float.Parse(examenInput[1]);
                       float examen3 = float.Parse(examenInput[2]);

                       float porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25f;
                       float porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30f;
                       float porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45f;

                        float promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

                        string condicion;
                        if (promedioFinal >= 70)
                        condicion = "Aprobado";
                        else if (promedioFinal >= 50)
                        condicion = "Aplazado";
                        else
                    condicion = "Reprobado";

                        Console.WriteLine("Resultados:");
                        Console.WriteLine($"Carnet: {carnet}");
                        Console.WriteLine($"Nombre: {nombre}");
                        Console.WriteLine($"Porcentaje de quices: {porcentajeQuices}");
                        Console.WriteLine($"Porcentaje de tareas: {porcentajeTareas}");
                        Console.WriteLine($"Porcentaje de exámenes: {porcentajeExamenes}");
                        Console.WriteLine($"Promedio final: {promedioFinal}");
                        Console.WriteLine($"Condición: {condicion}");

                        Console.ReadLine();
            
        
                        break;

                    case 3:
                        Console.WriteLine("Ingrese la cantidad de artículos comprados:");
                        int cantidadArticulos = int.Parse(Console.ReadLine());

                        double precioPorArticulo;

                        if (cantidadArticulos <= 10)
                        {
                            precioPorArticulo = 20.0;
                        }
                        else
                        {
                            precioPorArticulo = 15.0;
                        }

                        double precioTotal = cantidadArticulos * precioPorArticulo;

                        Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
                        Console.WriteLine($"Precio total: ${precioTotal}");

                        Console.ReadLine();
                        break;

                    case 4: Console.WriteLine("Gracias");
                        break;
                    default: Console.WriteLine("Opcion incorrecta");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
                
            } while (opcion!=4);



            
        }
    }
}
