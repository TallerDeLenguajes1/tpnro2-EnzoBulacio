using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class datos
    {
        string nombre;
        string apellido;
        int antiguedad;
        double salario;
        DateTime fDeNac;
        DateTime fechaEnLaEmpresa;

        public int calcularAntiguedad(DateTime fechaEnLaEmpresa)
        {
            return DateTime.Now.Year - this.fechaEnLaEmpresa.Year;
        }
        public int calcularEdad(DateTime edad)
        {
            return DateTime.Now.Year - this.fDeNac.Year;
        }
        public double Csalario()
        {
            Random ra = new Random();
            salario= ra.Next(0,50000);
            Console.WriteLine("Sueldo bruto: " + this.salario);
            int adicional = calcularAntiguedad(this.fechaEnLaEmpresa) / 100;
            double descuento = 0.15;
            if (adicional >= 20)
            {
                return salario + (this.salario * 0.25) - (this.salario * descuento);
            }
            else
            {
                return salario + this.salario * adicional - this.salario * descuento;
            }
        }
        public void CarEmp()
        {
            string[] nombre = { "Brenda", "Carlos", "Ailen" };
            string[] apellido = { "Garcia", "Martinez", "Ponce" };
            Random rand = new Random();
            this.nombre = nombre[rand.Next(nombre.Length)];
            this.apellido = apellido[rand.Next(apellido.Length)];
            fDeNac = Help.FechaA(100);
            fechaEnLaEmpresa = Help.FechaA(100);
        }
        public void Mostrar()
        {
            Console.WriteLine($"{this.apellido},{this.nombre}\nSalario: {this.Csalario()};   ");
        }
    }
}
