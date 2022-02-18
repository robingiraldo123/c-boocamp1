using System;

namespace clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // cadenas 
            // las cadenas se utilizan para almacenar texto
            // una variable string contiene una coleccio de caracteres entre comillas dobles
            // ejermplo 
            string txt = "hola";
            Console.WriteLine("la longitud de txt es : " + txt.Length);
            // longitud de cuerda 
            // una cadena en c# es en realidad un objeto que contiene propiedades y metodos 
            // puede realizar ciertas operaciones en cadenba 
            // ejem 
            string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("LA LONGITUD DE LA CADENA ES: " + abecedario.Length);
            // otros metodos 
            // hay muchos metodos de cadena disponiblkes por ejemplo ToUpper y ToLower 
            // devuelven una copia de la cadena convertida a mayusculas y minustulas
            string relleno = "El Lorem Ipsum fue concebido como un texto de relleno," +
                " formateado de una cierta manera para permitir " +
                "la presentación de elementos gráficos en documentos";
            string texto = "convertir a mayusculas y minustulas";
            Console.WriteLine("ToUpper convierte en mayusculas");
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(relleno.ToUpper());
            Console.WriteLine("ToLower convierte a minusculas");
            Console.WriteLine(abecedario.ToLower());
            string rellenoMayus = "FUE CONCEBIDO COMO UN TEXTO DE RELLENO,FORMATEADO DE UNA CIERTA MANERA";
            Console.WriteLine(rellenoMayus.ToLower());
            // concatenacion de cadenas
            // el operador + se utiliza entre cadenas nparea conbinarlas, esto se llama concatenacion
            Console.WriteLine("ingrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese el apellido");
            string apellido = Console.ReadLine();
            string NombreCompleto = nombre + " " + apellido;
            Console.WriteLine("El nombre completo es : " + NombreCompleto);
            string Nombre = "alejandra ";
            string Apellido = " Mona ";
            int edad = 26;
            NombreCompleto = Nombre + Apellido;
            Console.WriteLine("El nombre completo es : " + NombreCompleto);
            // Nota: tenga en cuenta que se agrego un espacio despues de de poner el nombre y antes del apellido
            // para que la concatenacion se vea separada

            // tambien podemos usae string. concat()
            // metodo que sirve para concatenar 
            string concatenar = string.Concat(Nombre, Apellido, edad);
            Console.WriteLine(concatenar);
            // interpolacion de cadenas 
            // otra opc de concatenacion de cadenas es la interpolacioin de cadenas, sustituye valores de variables en marcadores de posicion en una cadeena 
            // Nota: tenga en cuenta que no tiene que preocuparse por los espacios, como con la concatenacion 
            string frutas = "Manzana";
            string varios = "arroz";
            string lista = $"la fruta es : {frutas} y los varios son : {varios}";
            //Nota: tambien tenga en cuenta que debe usar el signo de dolar ($) cuando se use este metodo interpolacion de cadenas
            // la interpolacion se introdujo en la version 6 de c#
            // cadenas de acceso 
            // pueden acceder a los caracteres de una cadena 
            // haciendo referencia  a su numero de indice  entre corchetes []
            // IMPRIMIR EL PRIMER CARACTER DE UNA VARIABLE 
            string myStrin = "estoy en string";
            ///               0123456789101112131415
            Console.WriteLine(myStrin[0]);
            // Nota: las posiciones en los indices de las cadenas comienzan desde 0
            // donde [0] ES EL PRIMER CARACTER y [1] el segundo etc ...
            Console.WriteLine(myStrin[1]);
            // tambien se puede encontrar la posicion de un indice de un caracter en una cadena usando INDEXOF()
            string myvarRelleno = "El Lorem Ipsum fue concebido como un texto de relleno";
            Console.WriteLine(myvarRelleno.IndexOf("I"));// DEVOLVER LA POSICION NUMERICA DONDE SE ENCUENTRA
            Console.WriteLine(myvarRelleno.IndexOf("t"));
            Console.WriteLine(myvarRelleno.IndexOf("c"));
            // substring()
            // extraer los caracteres de una cadena comenzando desde la posicion /indice del caracter especificado
            // devolver una nueva cadena , este metodo se usa amenudo junto con Indexof() para obtener la posicion especifica del caracter 
            string NombreAnimal = "tiburon";
            int poschar = NombreAnimal.IndexOf("r");
            string n = NombreAnimal.Substring(poschar);
            Console.WriteLine(n);
            Console.WriteLine("ejemplo 2");
            NombreAnimal = "Tigre";
            poschar = NombreAnimal.IndexOf("g");
            n = NombreAnimal.Substring(poschar);
            Console.WriteLine(n);
            Console.WriteLine("ejemplo 3");
            NombreAnimal = "PERRO";
            poschar = NombreAnimal.IndexOf("R");
            n = NombreAnimal.Substring(poschar);
            Console.WriteLine(n);
            // adicion de numeros y cadenas 
            // Nota: c# usa el operdaor + tanto para la concatenacion como para la suma
            // recuerde : los numeros se suman y las cadenas se concatenan
            /// ejemplo
            /// si sumas 2 numeros el resultado sera: 
            int x = 10;
            int y = 20;
            int z = x + y; // el resultado sera la suma de x+y
            Console.WriteLine("el resultado de la suma de : "+x+" y el numero "+y+" = "+z);
            string b = "10 ";
            string h = " 50 ";
            string resp = b + h;
            Console.WriteLine(resp);
            // Nota:como es de tipo string no es necesario omitir numeros o omitie el mas ni ponerle mas texto 
            // porque esta haciendo una suma de cadenas
            /// culminacion de el tema de string 
            /// comienzo tema booleanos
            /// muy amenudio en programacion se necesita un tipo de dato que solo pueda tener uno de dos valores 
            /// si, no
            /// encendido, apagado
            /// verdadero o falso
            /// para ello c# dispone de un dato de tipo bool tipo de dato puede tomar dos estados 
            /// true o false 
            /// VALORES BOOLEANOS 
            /// un tipo booleano se declara con la palabra reservada bool y solo puede tomar 2 valores true o false 
            // ejemplo
            bool encendido = true;
            bool apagado = false;
            Console.WriteLine(encendido);
            Console.WriteLine(apagado);
        }
    }
}
