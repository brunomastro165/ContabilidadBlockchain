using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramaContable
{

    [Serializable]

    public class Blockchain
    {
        public List<Block> Blocks { get; set; }
        public List<TiposDeCuentas> TempTiposDeCuentas { get; set; }

        public LibroDiario TempLibroDiario { get; set; }

        public const int Difficulty = 4;

        public Blockchain()
        {
            Blocks = new List<Block>();
            TempTiposDeCuentas = new List<TiposDeCuentas>();
        }

        public void NewTiposDeCuentas(string tipoOperacion, double valor, bool subeObaja, string nombreOperacion,
            bool activo, bool pasivo, bool patrimonio, bool rPositivo, bool rNegativo)
        {
            TiposDeCuentas newTipoDeCuenta = new TiposDeCuentas(tipoOperacion, valor, subeObaja, nombreOperacion,
                activo, pasivo, patrimonio, rPositivo, rNegativo);
            TempTiposDeCuentas.Add(newTipoDeCuenta);
        }

        public void NewLibroDiario(LibroDiario libroDiario)
        {
            TempLibroDiario = libroDiario;
            
        }
        
        public void NewBlock(DateTime fecha, String descripcion)
        {
            string previousHash = string.Empty;
            if (Blocks.Count > 0)
            {
                previousHash = Blocks[Blocks.Count - 1].Hash;
            }

            Block newBlock = new Block(Blocks.Count, TempLibroDiario, previousHash, descripcion, fecha);
            newBlock.MineBlock(Difficulty);
            Blocks.Add(newBlock);
            TempTiposDeCuentas = new List<TiposDeCuentas>();
        }
    }
}