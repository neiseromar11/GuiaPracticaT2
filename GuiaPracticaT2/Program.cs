using GuiaPracticaT2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Clase;
namespace GuiaPracticaT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            int cantidad;
            float sumaSuBr, sumaDscto, sumaSuNet;
            string[] categoria;
            float[] sueldoBruto, tarifa, descuento, sueldoNeto;
            int[] horasTrabajadas;
            // Funcion Cabecera de pagina 
            calculos.CabeceraDePagina(out cantidad, out sumaSuBr, out sumaDscto, out sumaSuNet, out categoria, out sueldoBruto, out horasTrabajadas, out tarifa, out descuento, out sueldoNeto);
            //Funcion pie de pagina 
            calculos.PieDePagina(cantidad, sumaSuBr, sumaDscto, sumaSuNet, categoria, sueldoBruto, horasTrabajadas, tarifa, descuento, sueldoNeto);
        }

      
    }
    
}
