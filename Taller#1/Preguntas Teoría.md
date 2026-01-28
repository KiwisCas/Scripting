# Preguntas de Teoría

### 1. ¿Qué es un ciclo infinito? Escriba un ejemplo.
Un ciclo infinito consiste de un ciclo `for` o `while` cuya condición de finalización jamás se cumplirá. El ejemplo más común es el "`while True`".  
El `while` se repetirá mientras su parámetro sea verdadero (`true`), y como su parámetro es **literalmente** `true`, es infinito.
```c#
// Ejemplo simple de ciclo infinito
while (true)
{
    string inp = Console.ReadLine();
    Console.WriteLine("Escribiste " + inp);
}
```

### 8. Realice un ciclo infinito usando un ciclo for.
Bueno, ya que insiste JAJAJAJAJ
```c#
for (int i=1; i>0; i++)
{
    string inp = Console.ReadLine();
    Console.WriteLine("Escribiste " + inp);
    Console.WriteLine("Valor de i = " + i);
}
```
Este código es un ciclo infinito porque la condición del `for` (que `i` sea `> 0`) va a ser siempre verdadera (`true`), ya que `i` empieza en `1` y solo **aumentará** con cada iteración.  
Como parte de este punto me dio por experimentar y descubrí que `for (int i=1; true; i++)` sería otra manera de obtener el mismo resultado.