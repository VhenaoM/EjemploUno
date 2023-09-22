//1ro definir el nombre de mi clase//

public class EjemploUno

{
    static void Main(string[] args)
    {

        //datos de entrada//

        int num1, num2, suma, resta, producto, cociente;

        //3ro pedir valores de pantalla//

        Console.WriteLine("Ingrese su primer número ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su segundo número ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //calculos//
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        // datos de salida//
        Console.Write("La suma es: " + suma);    
        Console.Write("\n");
        Console.Write("La resta es : " + resta);
        Console.Write("\n");
        Console.Write("El producto es : " + producto);    
        Console.Write("\n");
        Console.Write("El cociente es : " + cociente);




    }
} 