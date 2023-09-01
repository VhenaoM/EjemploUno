

// 1ro definir el nombre de la clase//
public class EjemploUno  

{
    static void Main(string[] args)
    {
      // ingresar por pantala 2 números y calcuar las 4 operaciones arimeticascon cada numero
     //imprimir en pantalla elresultado de cada opeación//

        // declaracin de mis variables (datos de etrada//
        int num1, num2, suma, resta, producto, cociente;
        // 3ro pedir los valores por pantalla (consola)

        Console.Write("Ingrese su primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // 4to cálculos//
         
       suma = num1 + num2;  
        resta = num1 - num2;    
        producto = num1 * num2; 
        cociente = num1 / num2;

        // 5to imprimir los resultados//
        Console.Write("La suma es: " + suma);
        Console.Write("\n");
        Console.Write("la resta es: " + resta);
        Console.Write("\n");
        Console.Write("El producto es: " + producto);
        Console.Write("\n");
        Console.Write("El cociente es: " + cociente);
        
    }
   
}