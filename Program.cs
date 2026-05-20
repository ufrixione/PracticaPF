/*Leer 25 edades y realizar lo siguiente: 1. ingresar edades 2. mostratr edades
3. Mostratr mayores de edad , 4. Mostrar menores de edad*/

//1. Ingresar edades

//2.Mostrar edades

//3. Mayores de edad  

//4. Menores de edad


int[] edades = new int [25];
int mayoresEdad = 0;

for (int i = 0; i < edades.Length; i++)

if (edades[i] >= 18)
    {
        mayoresEdad++;
    }

    Console.WriteLine("cantidad de mayores de edad: " + mayoresEdad);