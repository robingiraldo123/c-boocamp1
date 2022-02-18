using System;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // operadores c#
            /// los operadores se utilizan para realizar operaciones sobre variables y valores 
            /// |--------------------------------------------------------------------------------------|
            /// |                                      aritmeticos                                     |
            /// |los operadores aritmeticos se usan para realizar operaciones matematicas              |
            /// | operador          Nombre         descripcion
            /// |   +              suma           sumar valores o variables
            /// |   -              resta         restar  valores o variables
            /// |   *           multiplicacion   multiplicar variables o valores 
            /// |   /             division       divide valores y variables 
            /// |   %              modulo         residuo de la division
            /// |   ++             incremento     incrementar el valor de una variable 
            /// |   --             decremento     decrementar el valor de una variable 
            /// |--------------------------------------------------------------------------------------|
            Console.WriteLine("estoy en suma");
            int num1=17;
            int num2 = 5;
            int respuesta = num1 + num2;
            Console.WriteLine(respuesta);
            Console.WriteLine(4+5);
            Console.WriteLine("estoy en resta");
            respuesta = num1 - num2;
            Console.WriteLine(respuesta);
            Console.WriteLine(6-5);
            Console.WriteLine("estoy en multiplicacion");
            respuesta = num1 * num2;
            Console.WriteLine(respuesta);
            Console.WriteLine(5*2);
            Console.WriteLine("estoy en division");
            double Resp = num1 / num2;
            Console.WriteLine(Resp);
            Console.WriteLine(8/4);
            Console.WriteLine("estoy en modulo");
            Console.WriteLine(5%2);
            respuesta = num1 % num2;
            Console.WriteLine(respuesta);
            Console.WriteLine("estoy en incremento");
            Console.WriteLine(num1++);
            Console.WriteLine("estoy en decremento");
            Console.WriteLine(num2--);
            respuesta = 4 + 5 - 6 / 2;
            Console.WriteLine("la suma ",5+6,"la resta ",8-9);
            /// |--------------------------------------------------------------------------------------|
            ///                                              asignacion
            ///   los operadores de asignacion se usan para signar valores a variable 
            /// | operador          Nombre         descripcion
            /// |   =               asignacion      asignarle valores a las variables 
            /// |   +=              suma y asignacion
            /// |   -=              resta y asignacion 
            /// |   /=
            /// |   %=
            /// /// |--------------------------------------------------------------------------------------|
            Console.WriteLine("suma y asignacion");
            int x = 5;
            x += 100;
            Console.WriteLine(x);
            Console.WriteLine("resta y asignacion");
            x -= 61;
            Console.WriteLine(x);
            Console.WriteLine("multi y asignacion");
            x *= 12;
            Console.WriteLine(x);
            Console.WriteLine("division y asignacion");
            x /= 4;
            Console.WriteLine(x);
            Console.WriteLine("modulo y asignacion");
            x %= 2;
            Console.WriteLine(x);
            /// |--------------------------------------------------------------------------------------|
            ///                                       comparacion
            ///   los operadores de comparacion se usan para comparar valores 
            ///  | operador          Nombre         descripcion
            ///     ==               igual que      validar si 2 valores o variables son iguales 
            ///     !=               diferente que  validar si dos valores o variables son diferentes 
            ///     <                menor que      validar si el numero es menor
            ///     >                mayor que       valida si el numero es mayor
            ///     <=               menor o igual   validar si el numero es menor o igual
            ///     >=               mayor o igual   validar si el numero es mayor o igual
            /// |--------------------------------------------------------------------------------------|
            int a = 45;
            int b = 12;
            Console.WriteLine("==");
            Console.WriteLine(a==b);// logico true o false (false)
            Console.WriteLine(6==6);// true
            Console.WriteLine(14==16);// false
            Console.WriteLine("!=");
            Console.WriteLine(a!=b);//true
            Console.WriteLine(47!=47);//false
            Console.WriteLine("<");
            Console.WriteLine(a<b);//false
            Console.WriteLine(5<45);//true
            Console.WriteLine(">");
            Console.WriteLine(a>b);//true
            Console.WriteLine(65>2);//true
            Console.WriteLine(9>12);//false
            Console.WriteLine("<=");
            Console.WriteLine(12<=12);//true
            Console.WriteLine(a<=b);//false
            Console.WriteLine(">=");
            Console.WriteLine(a>=b);//true
            Console.WriteLine(6>=0);// true
            Console.WriteLine(6>=6);// true
            /// |--------------------------------------------------------------------------------------|
            ///                                              logicos
            ///    se usan para determinar  la logica entre variables y valores 
            ///  | operador          Nombre         descripcion
            ///      &&               and          valir que dos variables o valores sean true (incluyesnte
            ///      ||                or           almenos uno debe ser true 
            ///      !                 not           negar
            /// |--------------------------------------------------------------------------------------|
            int z = 4;
            int c = 6;
            Console.WriteLine("&&");
            Console.WriteLine(z<5&&z<10);// and ambas expre deben ser tru para que el resultado sea true (true)
            Console.WriteLine(z<2&&z<10);// false 
            Console.WriteLine("||");
            Console.WriteLine(z>3||z<45);//true
            Console.WriteLine(z<5||z<10);//true
            Console.WriteLine(z<2||z<3);
            Console.WriteLine("!");
            Console.WriteLine(!(z > 3 || z < 45));//true -> false
            Console.WriteLine(!(z < 2 && z < 10));// false ->true

            //math Matematica
            // la clase que tiene muchos metodosque permiten realizar tareas matematicas con numeros 
            //math.max()
            // puede ser usado para encontrar erl mayor valor entre x e y 
            Console.WriteLine( Math.Max(5, 10));
            // math.min()
            // se usa para encontrar el valor minimo entgre x e y
            Console.WriteLine(Math.Min(15,20));
            // math.Sqrt()
            /// este metodo devuelve la raiz cuadrada de el numero que pongas en ()
            Console.WriteLine( Math.Sqrt(64));
            //MATH.ABS
            //devuelve el valor absoluto positivo
            Console.WriteLine(Math.Abs(-5.7));
            //math.round
            //redondear un numero
            Console.WriteLine(Math.Round(9.99));




        }
    }
}
