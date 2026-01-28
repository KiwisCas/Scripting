namespace EjerciciosScripting
{
    internal class Program
    {
        // Realice una función que lea una matriz de números enteros de NxM y calcule el promedio de cada fila y cada columna.
        /*static void Main(string[] args)
        {
            int[,] matriz = { 
                {1, 2, 3 },
                {4, 5, 6 }
            };

            CalcularPromedios(matriz);

        }

        static void CalcularPromedios(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                int sumaFila = 0;

                for (int j = 0; j < columnas; j++)
                {
                    sumaFila += matriz[i, j];
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine($"\nEl promedio de la fila {i+1} es: {(double)sumaFila / columnas}");

            }


            for (int j = 0; j < columnas; j++)
            {
                int sumaColumna = 0;
                
                for (int i = 0; i < filas; i++)
                {
                    sumaColumna += matriz[i, j];
                }
                Console.WriteLine($"El promedio de la columna {j + 1} es: {(double)sumaColumna / filas}");
            }
        }*/

        // Realizar una función que calcule si una cadena es palindroma.

        /*static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el texto a analizar: ");
            string texto = Console.ReadLine();

            if (EsPalindromo(texto))
                Console.WriteLine($"La cadena {texto} es palindroma");
            else
                Console.WriteLine($"La cadena {texto} NO es palindroma");
            
        }
        static bool EsPalindromo(string cadena)
        {
            cadena = cadena.ToLower().Replace(" ", "");
            int inicio = 0;
            int fin = cadena.Length - 1;

            while (inicio < fin)
            {
                if (cadena[inicio] != cadena[fin])
                {
                    return false;
                }

                inicio++;
                fin--;
            }

            return true;
        }*/

        //Calcule el promedio de los números positivos de un array de números flotantes.
        static void Main()
        {
            Console.Write("Ingrese el tamaño del array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    array[i] = 1;   // es par
                else
                    array[i] = 0;   // es impar
            }

            Console.WriteLine("Contenido del array (empieza en 0):");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


    }
}
