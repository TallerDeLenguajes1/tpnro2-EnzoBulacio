using System;

namespace TP2
{
    class Cuadrado
    {
        static void Main(string[] args)
        {
            int num; 
            
            try
            {
                Console.WriteLine("Ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
                num =num* num;
                Console.WriteLine(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error no es un numero \n" + ex.Message);//lo que el usuario debe ver y lo que no debe ver
                
            }
            int a, b;
            try
            {
                Console.WriteLine("ingrese el dividiendo");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el divisor");
                b = Convert.ToInt32(Console.ReadLine());
                a = a / b;
                Console.WriteLine("la division es: "+ a);
            }
            catch(DivideByZeroException zero)
            {
                Console.WriteLine("el divisor no puede ser cero\n"+ zero.Message);

            }


        }
    }
}
