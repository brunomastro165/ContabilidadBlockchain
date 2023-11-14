using System;
using System.Collections.Generic;

namespace ProgramaContable
{
    
    [Serializable]
    public class Tipo
    {
        public static List<string> activo = new List<string>()
        {
            "Caja",
            "Banco X, cta. cte.",
            "Deudores por venta",
            "Cheques diferidos a cobrar",
            "Alquileres a cobrar",
            "Deudores varios",
            "Mercaderías",
            "Rodados",
            "Muebles y utiles",
            "Instalaciones"
        };
        
        public static List<string> pasivo = new List<string>()
        {
            "Proveedores",
            "Documentos a pagar",
            "Cheques a pagar",
            "Intereses a pagar",
            "Acreedores varios",
            "Alquileres a pagar",
            "Sueldos y jornales a pagar",
            "Seguros a pagar",
            "Gastos a pagar",
            "Impuestos a pagar"
        };
        
        public static List<string> RNegativo = new List<string>()
        {
            "Costo de mercaderías vendidas",
            "Sueldos y jornales",
            "Alquileres perdidos",
            "Intereses perdidos",
            "Seguros",
            "Impuestos",
            "Fletes y acarreos",
            "Publicidad y propaganda",
            "Gastos generales",
            "Publicidad perdida"
        };
        
        public static List<string> RPositivo = new List<string>()
        {
            "Venta de mercadería",
            "Intereses ganados",
            "Alquileres ganados",
            "Comisiones ganadas",
            "Descuentos obtenidos",
            "Donaciones recibidas"
        };
        
        public static List<string> Patrimonio = new List<string>()
        {
            "Capital social",
            "Aporte de socio"
        };
    }
}