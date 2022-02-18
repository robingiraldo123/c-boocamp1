using System;

namespace clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada de usuario 
            // la entrada de usuario nos sirve para obtener 
            // console.readline() obtener la entrada de usuario 
            Console.WriteLine("ingrese el nombre ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("El nombre es: "+nombreUsuario);
            //Nota: el metodo conole.readline devuelve un string por lo tanto informacion de otro tipo de dato como 
            // int, double,float,bool sin convertirlo 
            Console.WriteLine("ingrese la edad");
            //int edad = Console.ReadLine(); si intentamos pedir los datos sin convertirlos nos saldra un error
            // convet.to metodos  
            // convert.Toint32 -> Int
            // convert.Toint64 -> long
            // convert.Todouble-> double
            // NOTA: CUANDO TENEMOS VARIABLES O INGRESAMOS VLORES A UN STRING EL LO PERMITE PORQUE EL STRING NUMEROS COMO LETRAS
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La edad es: "+edad);
            Console.WriteLine("Ingrese el precio");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El precio es: "+precio);
            Console.WriteLine("ingrese el estado: ");
            bool estado = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("El estado es : "+estado);
            // Nota: si se ingresa una entrada de usuario incorrecta en este caso sting para un dato de tipo bool saldria error 
            /// de excep, pasa porque la cadena de entrada no tiene el texto correcto
            // condiciones logicas 
            //>,<,>=,<=,==,!=
            // if -> se usa para especificar un bloque de codigo que se ejecutara si una  condicion especificada es true 
            // else-> para especificar un bloque de codigo a ejecutar, si la misma condicion es falsa
            // else if-> para especificaruna nueva condicion para comprobar si la primera condicion es verdadera
            // switch -> para especificar muchos bloques de codigo alternativos para ejecutart

            int x = 20;
            int y = 18;
            if (x<y)
            {
                Console.WriteLine("x mayor que y");
            }
            else
            {
                Console.WriteLine("y es menor");
            }
            /// tiempo 
            int tiempo = 12;
            if (tiempo < 10)
            {
                Console.WriteLine("buenos dias");
            }else if (tiempo < 20)
            {
                Console.WriteLine("buenas tardes");
            }
            else {
                Console.WriteLine("buenas noches");
            
            }
            //OPERADOR TERNARIO
            //if-elsr abreviado, pero se conoce como operador ternario 
            // consta de 3 operandos, se puede usar para remplazar varias lineas de codigo en una sola
            // a menudo nos sirve solo para remplazar condiciones if-else simples
            tiempo = 20;
            string resultado = (tiempo < 18) ? "buenos dias " : "buenas noches";
            Console.WriteLine(resultado);
            ///----------------------------------------------------------------------
            /// if else ejemplo 
            if (tiempo < 18)
            {
                Console.WriteLine("buenos dias");
            }
            else
            {
                Console.WriteLine("buenas noches");
            }
            // ejercicio 1
            // crear un algoritmo o programa que le de acceso a un usuario si la contraseña es corresto y en caso contrario mandar un mensaje que diga 
            /// no es posible su ingreso
            string contraseña = "123456F";
            string usuario = "admin";
            if (contraseña == "123456F"&& usuario=="admin")
            {
                Console.WriteLine("Bienvenido a el aplicativo");
            }
            else
            {
                Console.WriteLine("No es posible su ingreso valide la informacion");
            }
        }
    }
}
