using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadOperarios = 0;
            int cantidadTecnicos = 0;
            int cantidadProfesionales = 0;

            double acumuladorOperarios = 0;
            double acumuladorTecnicos = 0;
            double acumuladorProfesionales = 0;

            string continuar;

            do
            {
                Console.Write("Cédula: ");
                string cedula = Console.ReadLine();

                Console.Write("nOMBRE del empleado: ");
                string nombre = Console.ReadLine();

                int tipo;
                do
                {
                    Console.Write("Tipo empleado (1. Operario, 2. Técnico, 3. Profesional): ");
                    tipo = int.Parse(Console.ReadLine());
                } while (tipo < 1 || tipo > 3);

                Console.Write("Cantidad de horas laboradas: ");
                double horas = double.Parse(Console.ReadLine());

                Console.Write("Precio por hora: ");
                double precioHora = double.Parse(Console.ReadLine());

                double salarioOrdinario = horas * precioHora;
                double aumento = 0;

                switch (tipo)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15;
                        cantidadOperarios++;
                        acumuladorOperarios += (salarioOrdinario + aumento);
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10;
                        cantidadTecnicos++;
                        acumuladorTecnicos += (salarioOrdinario + aumento);
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05;
                        cantidadProfesionales++;
                        acumuladorProfesionales += (salarioOrdinario + aumento);
                        break;
                }

                double salarioBruto = salarioOrdinario + aumento;
                double deducción = salarioBruto * 0.0917;
                double salarioNeto = salarioBruto - deducción;

                Console.WriteLine("DETALLE DEL EMPLEADO");
                Console.WriteLine("cEDULA: " + cedula);
                Console.WriteLine("Nombre del empleado: " + nombre);
                Console.WriteLine("Tipo de empleado: " + tipo);
                Console.WriteLine("Salario por hora: " + precioHora);
                Console.WriteLine("Cantidad de horas: " + horas);
                Console.WriteLine("Salario ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario bruto: " + salarioBruto);
                Console.WriteLine("Deducción CCSS: " + deducción);
                Console.WriteLine("Salario neto: " + salarioNeto);

                Console.WriteLine("\n¿Desea ingresar otro empleado? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s");

            Console.WriteLine("\nESTADISTICA.");

            Console.WriteLine("\nTIPO OPERARIOS.");
            Console.WriteLine("1. Cantidad de empleados tipo operario: " + cantidadOperarios);
            Console.WriteLine("2. Salario neto empleados tipo operarios; " + acumuladorOperarios);
            Console.WriteLine("3. Promedio de salarios tipo operario: " + (acumuladorOperarios / cantidadOperarios));
            
            Console.WriteLine("\nTIPO Tecnicos.");
            Console.WriteLine("1. Cantidad de empleados tipo técnicos: " + cantidadTecnicos);
            Console.WriteLine("2. Salario neto empleados tipo técnicos; " + acumuladorTecnicos);
            Console.WriteLine("3. Promedio de salarios tipo técnicos: " + (acumuladorTecnicos / cantidadTecnicos));
            
            Console.WriteLine("\nTIPO PROFESIONAL.");
            Console.WriteLine("1. Cantidad de empleados tipo profesional: " + cantidadProfesionales);
            Console.WriteLine("2. Salario neto empleados tipo profesional: " + acumuladorProfesionales);
            Console.WriteLine("3. Promedio de salarios tipo profesional: " + (acumuladorProfesionales / cantidadProfesionales));
            
            Console.WriteLine("FIN");
        }
    }
}
