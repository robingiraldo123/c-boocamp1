using System;

namespace clase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            // el switch se utiliza para seleccionar uno de muchos bloques de codigo que se ejecutan 
            int Dia = 6;
            switch (Dia)
            {
                case 1:
                    Console.WriteLine("El dia es lunes");
                    break;
                case 2:
                    Console.WriteLine("El dia es martes");
                    break;
                case 3:
                    Console.WriteLine("El dia es miercoles");
                    break;
                case 4:
                    Console.WriteLine("El dia es jueves");
                    break;
                case 5:
                    Console.WriteLine("El dia es viernes");
                    break;
                default:
                    Console.WriteLine("ese dia no existe");
                    break;
            }
            // expresion que evalua una sola vez
            // los valores son comparados cada case
            // si hay una coincidencia, se ejecuta el bloque de codigo asociado
            // las palabras clave break y default 
            if (Dia == 1)
            {
                Console.WriteLine("lunes");
            }
            else if (Dia == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (Dia == 3)
            {
                Console.WriteLine("miercoles");
            }
            else if (Dia == 4)
            {
                Console.WriteLine("jueves");
            }else if(Dia ==5)
            {
                Console.WriteLine("viernes");
            }
            else
            {
                Console.WriteLine("el dia no existe");
            }

            ///Menu
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|           1. suma                       |");
            Console.WriteLine("|           2.resta                       |");
            Console.WriteLine("|           3.Multiplicacion              |");
            Console.WriteLine("|           4.Division                    |");
            Console.WriteLine("|           5.salir                       |");
            Console.WriteLine("|-----------------------------------------|");
            int opc = Convert.ToInt32(Console.ReadLine());
            int num1,num2,respuesta;
            switch (opc)
            {
                case 1:
                    Console.WriteLine("ingrese 1r numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese 2d numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    respuesta = num1 + num2;
                    Console.WriteLine("la suma dio: "+respuesta);
                    break;
                case 2:
                    Console.WriteLine("ingrese 1r numero");
                     num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese 2d numero");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     respuesta = num1 - num2;
                    Console.WriteLine("la resta dio: " + respuesta);
                    break;
                case 3:
                    Console.WriteLine("ingrese 1r numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese 2d numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    respuesta = num1 * num2;
                    Console.WriteLine("la multiplicacion dio: " + respuesta);
                    break;
                case 4:
                    Console.WriteLine("ingrese 1r numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese 2d numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    respuesta = num1 / num2;
                    Console.WriteLine("la Division dio: " + respuesta);
                    break;
                case 5:
                    Console.WriteLine("sesion finalizada");
                    break;
                default:
                    Console.WriteLine("la opcion no es correcta");
                    break;
            }
            // palabra clave de descanso
            // break: detiene la ejecucuion y sale de bloque
            // cuando se encuentra una coincidencia 
            Console.WriteLine("ingresa el numero de celular");
            long numero = Convert.ToInt64(Console.ReadLine());
            string detalle="  ";
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|           1. paquetes                   |");
            Console.WriteLine("|           2.saldo,plan y consumo        |");
            Console.WriteLine("|           3.adelanta saldo              |");
            Console.WriteLine("|           4.paquetes de voz             |");
            Console.WriteLine("|           5.salir                       |");
            Console.WriteLine("|-----------------------------------------|");
            opc= Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Paquetes de datos");
                    Console.WriteLine("|-----------------------------------------|");
                    Console.WriteLine("|           1. paquetes datos             |");
                    Console.WriteLine("|           2. paquetes todo incluido     |");
                    Console.WriteLine("|           3. paquetes aplicaciones      |");
                    Console.WriteLine("|-----------------------------------------|");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("|-------------------------------|");
                            Console.WriteLine("|           1. 1 dia            |");
                            Console.WriteLine("|           2. 2 dias           |");
                            Console.WriteLine("|           3. 3 dias           |");
                            Console.WriteLine("|           4. 5 dias           |");
                            Console.WriteLine("|           5. 6 dias           |");
                            Console.WriteLine("|-------------------------------|");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("paquete de un dia activo");
                                    detalle = "paquete de un dia activo";
                                    break;
                                case 2:
                                    Console.WriteLine("paquete de 2 dias activo");
                                    detalle = "paquete de 2 dias activo";
                                    break;
                                case 3:
                                    Console.WriteLine("paquete de 3 dias activo");
                                    detalle = "paquete de 3 dias activo";
                                    break;
                                case 4:
                                    Console.WriteLine("paquete de 5 dias activo");
                                    detalle = "paquete de 5 dias activo";
                                    break;
                                case 5:
                                    Console.WriteLine("paquete de 6 dias activo");
                                    detalle = "paquete de 6 dias activo";
                                    break;
                                default:
                                    Console.WriteLine("opc ingresada incorrecta");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Paquetes todo incluido");
                            Console.WriteLine("|-------------------------------|");
                            Console.WriteLine("|           1. 2 dias            |");
                            Console.WriteLine("|           2. 6 dias           |");
                            Console.WriteLine("|           3. 7 dias           |");
                            Console.WriteLine("|           4. 10 dias          |");
                            Console.WriteLine("|           5. 20 dias          |");
                            Console.WriteLine("|-------------------------------|");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("paquete de 2 dias de plan de datos  activo");
                                    detalle = "paquete de 2 dias de plan de datos  activo";
                                    break;
                                case 2:
                                    Console.WriteLine("paquete de 6 dias de plan de datos  activo");
                                    detalle = "paquete de 6 dias de plan de datos  activo";
                                    break;
                                case 3:
                                    Console.WriteLine("paquete de 7 dias de plan de datos  activo");
                                    detalle = "paquete de 6 dias de plan de datos  activo";
                                    break;
                                case 4:
                                    Console.WriteLine("paquete de 10 dias de plan de datos  activo");
                                    detalle = "paquete de 10 dias de plan de datos  activo";
                                    break;
                                case 5:
                                    Console.WriteLine("paquete de 20 dias de plan de datos  activo");
                                    detalle = "paquete de 20 dias de plan de datos  activo";
                                    break;
                                default:
                                    Console.WriteLine("opc ingresada incorrecta");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Paquetes de aplicacioness");
                            Console.WriteLine("|-------------------------------|");
                            Console.WriteLine("|           1. 1  gb            |");
                            Console.WriteLine("|           2. 4  gb            |");
                            Console.WriteLine("|           3. 10 gb            |");
                            Console.WriteLine("|           4. 1 dia de waze    |");
                            Console.WriteLine("|           5. 15 dias whatsApp |");
                            Console.WriteLine("|-------------------------------|");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("paquete de 1 gb activo");
                                    detalle = "paquete de 1 gb activo";
                                    break;
                                case 2:
                                    Console.WriteLine("paquete de 4 gb activo");
                                    detalle = "paquete de 4 gb activo";
                                    break;
                                case 3:
                                    Console.WriteLine("paquete de 10 gb activas");
                                    detalle = "paquete de 10 gb activas";
                                    break;
                                case 4:
                                    Console.WriteLine("paquete de 1 dia de waze activo");
                                    detalle = "paquete de 1 dia de waze activo";
                                    break;
                                case 5:
                                    Console.WriteLine("15 dias whatsApp activo");
                                    detalle = "15 dias whatsApp activo";
                                    break;
                                default:
                                    Console.WriteLine("opc ingresada incorrecta");
                                    break;
                            }
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("linea "+numero);
                    Console.WriteLine("|-------------------------------|");
                    Console.WriteLine("|           1. saldo actual     |");
                    Console.WriteLine("|           2. detalle plan     |");
                    Console.WriteLine("|-------------------------------|");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            int saldo = 1000;
                            Console.WriteLine("El saldo es : "+saldo);
                            break;
                        case 2:
                            Console.WriteLine("El detalle de el plan es : "+detalle);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("|---------------------------------|");
                    Console.WriteLine("|           1. saldo              |");
                    Console.WriteLine("|           2. paquete datos      |");
                    Console.WriteLine("|           3. paquete facebook   |");
                    Console.WriteLine("|           4. paquete minutos    |");
                    Console.WriteLine("|---------------------------------|");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            int saldo = 1000;
                            Console.WriteLine("El saldo es : " + saldo);
                            break;
                        case 2:
                            Console.WriteLine("No puede adelantar paquetes de datos");
                            break;
                        case 3:
                            Console.WriteLine("adelanto facebook 1 dia");
                            break;
                        case 4:
                            Console.WriteLine("adelanto de minutos exitoso");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("PAQUETES DE VOZ");
                    Console.WriteLine("|-------------------------------------------|");
                    Console.WriteLine("|           1. PAQUETE DE VOZ               |");
                    Console.WriteLine("|           2. PAQUETE DE VOZ  REVENTA      |");
                    Console.WriteLine("|-------------------------------------------|");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Quiere activar el plan?");
                            string estado=Console.ReadLine();
                            if (estado == "si")
                            {
                                Console.WriteLine("plan activado");
                            }
                            else
                            {
                                Console.WriteLine("El plan no fue activado");
                            }
                      
                            break;
                        case 2:
                            Console.WriteLine("|-----------------------------------|");
                            Console.WriteLine("|           1. 15 mil               |");
                            Console.WriteLine("|           2. 30 mil               |");
                            Console.WriteLine("|-----------------------------------|");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("Quiere activar el plan de voz de 15 mil?");
                                    string estado1 = Console.ReadLine();
                                    if (estado1 == "si")
                                    {
                                        Console.WriteLine("plan activado");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El plan no fue activado");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Quiere activar el plan de voz de 30 mil?");
                                    string estado2 = Console.ReadLine();
                                    if (estado2 == "si")
                                    {
                                        Console.WriteLine("plan activado");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El plan no fue activado");
                                    }
                                    break;
                            }
                            break;
                    }
                break;
                case 5:
                    Console.WriteLine("Adios!");
                    break;
            }

        }
    }
}
