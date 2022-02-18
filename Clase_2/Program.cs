using System;

namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///fundicion en c#
            ///conversion impliimplicita(automatica)
            ///canvertir un tipo mas pequeño de dato en uno mas grande
            /// char-> int->long->float->double
            ///conversion explicita(manualmente)
            ///conversion de un tipo de dato mas grande en un tipo de dato mas pequeño
            ///double->float->lomg->int->char
            ///casting implicto
            int myint = 9;
            double mydouble = myint;
            Console.WriteLine(myint);
            Console.WriteLine(mydouble);
            //casting explicito
            double var = 9.78;
            int varint = (int)var;
            Console.WriteLine(var);
            Console.WriteLine(varint);
            float varFloat = 4.56F;
            Console.WriteLine(varFloat);
            long VarLong = (long)varFloat;
            Console.WriteLine(VarLong);
            // mas metodos de conversion 
            /// tambien es posible convertir de forma explicita mediante funciones 
            /// convert.ToBoolean
            /// convert.ToDouble
            /// convert.ToString
            /// convert.ToInt32(int)
            /// convert.ToInt64(long)
            /// covert.ToDecimal() te da decimales 
            myint = 10;
            mydouble = 5.25;
            bool mybool = true;
            string varS = "h";


            Console.WriteLine(Convert.ToString(myint));/// conversion de entero a string
            Console.WriteLine(Convert.ToDouble(myint));/// conversion de int a double
            Console.WriteLine(Convert.ToInt32(mydouble));/// conversion de douuble a int
            Console.WriteLine(Convert.ToString(mybool));/// conversion de bool  a string
            Console.WriteLine(Convert.ToInt64(mydouble));/// double a LONG
            //Console.WriteLine(Convert.ToChar(varS)); // convertir de string a char
            // ¿por que la conversion?
            // entrada de usuario 
            ///obtener informacion del usuario
            ///console.writeline() generar (imprimir) 
            ///console.Readline() para obtener la entrada de datos por el usuario
            Console.WriteLine("ingrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre);
            ///Nota:console.readline() es un metodo de tipo string que devuelve un string
            ///por lo tanto no podemos implicitamete informacion d eotro tipo de dato
            ///ejm ingresamos un dato de tipo int  el provoca error
            Console.WriteLine("ingrese la edad");
            //int edad = Console.ReadLine(); Error
            /// el mensaje de error lo que dice es no se puede convertir de manera explicita 
            /// un string  aun int
            /// para mejorar esto se implemento el convert
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(edad);
            Console.WriteLine("ingrese valor");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(valor);
            Console.WriteLine("ingrese estado");
            bool estado = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(estado);
            Console.WriteLine("ingrese un numero grande");
            long varlong = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(varlong);
            // Nota: si nosotros ingresamos una entrada incorrecta ejm entrada numerica y ingresamos un string 
            // salta error System.formatExcepcion "la cadena de entrada no tiene el formato correcto"
            // ejercicios
            Console.WriteLine("ingrese valor");
            int num = Console.ReadLine(); // encuentres el error 
            //2
            double num1=45.68;
            Console.WriteLine();// conviertas de double a cadena 
            //3
            // complete las partes que faltan para obtener la entrada de usuario alamacenada en la sig variable
            Console.WriteLine("ingrese nombre de usuario  ");
            string username = Console;
            //MOSTRAR
        }
            

        }
    }

