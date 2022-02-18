using System;

namespace clase_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos a ingresar un valor en el rango de 1-5 mostrar de la siguiente manera los numeros "uno","dos".... etc 
            // y cualquier valos fuera de dicho rango ingresara al caso default
            Console.WriteLine("ingrese numero ");
            int numero = Convert.ToInt32(Console.ReadLine());
         switch (numero)

                
            {
                case 1:
                    Console.WriteLine("El numro es : "+numero);
                    break;

                    case 2:
                    Console.WriteLine("El numro es : " + numero);
                    break;

                         case 3:
                    Console.WriteLine("El numro es : " + numero);
                    break;

                         case 4:
                    Console.WriteLine("El numro es : " + numero);
                    break;

                         case 5:
                    Console.WriteLine("El numro es : " + numero);
                    break;
                default:
                    Console.WriteLine("el numero ingresado no es el correcto");
                    break;
            }
        }
    }
}
