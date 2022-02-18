using System;// librerias

namespace clase_1// espacio de trabajo 
{
    class Program // clase principal
    {
        static void Main(string[] args)/// metodo principal 
        {
            //Variables 
            // las variables son contenedores para alamacenar valores de datos 
            // en c# existem diferentes tipos de variables 
            //4 bytes  int-> los numeros enteros(numeros enteros sin decimales) ejemplo 
            //123, -123
            // 4 bytes float -> los datos con decimales 7 decimales 
            // 8 bytes double->almacenar numeros de punto flotante con decimales ejemplo 19.999, 12,222, -19,999
            // 2 bytes char-> almacenan caracteres infividuales, '' los caracteres almacenan el dato en comillas simples
            // 2 bytes por caracter String-> almacena texto ejm "HOLA MUNDO" LOS VALORES DE CADENA ESTAN RODEADOS POR COMILLAS DOBLES 
            /// 1 bit BOOL -> ALMACENA 2 ESTADOS -> TRUE (VERDADERO) O EL FALSE (FALSO)
            ///ESTRUCTURA
            /// TIPO DE DATO NOMBREvARIABLE = VALUE;
            /// TIPO DE DATO NOMBREvARIABLE
            int edad;
            edad = 18;
            int edad1 = 20;
            double ventas;
            ventas=1000000;
            char sexo = 'F';
            string cadena = "HOLA COMO ESTAS ? SON LAS 5:39";
            bool ESTADO = true;
            bool expre = 5 > 10;
            Console.WriteLine(edad1);// mostrar el consola
            Console.WriteLine(edad);
            Console.WriteLine(ventas);
            Console.WriteLine(sexo);
            Console.WriteLine(cadena);
            Console.WriteLine(ESTADO);
            Console.WriteLine(expre);
            // constates
            // const -> el valor de una constante nunca cambia 
            const int num = 10;
            Console.WriteLine(num);
            //num=3,14 ERROR PORQUE NO PODEMOS CAMBIAR EL VALOR DE UNA CONSTANTE 
            //Nota:no podemos declarar una variable constante sin asignar el valor
            //const int num1; Error porque no se le asigno el valor
            const double numeros = 5.99d;
            const float NumeroF = 45.6f;
            Console.WriteLine(numeros);
            Console.WriteLine(NumeroF);
            /// concatenar
            /// texto y variable 
            /// podemos combinar texto y variables , usando el +
            Console.WriteLine("la variable tiene : " + NumeroF+" la variable double tiene : "+numeros);
            // tamien podemos uasar el + para agregar una variable a otrs 
            string Nombre = "edwin ";
            string apellido = " lopez ";
            string NombreCompleto = Nombre + apellido;
            Console.WriteLine(NombreCompleto);
            int edad3 = 18;
            string informacion = NombreCompleto + edad3;
            Console.WriteLine(informacion);
            // para los valores numericos el + funciona como un operador aritmetico o matematico 
            int x = 5;
            int y = 10;
            Console.WriteLine(x+y);
            // declarar multiples variables
            int c = 10, n = 6, ñ = 12;
            Console.WriteLine(c + n + ñ);
            // identificadores de las variables 
            // nombre unicos, estos nombres unicos son denominados identificadores
            //nombres cortoa(a,b,c,x,edad) nombres mas descriptivos como (suma,volumen,resta etc)
            //Nota: se recomienda utilizar nombres descriptivos para crear codigo comprensible y mantenible
            // reglas generales 
            ///los nombres pueden contener letras,digitos y _
            int abecedario123_;
            ///los nombres siempre deben comenzar con letra
           // int 1_a -> error
            ///los nombres distiguen entre mayusculas y min 
            string Mvar = "hola";
            Console.WriteLine(Mvar);
            string mvar = "como estas?";
            Console.WriteLine(mvar);
            ///las palabras reservadas (como c#,int,double etc ) no se pueden usar como nombres 
            //int c#=2;error
            //int int= 12;error
            // practica
            int mynumero = 45;
            double mydos=8.6666666;
            char mylet = 'a';
            bool myest = true;
            string mytxt = "la casa es amarilla";
           }
    }
}


