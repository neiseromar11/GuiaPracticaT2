using GuiaPracticaT2.biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPracticaT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            float sumaSuBr, sumaDscto, sumaSuNet;
            string[] categoria;
            float[] sueldoBruto, tarifa, descuento, sueldoNeto;
            int[] horasTrabajadas;
            calculos.CabeceraDePagina(out cantidad, out sumaSuBr, out sumaDscto, out sumaSuNet, out categoria, out sueldoBruto, out horasTrabajadas, out tarifa, out descuento, out sueldoNeto);

            calculos.PieDePagina(cantidad, sumaSuBr, sumaDscto, sumaSuNet, categoria, sueldoBruto, horasTrabajadas, tarifa, descuento, sueldoNeto);
        }

      
    }
    
}
