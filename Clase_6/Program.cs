using System;

namespace Clase_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // condicionales 
            // c# admite los condicionales logicos, habituales de la matematica
            // menor que <
            // mayor que >
            // mayor o igual que >=
            // menor o igual que <=
            // igual a ==
            // no igual !=
            /// podemos usar estas condicionales para realizar diferentes acciones y toma de desiciones 
            /// c# tiene las siguientes declaraciones condicionales 
            /// if-> se ejecuta siempre y cuando la condicion sea verdadera 
            // estructura if
            // if (condicion)
            //{
            // ejecutar las instrucciones
            //}
            // Nota:Tenga en cuenta que if esta en minuscula, las letras mayusculas (IF,iF) GENERAN UN ERROR 
            /// Ejemplo 
            /// probar dos valores para averiguar si 20 es mayor que 18 si la condicion es verdadera (True),imprime el texto
            if (20>18)
            {
                Console.WriteLine("20 es mayor que 18");
            }
            // ejemplo 2
            int var1=20, var2=100;
            if (var1>var2)// false no se cumplio
            {
                Console.WriteLine("var1 mayor que var 2");
            }
            /// else -> se ejecuta siempre y cuandolla condicion sea falsa
            /// ejemplo mayor o menor de edad 
            Console.WriteLine("Ingrese edad");
            int edad =Convert.ToInt32(Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
            /// else if -> para seguir probando si la condicion esverdadera 
            /// switch -> para especificarmuchos bloques de codigo alternativos para ejecutar
            /// ejercicio 1
            /// pedir el sueldo de un trabajador, si el sueldo supera los 900000 mil mostrar un mensanje
            /// que diga que puede abonar impuestos 
            double salario =Convert.ToDouble(Console.ReadLine());
            if(salario>900000) 
            {
                Console.WriteLine("puede abonar impuestos");
            }
            else
            {
                Console.WriteLine("no puede abonar impestos ");
            }
            // ingrese 3 notas de un alumno si el promedio de el alumno es menor que 3 debe salir reprobado,
            //si el promedio del alumno es mayor que 3 y menor que 4 aprobado y si es mayor a 4 aprobado con Honores
            //analisis del problema 
            // promedio -> las notas sumandolas y dividiendo * cantidad de notas 
            //3 notas
            // <3 reprobo
            //>=3 y <4 aprobo
            //>=4 aprobo con Honores
            Console.WriteLine("ingrese nota 1");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 2");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 3");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            int suma = nota1 + nota2 + nota3;
            double promedio = suma / 3;
            Console.WriteLine(promedio);
            if (promedio<3.0)
            {
                Console.WriteLine("Reprobo");
            }else if (promedio>=3.0||promedio<4.0)
            {
                Console.WriteLine("Aprobo");
            }else if (promedio >= 4.0)
            {
                Console.WriteLine("Aprobo con honores");
            }
            else
            {
                Console.WriteLine("opcion invalida");
            }
            // pedir al usuario nombre del empleado, sueldo del empleado y si el sueldo es <900000 incrementar en un 15%
            // si el sueldo es mayor a 900000 y sueldo menor a 1000000 incremento 10% 
            // si el sueldo > 1000000 y sueldo menor a 2000000 incrementar 5%
            // si el sueldo >2000000 incremento 0%, al finalizar imprimir nombre,sueldo inicial,incremento,sueldo final 
            // analisis
            // nombre, sueldo
            // <900000 15%
            // >900000 y <1000000 10%
            // >1000000 y <2000000 5%
            // >2000000 0%

            int salario_empleado = Convert.ToInt32(Console.ReadLine());
            string nombre_empleado = (Console.ReadLine());
            if (salario_empleado<900000) {
                double incremento = salario_empleado * 0.15;
                double Salario_total = salario_empleado + incremento;
                Console.WriteLine("El incremento es : " + incremento);
                Console.WriteLine("El nombre es : "+nombre_empleado);
                Console.WriteLine("El sueldo es : " + salario_empleado);
                Console.WriteLine("El salario total con el incremeneto es : "+Salario_total);
            }
            if (salario_empleado>=900000|| salario_empleado <1000000 ) 
            {
                double incremento = salario_empleado * 0.1;
                double Salario_total = salario_empleado + incremento;
                Console.WriteLine("El incremento es : " + incremento);
                Console.WriteLine("El nombre es : " + nombre_empleado);
                Console.WriteLine("El sueldo es : " + salario_empleado);
                Console.WriteLine("El salario total con el incremeneto es : " + Salario_total);
            }
            else if (salario_empleado >= 1000000|| salario_empleado < 2000000)
            {
                double incremento = salario_empleado * 0.05;
                double Salario_total = salario_empleado + incremento;
                Console.WriteLine("El incremento es : " + incremento);
                Console.WriteLine("El nombre es : " + nombre_empleado);
                Console.WriteLine("El sueldo es : " + salario_empleado);
                Console.WriteLine("El salario total con el incremeneto es : " + Salario_total);

            }
            else if (salario_empleado>= 2000000)
            {
                double incremento = 0;
                double Salario_total = salario_empleado + incremento;
                Console.WriteLine("El incremento es : " + incremento);
                Console.WriteLine("El nombre es : " + nombre_empleado);
                Console.WriteLine("El sueldo es : " + salario_empleado);
                Console.WriteLine("El salario total con el incremeneto es : " + Salario_total);
            }
            else
            {
                Console.WriteLine("invalido");
            }
            // los operadores logicos
            int num = 5;
            if(num<45 || num>36)// true la funcion true 
            {
                Console.WriteLine("cumplio");
            }
            else
            {
                Console.WriteLine("error");
            }
            // ejercicio propuesto 1
            /// Realizar un programa que lea por teclaso 2 numeros , si el primero es mayor que el segundo 
            /// informar la suma y diferencia, en caso de que el segundo sea mayor que el primero
            /// mostrar el producto(multiplicacion) y la division de el primero respecto al segfundo 
            /// 
            /// ejercicio propuesto 2
            /// Realizar un programa que solicite al usuario ingresar 2 numeros distintos y muestre 
            /// por pantalla el mayor y menor 
            

        }
    }
}
