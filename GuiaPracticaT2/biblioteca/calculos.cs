using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPracticaT2.biblioteca
{
    internal class calculos
    {
        public static string ObtenerCategoria()
        {
            string categoria;
            do
            {
                categoria = Operaciones.getTextoPantalla("Ingrese categoria del trabajador (A, B, C o D): ");
            } while (categoria != "A" && categoria != "B" && categoria != "C" && categoria != "D");
            return categoria;
        }
        public static int ObtenerHorasTrabajadas()
        {
            int horasTrabajadas;
            do
            {
                Console.Write("Ingrese horas trabajadas: ");
            } while (!int.TryParse(Console.ReadLine(), out horasTrabajadas));
            return horasTrabajadas;
        }
        public static float CalcularSueldoBruto(string categoria, int horasTrabajadas)
        {
            float tarifa = 0f;
            switch (categoria)
            {
                case "A":
                    tarifa = 21.00f;
                    break;
                case "B":
                    tarifa = 19.50f;
                    break;
                case "C":
                    tarifa = 17.00f;
                    break;
                case "D":
                    tarifa = 15.50f;
                    break;
            }
            return tarifa * horasTrabajadas;
        }
        public static float CalcularDescuento(float sueldoBruto)
        {
            return (float)(sueldoBruto <= 2500 ? sueldoBruto * 0.15 : sueldoBruto * 0.20);
        }
        public static float CalcularSueldoNeto(float sueldoBruto, float descuento)
        {
            return sueldoBruto - descuento;
        }
          public static void PieDePagina(int cantidad, float sumaSuBr, float sumaDscto, float sumaSuNet, string[] categoria, float[] sueldoBruto, int[] horasTrabajadas, float[] tarifa, float[] descuento, float[] sueldoNeto)
        {
            Console.WriteLine("\nTrabajadores: \t" + cantidad);
            Console.WriteLine("\nTrab. " + $"{"HorasTrab",11}  {"Categoria",11}  {"Tarifa",14}  {"sBruto",18}  {"Dscto",13}  {"sNeto",14}" + "\n");

            for (int i = 0; i < cantidad; i++)
            {
                string formatString = i < 9 ? " {0,1}  {1,10}  {2,10}  {3,18:C}  {4,18:C}  {5,13:C}  {6,14:C}" : " {0,1}  {1,9}  {2,10}  {3,18:C}  {4,18:C}  {5,13:C}  {6,14:C}";
                Console.WriteLine(string.Format(formatString, i + 1, horasTrabajadas[i], categoria[i], tarifa[i], sueldoBruto[i], descuento[i], sueldoNeto[i]));
            }

            Console.WriteLine("\nTotal Sueldos Brutos: " + "{0, 17}", sumaSuBr.ToString("C"));
            Console.WriteLine("Total Descuentos: " + "{0, 21}", sumaDscto.ToString("C"));
            Console.WriteLine("Total Sueldos Netos: " + "{0, 18}", sumaSuNet.ToString("C"));
            Console.ReadLine();
        }
        public static void CabeceraDePagina(out int cantidad, out float sumaSuBr, out float sumaDscto, out float sumaSuNet, out string[] categoria, out float[] sueldoBruto, out int[] horasTrabajadas, out float[] tarifa, out float[] descuento, out float[] sueldoNeto)
        {
            sumaSuBr = 0;
            sumaDscto = 0;
            sumaSuNet = 0;
            do
            {
                Console.Write("Ingrese cantidad de trabajadores: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidad));

            categoria = new string[cantidad];
            sueldoBruto = new float[cantidad];
            horasTrabajadas = new int[cantidad];
            tarifa = new float[cantidad];
            descuento = new float[cantidad];
            sueldoNeto = new float[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                categoria[i] = calculos.ObtenerCategoria();
                horasTrabajadas[i] = calculos.ObtenerHorasTrabajadas();

                switch (categoria[i])
                {
                    case "A":
                        tarifa[i] = 21.00f;
                        break;
                    case "B":
                        tarifa[i] = 19.50f;
                        break;
                    case "C":
                        tarifa[i] = 17.00f;
                        break;
                    case "D":
                        tarifa[i] = 15.50f;
                        break;
                }

                sueldoBruto[i] = calculos.CalcularSueldoBruto(categoria[i], horasTrabajadas[i]);
                descuento[i] = calculos.CalcularDescuento(sueldoBruto[i]);
                sueldoNeto[i] = calculos.CalcularSueldoNeto(sueldoBruto[i], descuento[i]);

                sumaDscto += descuento[i];
                sumaSuBr += sueldoBruto[i];
                sumaSuNet += sueldoNeto[i];
            }
        }

    }
}
