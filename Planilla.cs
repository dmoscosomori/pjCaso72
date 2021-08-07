using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCaso72
{
    public class Planilla
    {
        // Atributos
        public string empleado { get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int años { get; set; }

        // Metodos
        public int añosServicio()
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }

        public string mesConsultado()
        {
            int mes = DateTime.Now.Month;
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Setiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
            }
            return "";
        }
        // Determinar el sueldo basico
        public double determinaBasico()
        {
            switch (cargo)
            {
                case "Coordinador": return 2000;
                case "Jefe": return 4000;
                case "Capacitador": return 2500;
                case "Asistente": return 1200;
            }
            return 0;
        }
        // Dterminar el monto de gratificacion
        public double determinaGratificacion()
        {
            if (mesConsultado() == "Abril")
                return 400;
            else if (mesConsultado() == "Julio")
                return 450;
            else if (mesConsultado() == "Diciembre")
                return determinaBasico() * 2;
            return 0;
        }
        // Determina la comision
        public double determinaComision()
        {
            if (cargo == "Asistente")
                return 100;
            else if (cargo == "Coordinador")
                return 250;
            return 0;
        }
        // Dtermina el descuento AFP
        public double determinaDescuentoAFP()
        {
            return 0.12 * determinaBasico();
        }

        // Determina el descuento por Cooperativa
        public double determinaDescuentoCooperativa()
        {
            if (cargo == "Jefe")
                return 5.0 / 100 * determinaBasico();
            else if (cargo == "Capacitador")
                return 2.0 / 100 * determinaBasico();
            return 0;
        }
        // Determina aportaciones por seguro social
        public double determinaAportacionSeguro()
        {
            return 0.05 * determinaBasico();
        }
        // Calculando los totales
        public double calculaTotalIngresos()
        {
            return determinaBasico() + determinaGratificacion() + determinaComision();
        }
        public double calculaTotalDescuento()
        {
            return determinaDescuentoAFP() + determinaDescuentoCooperativa();
        }
        public double calculaTotalAportaciones()
        {
            return determinaAportacionSeguro();
        }
        // Determina el total neto
        public double determinaNeto()
        {
            return calculaTotalIngresos() - calculaTotalDescuento() - calculaTotalAportaciones();
        }
    }
}
