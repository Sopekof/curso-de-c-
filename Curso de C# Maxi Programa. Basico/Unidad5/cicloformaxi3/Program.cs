﻿using System;

namespace cicloformaxi3
{
    class Program
    {
        static void Main(string[] args)
        {
             
        //    3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.  
        int edad, acu = 0, con = 0, promedio;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese las edades: ");
            edad = int.Parse(Console.ReadLine());
            if(edad > 18){
                acu += edad;
                con++;
            }   
        }
        promedio = acu / con;
        Console.WriteLine("El promedio de los mayores de 18 años es: " + promedio);
        }
    }
}
