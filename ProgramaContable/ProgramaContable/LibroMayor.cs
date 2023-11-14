using System;
using System.Collections.Generic;

namespace ProgramaContable
{
    [Serializable]
    public class LibroMayor
    {
        public List<TiposDeCuentas> cuentas = new List<TiposDeCuentas>();
        public List<LibroDiario> librosDiarios;

        public LibroMayor(List<LibroDiario>librosDiarios)
        {
            this.librosDiarios = librosDiarios;
        }

        public List<TiposDeCuentas> cuentasDebe(string Tipo,string clasificacion,DateTime desde,DateTime hasta)
        {
            
            List<TiposDeCuentas> debe = new List<TiposDeCuentas>();
            Console.WriteLine(clasificacion);
            switch (clasificacion)
            {
                case "activo":
                    
                    foreach (var libroDiario in librosDiarios)
                    {
                        
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.activo && cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    debe.Add(cuenta);
                                }
                            
                            }
                        }
                        
                    }
                    break;
                case "pasivo":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.pasivo && !cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    debe.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "RP":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.rPositivo && !cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    debe.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "RN":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.rNegativo && cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    debe.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "patrimonio":
                        foreach (var libroDiario in librosDiarios)
                        {
                            if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                            {
                                foreach (var cuenta in libroDiario.cuentas)
                                {
                                    if (cuenta.patrimonio && cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                    {
                                        debe.Add(cuenta);
                                    }
                                }
                            }
                        }
                        break;
            }
            return debe; 
        }
        public List<TiposDeCuentas> cuentasHaber(string Tipo,string clasificacion,DateTime desde,DateTime hasta)
        {
            List<TiposDeCuentas> haber = new List<TiposDeCuentas>();
            switch (clasificacion)
            {
                case "activo":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.activo && !cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    haber.Add(cuenta);
                                }
                            }
                        }
                        
                    }
                    break;
                case "pasivo":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.pasivo && cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    haber.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "RP":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.rPositivo && cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    haber.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "RN":
                    foreach (var libroDiario in librosDiarios)
                    {
                        if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                        {
                            foreach (var cuenta in libroDiario.cuentas)
                            {
                                if (cuenta.rNegativo && !cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                {
                                    haber.Add(cuenta);
                                }
                            }
                        }
                    }
                    break;
                case "patrimonio":
                        foreach (var libroDiario in librosDiarios)
                        {
                            if (libroDiario.fecha <= hasta && libroDiario.fecha >= desde)
                            {
                                foreach (var cuenta in libroDiario.cuentas)
                                {
                                    if (cuenta.patrimonio && !cuenta.subeOBaja && cuenta.tipoOperacion == Tipo)
                                    {
                                        haber.Add(cuenta);
                                    }
                                }
                            }
                        }
                        break;
            }
            return haber; 
        }
        
        
    }
}