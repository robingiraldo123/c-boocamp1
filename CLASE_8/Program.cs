using System;

namespace CLASE_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO PRACTICO ENTRADA DE USUARIO 
            // HACER UN PROGRAMA CON ENTRADA DE USUARIO QUE PIDA LA INFORMACION DE UN EMPLEADO NOMBRE, SALARIO Y VALIDE SI TIENE UN INCREMENTO EN SU
            // SALARIO 
            ///     INCREMENTO             CONDICION
            ///       15%                    SE DA CUANDO EL EMPLEADO TIENE UN SALARIO <900000
            ///       10%                    SE DA CUANDO EL EMPLEADO TIENE UN SALARIO >=900000 && <1500000
            ///       5%                     SE DA CUANDO EL EMPLEADO TIENE UN SALARIO >=1500000 && <2500000
            ///       0%                     SE DA CUANDO EL EMPLEADO TIENE UN SALARIO >=2500000
            ///      if -> para especificar un bloque de codigo que se ejecuta si una condicion es true
            ///      else -> para especificar un bloque de codigo a ejecutar si la condicion es false 
            ///      else if -> usa para especificar una nueva condicion y comprobar si la primera condicion es falsa que esta sea verdadera
            Console.WriteLine("ingrese slario");
            int salario_empleado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nombre");
            string nombre_empleado = Convert.ToString(Console.ReadLine());
            double incremento = 0;
            double salario_total = 0;
            if (salario_empleado < 900000)
            {
                incremento = salario_empleado * 0.15;
                salario_total = incremento + salario_empleado;
            } else if (salario_empleado>=900000 && salario_empleado <=1500000){
                incremento = salario_empleado * 0.10;
                salario_total = incremento + salario_empleado;
            }
            else if(salario_empleado>=1500000 && salario_empleado <=2500000)
            {
                incremento = salario_empleado * 0.05;
                salario_total = incremento + salario_empleado;
            }
            else if(salario_empleado>=2500000)
            {
                incremento = 0;
                salario_total = incremento + salario_empleado;
            }
            else
            {
                Console.WriteLine("no tiene incremento este año ");
            }
            Console.WriteLine("El nombre del empleado es : "+nombre_empleado);
            Console.WriteLine("El salario inicial es : "+salario_empleado);
            Console.WriteLine("El incremento es : "+incremento);
            Console.WriteLine("El salario total es : "+salario_total);

            // crear un programa que lea 5 calificaciones, calcule el promedio y nos de la suma de las notas,
            // nos diga si el estudiante aprobo o re probo
            int nota1, nota2, nota3, nota4, nota5;
            int suma=0;
            double promedio = 0;
            Console.WriteLine("ingrese nota 1");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 2");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 3");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 4");
            nota4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nota 5");
            nota5 = Convert.ToInt32(Console.ReadLine());
            suma = nota1 + nota2 + nota3 + nota4 + nota5;
            promedio = suma / 5;
            if (promedio<3)
            {
                Console.WriteLine("Reprobo");
            }else if(promedio>=3 && promedio < 4)
            {
                Console.WriteLine("Aprobo con nota baja");
            }
            else
            {
                Console.WriteLine("Aprobo");
            }
            Console.WriteLine("La suma es : "+suma);
            Console.WriteLine("El promedio es: "+promedio);

            // leer 3 numeros y que  el programa nos de el menor de los 3
            // leer un numero y que nos diga si es par o impar
            // ingresar un numero y decir si es positivo o negativo
        }
    }
}
