using System;

namespace ProgramaContable
{
    
    [Serializable]
    public class TiposDeCuentas
    {
        public string nombreOperacion { get; set; }
        public bool activo { get; set; }
        public bool pasivo { get; set; }
        public bool patrimonio { get; set; }
        public bool rPositivo { get; set; }
        public bool rNegativo { get; set; }
        
        
        //Cambios 
        public string tipoOperacion;
        
        public double valor { get; set; }
        
        public bool subeOBaja { get; set; } 
        
        public TiposDeCuentas(string tipoOperacion, double valor, bool subeOBaja, string nombreOperacion,
            bool activo, bool pasivo, bool patrimonio, bool rPositivo, bool rNegativo)
        {
            this.tipoOperacion = tipoOperacion;
            this.valor = valor;
            this.subeOBaja = subeOBaja;
            this.nombreOperacion = nombreOperacion;
            this.activo = activo;
            this.pasivo = pasivo;
            this.patrimonio = patrimonio;
            this.rPositivo = rPositivo;
            this.rNegativo = rNegativo;
        }
    }
}