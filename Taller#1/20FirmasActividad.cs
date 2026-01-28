//Firmas Hermosas
using System;
using System.Collections.Generic;

public class Persona{
    
    public string Nombre;
    public int Edad;

    public Persona (string Nombre, int Edad){
        Nombre = nombre;
        Edad = edad;
    }
}

class Program
{
    static void Main(string[] args){
        //Invicaciones de las Firmas
        Saludar();
        MostrarNumero(10);
        int suma = Sumar(5,7);
        Console.WriteLine(suma);


        Console.WriteLine(ObtenerMensaje());
        MostrarMensaje("HolaChajaja");

        Console.WriteLine(EsPar(0));

        int[] numeros = {1,2,3};
        MostrarArray(numeros);

        string[] nombres = {"Ana", "Luis", "Carlos" };
        MostrarNombres(nombres);

        Persona p = new Persona("Pepe", 20);
        MostrarPersona(p);

        Console.WriteLine(MostrarRandom());

        int resultadoCuadrado = Cuadrado(5);
        Console.WriteLine(resultadoCuadrado);

        float redondeado = RoundDown(4.7f);
        Console.WriteLine(redondeado);

        int[] numeros = { 1, 2, 3, 4, 5 };
        PrintArray(numeros);

        bool hermoso = IsBeautiful();
        Console.WriteLine(hermoso);

        string textoInvertido = Reverse("Hola");
        Console.WriteLine(textoInvertido);

        double valor = WasteSpace(10);
        Console.WriteLine(valor);

        int abs1 = Absolute(-8);
        Console.WriteLine(abs1);

        bool esDivisible = DivBy3(9);
        Console.WriteLine(esDivisible);

        double promedio = Promedio(8.5, 9.5);
        Console.WriteLine(promedio);

        RepetirMensaje("No sé que poner D:", 3);
    }

    //#1
    static void Saludar() 
    {
        Console.WriteLine("Holi pepe");
    }
    //#2
    static void MostrarNumero(int numero)
    {
        Console.WriteLine(${numero});
    }
    //#3
    static int Sumar(int a, int b)
    {
        return a + b;
    }
    //#4
    static string ObtenerMensaje()
    {
        return "Mensaje Enviado";
    }
    //5
    static void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
    //#6
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
    //#7
    static void MostrarArray(int[] array)
    {
        foreach (int n in array){
            Console.WriteLine(n);
        }
    }
    //#8
    static void MostrarNombres(string[] array){
        foreach (string n in array){
            Console.WriteLine(n);
        }
    }
    //#9
    static void MostrarPersona(Persona persona)
    {
        Console.WriteLine($"Hola soy {persona.Nombre} y tengo {persona.Edad} años.")
    }
    //#10
    static int MostrarRandom()
    {
        Random r = new Random();
        return r.Next(1,100);
    }
    //#11
    static int Cuadrado(int n)
    {
        n *= n;
        return n;
    }
    //#12
    static float RoundDown(float n)
    {
        //Creo que no hay que escribir las funciones so, dejemos así
        return n
    }
    //#13
    static void PrintArray(int[] arr)
    {
        for (int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i])
        }
    }
    //#14
    static bool IsBeautiful()
    {
        return true;
    }
    //#15
    static string Reverse(string str)
    {
        //Código!
        return str;
    }
    //#16
    static double WasteSpace(int n)
    {
        return double;
    }
    //#17
    static int Absolute(int n)
    {
        if (n>0)
        {
            return n;
        }
        else
        {
            return -1*n;
        }
    }
    //#18
    static bool DivBy3 (int n)
    {
        return (n % 3 == 0);
    }
    //#19
    static double Promedio(double a, double b)
    {
        return (a + b) / 2;
    }
    //#20
    static void RepetirMensaje(string mensaje, int veces)
    {
        for (int i = 0; i < veces; i++)
        {
            Console.WriteLine(mensaje);
        }
    }

}









