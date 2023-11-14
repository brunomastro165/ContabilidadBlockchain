using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProgramaContable
{
    public class SerialTipo
    {
        
        #region Guardar
        
        public static void GuardarActivo(List<string> activo)
        {
            activo.Sort();
            File.WriteAllText("activo.json", JsonConvert.SerializeObject(activo, Formatting.Indented));
        }
        
        public static void GuardarPasivo(List<string> pasivo)
        {
            pasivo.Sort();
            File.WriteAllText("pasivo.json", JsonConvert.SerializeObject(pasivo, Formatting.Indented));
        }

        public static void GuardarRPositivo(List<string> rpositivo)
        {
            rpositivo.Sort();
            File.WriteAllText("rpositivo.json", JsonConvert.SerializeObject(rpositivo, Formatting.Indented));
        }

        public static void GuardarRNegativo(List<string> rnegativo)
        {
            rnegativo.Sort();
            File.WriteAllText("rnegativo.json", JsonConvert.SerializeObject(rnegativo, Formatting.Indented));
        }

        public static void GuardarPatrimonio(List<string> patrimonio)
        {
            patrimonio.Sort();
            File.WriteAllText("patrimonio.json", JsonConvert.SerializeObject(patrimonio, Formatting.Indented));
        }

        #endregion Guardar
        
        #region Leer

        public static List<string> LeerActivo()
        {
            List<string> activo = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("activo.json"));
            activo.Sort();
            return activo;
        }
        
        public static List<string> LeerPasivo()
        {
            List<string> pasivo = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("pasivo.json"));
            pasivo.Sort();
            return pasivo;
        }

        public static List<string> LeerRPositivo()
        {
            List<string> rpositivo = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("rpositivo.json"));
            rpositivo.Sort();
            return rpositivo;
        }

        public static List<string> LeerRNegativo()
        {
            List<string> rnegativo = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("rnegativo.json"));
            rnegativo.Sort();
            return rnegativo;
        }

        public static List<string> LeerPatrimonio()
        {
            List<string> patrimonio = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("patrimonio.json"));
            patrimonio.Sort();
            return patrimonio;
        }
        
        #endregion Leer
    }
}