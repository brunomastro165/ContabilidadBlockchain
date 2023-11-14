using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramaContable
{
    
    [Serializable]
    
    public class Block
    {
        public string Descripcion;
        public DateTime Fecha;

        public long Id { get; set; }
        public DateTime Timestamp { get; set; }
        public LibroDiario Cuentas { get; set; }
        public string Hash { get; set; }
        public string PreviousHash { get; set; }
        
        public int Proof { get; set; }

        public Block(int index, LibroDiario libro, string previousHash, String descripcion, DateTime fecha)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Id = index;
            //Cuentas = cuentas != null ? cuentas.ToArray() : new TiposDeCuentas[0];
            Cuentas = libro;
            Timestamp = DateTime.Now;
            PreviousHash = previousHash;
        }
        
        // Creamos la minería
        #region Mining

        public bool HashIsValid(string text,int difficulty)
        {
            string hash = Hashh.CalculateHash(text);
            string zeros = string.Empty.PadLeft(difficulty, '0');

            return hash.StartsWith(zeros);
        }

        public int MineBlock(int difficulty)
        {
            string initialText = string.Format("{0}{1}", Id, Timestamp);
            Proof = 0;
            string text = string.Format("{0}{1}", initialText, Proof);

            while (!HashIsValid(text, difficulty))
            {
                Proof++;
                text = string.Format("{0}{1}", initialText, Proof);
            }

            Hash = Hashh.CalculateHash(text);

            return Proof;
        }
        
        #endregion Mining
    }
}