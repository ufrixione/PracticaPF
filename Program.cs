/*Leer 25 edades y realizar lo siguiente: 1. ingresar edades 2. mostrar edades
3. Mostrar mayores de edad , 4. Mostrar menores de edad*/
//1. Ingresar edades

//2.Mostrar edades

//3. Mayores de edad  

//4. Menores de edad

int[] edades = new int[25];
for (int i = 0; i < 25; i++)
{
try 
{
Console.Write("Ingrese la edad " + (i + 1) + ": ");
string entrada = Console.ReadLine()!;
edades[i] = int.Parse(entrada);
}
catch (Exception)
{
Console.WriteLine("¡Error! Debes ingresar un número válido.");
i--;
}
}
Console.WriteLine("Numeros guardados correctamente.");