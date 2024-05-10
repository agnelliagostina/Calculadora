namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CALCULADORA";
            //Introduce el primer valor
            Console.WriteLine("Ingrese un valor:");
            string valorUno;
            valorUno = Console.ReadLine();
            int valorIngresado1 = int.Parse(valorUno);

            //Introduce el segundo valor
            Console.WriteLine("Ingrese el segundo valor:");
            string valorDos;
            valorDos = Console.ReadLine();
            int valorIngresado2 = int.Parse(valorDos);

            ////Introduce la operación a realizar
            Console.WriteLine("Ingrese operación: \n suma = sum \n resta = res \n multiplicación = mul \n división = div");
            string operacion;
            operacion = Console.ReadLine();

            //Realiza la operación indicada y muestra el resultado en pantalla
            Console.WriteLine("Resultado:");

            
            if (operacion == "sum")
            {
                Console.WriteLine(valorIngresado1 + valorIngresado2);
            }
            if (operacion == "res")
            {
                Console.WriteLine(valorIngresado1 - valorIngresado2);
            }
            if (operacion == "mul")
            {
                Console.WriteLine(valorIngresado1 * valorIngresado2);
            }
            if (operacion == "div")
            {
                if (valorIngresado2 > 0)
                    Console.WriteLine(valorIngresado1 / valorIngresado2);
                else
                {
                    Console.WriteLine("El segundo valor ingresado debe ser mayor a 0");
                }
            }
          
            

            if (operacion != "sum")
            {
                Console.WriteLine("Operación no válida");
            }
            if (operacion != "res")
            {
                Console.WriteLine("Operación no válida");
            }
            if (operacion != "mul")
            {
                Console.WriteLine("Operación no válida");
            }
            if (operacion != "div")
            {
                Console.WriteLine("Operación no válida");
            }

            

            //Console.Clear();

        }
    }
}
