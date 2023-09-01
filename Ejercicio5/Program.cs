
// Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

// 1 clase y metodo

public class Ejercicio5
{
    static void Main(string[] args)
    {
        // 2 definir variables

        double cateto1, cateto2, hipotenusa;

        //3 pedir datos de entrada

        Console.WriteLine("Escriba el valor del cateto 1: ");
        cateto1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" Escriba el valor del cateto 2: ");
        cateto2 = Convert.ToDouble(Console.ReadLine());

        // 4 calculos

        hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));

        // 5 entrega en pantalla

        Console.WriteLine($"la hipotenusa de las lados {cateto1} y {cateto2} es: {hipotenusa} ");


    }
}
