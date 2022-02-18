using System;

namespace clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // herencia y clases derivadas 
            // en c# es posible heredar campos y metodos de una clase a otra 
            // clase derivada : (hijos) la clase hereda de una clase padre
            //clase base que es la clase padre 
            // para heredar en una clase : 
            Carro carro1 = new Carro();
            avion avion1 = new avion();
            Console.WriteLine(carro1.Marca+" "+carro1.modelo);
            carro1.bocina();
            avion1.aterrizar();
            avion1.despegar();
            // ¿por que y cuando utilizar la herencia 
            // es util para reutilizacion de codigo campos y metos 
            // de una clase existente  
            // Nota: muy de la mano con el polimorfismo
        }
    }
}
