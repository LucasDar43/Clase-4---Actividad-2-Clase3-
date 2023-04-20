using System;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = PedirNumero("Ingrese el valor de a: ");
            double b = PedirNumero("Ingrese el valor de b: ");
            double c = PedirNumero("Ingrese el valor de c: ");

            double discriminante = CalcularDiscriminante(a, b, c);

            if (discriminante > 0)
            {
                double[] raices = CalcularRaices(a, b, discriminante);
                Console.WriteLine("Las raíces son: " + raices[0].ToString("0.00") + " y " + raices[1].ToString("0.00"));
            }
            else if (discriminante == 0)
            {
                double raiz = CalcularRaizUnica(a, b);
                Console.WriteLine("La raíz es: " + raiz.ToString("0.00"));
            }
            else
            {
                string[] raices = CalcularRaicesComplejas(a, b, discriminante);
                Console.WriteLine("Las raíces son complejas: " + raices[0] + " y " + raices[1]);
            }

            Console.WriteLine("Gracias por utilizar el programa para calcular las raíces de una ecuación de segundo grado. ¡Hasta luego!");
        }

        static double CalcularDiscriminante(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static double[] CalcularRaices(double a, double b, double discriminante)
        {
            double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            return new double[] { raiz1, raiz2 };
        }

        static double CalcularRaizUnica(double a, double b)
        {
            return -b / (2 * a);
        }

        static string[] CalcularRaicesComplejas(double a, double b, double discriminante)
        {
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
            string raiz1 = parteReal.ToString("0.00") + " + " + parteImaginaria.ToString("0.00") + "i";
            string raiz2 = parteReal.ToString("0.00") + " - " + parteImaginaria.ToString("0.00") + "i";
            return new string[] { raiz1, raiz2 };
        }

        static double PedirNumero(string mensaje)
        {
            double numero;

            while (true)
            {
                Console.Write(mensaje);

                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor numérico válido.");
                }
            }
        }
    }
}
 


