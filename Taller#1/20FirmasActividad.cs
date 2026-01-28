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

}







