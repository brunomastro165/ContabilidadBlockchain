using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramaContable
{
    [Serializable]
    public class LibroDiario
    {
        
        
        public List<TiposDeCuentas> cuentas = new List<TiposDeCuentas>();
        public DateTime fecha;
        public double debe;
        public double haber;

        public string Hash
        {
            get { return Hashh.CalculateHash(string.Format("{0}{1}{2}{3}", fecha, debe, haber, cuentas)); }
        }
        
        public LibroDiario(List<TiposDeCuentas> cuentas, DateTime fecha)
        {
            this.cuentas = cuentas;
            this.fecha = fecha;
        }
        
        public LibroDiario()
        {
            
        }

        public void balanceDebeyHaber(ref double debe, ref double haber)
        {
            this.debe = 0;
            this.haber = 0;
            foreach (var cuenta in cuentas)
            {
                if (cuenta.activo)
                {
                    if (cuenta.subeOBaja)
                    {
                        debe += cuenta.valor;
                    }
                    else
                    {
                        haber += cuenta.valor;
                    }
                }

                if (cuenta.pasivo)
                {
                    if (!cuenta.subeOBaja)
                    {
                        debe += cuenta.valor;
                    }
                    else
                    {
                        haber += cuenta.valor;
                    }

                }

                if (cuenta.patrimonio)
                {
                    if (!cuenta.subeOBaja)
                    {
                        debe += cuenta.valor;
                    }
                    else
                    {
                        haber += cuenta.valor;
                    }
                }

                if (cuenta.rPositivo)
                {
                    /*
                    if (!cuenta.subeOBaja)
                    {
                        debe += cuenta.valor;
                    }
                    else
                    {
                        haber += cuenta.valor;
                    }
                    */
                    haber += cuenta.valor;
                }

                if (cuenta.rNegativo)
                {
                    /*
                    if (cuenta.subeOBaja)
                    {
                        debe += cuenta.valor;
                    }
                    else
                    {
                        haber += cuenta.valor;
                    }
                    */
                    debe += cuenta.valor;

                }
            }

        }

        public bool balanceado()
        {
            balanceDebeyHaber(ref this.debe, ref this.haber);
            if (this.debe == this.haber)
            {
                return true;
            }

            return false;
        }

    }
}