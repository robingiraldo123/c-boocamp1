using System;

namespace clase12
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciclos 
            // los ciclos pueden ejecutar un bloque de codigo siempre que se alcance una condicion especifica
            // while() -> Mientras 
            // el while recorre un bloque de codigo siempre que una condicion especifica sea True
            // estructura 
            //while(condicion)
            //{
            // codigo a ejecutar
            //}
            // contador 
            // el contador es una variable entera que se incrementa o se decrementa , va guardando cada interacion del bloque
            /// acumulador 
            /// un acuulador es una variable de cualquier tipo que en su interior va umando o almacenando un valor
           
            //realizar un programa que pida la suma del 1 al 10
            int contador = 1;
            int acumuladora=0;
            while (contador<10)
            {
                //1 FORMA
                acumuladora += contador;
                //2Forma 
                // acumuador=acumulador+contador
                
                Console.WriteLine("La suma es: " +contador+" "+ acumuladora);
                contador++;
            }
            //NOTA:no olvide aumentar la variable contadora de lo contrario, el ciclo nunca terminara 
            //realizar un programa que muestre los numeros del 1 al 100
            contador = 1;
            while (contador<=100)
            {
                Console.WriteLine("el numero es: " + contador);
                contador++;


            }
            // realizar un programa que muestre de manera inversa los numeris del 100 al 1
            contador = 100;
            while (contador >= 1)
            {
                Console.WriteLine("el numero es: " + contador);
                contador--;
            }
            // realizar un programa que muestre unicamente los numeros pares en rango de 1 al 100
            contador = 1;
                while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("el numero par es: " + contador);
                }
                else
                {
                    Console.WriteLine("el numero impar es: " + contador);
                }
                contador++;
            }
            /// realice un programa que muestre la suma de los numeros del 1 al 100
            int suma = 0;
            contador = 1;
                while (contador <= 100)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine("la suma es: "+ suma);
            suma = 0;
            contador = 1;
            while (contador<100)
            {
              if (contador % 2 == 0)
                {
                    suma += contador;
                   
                }
                contador++;
            }
            Console.WriteLine("la suma es : "+suma);
            /// realizar un programa que pida numeros mientras no se ingrese un numero negativo, al final debe ingresar la
            /// suma de los numeros ingresados 
            suma = 0;
            contador = 0;
            while (contador >= 0)
            {
                suma += contador;
                Console.WriteLine("ingrese un numero");
                contador = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("La suma es: "+suma);
            /// Realizar un programa que pido 2 numeros enteros e imprima los numeros pares que existen entre estos 2 numeros 
            /// Nota: se debe validar que el segundo numero sea mayor que el primero 
            int num1, num2;
            Console.WriteLine("ingrese num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine("el num2 debe ser mayoy que el numero 1");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            contador = num1;
            while (contador<=num2)
            {
                if ( contador%2==0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
            /// realice un programa que pida al usurio unay otra vez si quiere o no terminar el programa,
            /// el programa solo acabara si la repuesta es si en Mayuscula
            Console.WriteLine("Ingrese SI para comenzar");
            string program =Console.ReadLine();
            while (program == "SI")
            {
                if(program == "SI")
                {
                    Console.WriteLine("¿Desea continuar con el programa?");
                    program = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hasta luego");
                }
              

            }
            // Realice un programa que pida la contraseña y confirmar la contraseña si no coinciden vuelvalas a pedir 
            Console.WriteLine("confirme la contraseña");
            Console.WriteLine("ingrese su contraseña");
            string contraseña= Console.ReadLine();
            Console.WriteLine("ingrese de nuevo su contraseña");
            string contraseña1= Console.ReadLine();
            while (contraseña!=contraseña1)
            {
                Console.WriteLine("las contraseñas no coinciden ingrese su contraseña nuevamente");
                contraseña = Console.ReadLine();
                Console.WriteLine("las contraseñas no coinciden ingrese su contraseña nuevamente");
                contraseña1 = Console.ReadLine();
                if (contraseña == contraseña1)
                {
                    Console.WriteLine("Contraseña confirmada");
                }
            }
            //incremento 
            // como su nombre lo dice una variable que esta en constante incremento 
            // ejemplo 
            int incremento=1;
            incremento++;
            //1,2,3,4,5
            // decremento 
            // decrementar el valor de una variable 
            int decremento = 1;
            decremento--;
            //5,4,3,2,1
        }
    }
}
