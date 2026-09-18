using System;

Console.WriteLine("EJERCICIO 2");
Console.WriteLine("TEMPERATURA PROMEDIO DE UN MOTOR (10 MEDICIONES)");
Console.WriteLine();

double suma = 0; // Acumulador de las 10 temperaturas

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Ingrese la temperatura {i}: ");
    double temperatura = Convert.ToDouble(Console.ReadLine());
    suma = suma + temperatura; // Se acumula cada medición
}

double promedio = suma / 10.0; // Cálculo del promedio

Console.WriteLine();
Console.WriteLine($"La temperatura promedio es: {promedio:F2} °C");

if (promedio <= 70)
{
    Console.WriteLine("TEMPERATURA NORMAL");
}
else
{
    Console.WriteLine("ALERTA DE TEMPERATURA");
}