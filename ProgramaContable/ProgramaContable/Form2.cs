using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;
using static ProgramaContable.Form1;

namespace ProgramaContable
{
    public partial class Form2 : Form
    {
        private LibroDiario libroDiario;
        private LibroMayor libroMayor;
        BoolWrapper libroCreado;
        SerialArch serial;
        Blockchain blockchain;
        
        public Form2(LibroDiario libroDiario, LibroMayor libroMayor, BoolWrapper libroCreado)
        {
            InitializeComponent();
            this.libroDiario = libroDiario;
            this.libroMayor = libroMayor;
            this.libroCreado = libroCreado;
           
            
            
            Console.WriteLine(libroCreado);
            
            CrearLD.Visible = false;
            Aviso.Text = "Aún no se agregan cuentas al libro diario";
           // DateTime inicio = new DateTime();
            
            iniciarLista(libroDiario);

            if (libroDiario.cuentas.Count>0)
            {
                if (libroDiario.balanceado())
                {
                    Aviso.Text = "El libro diario está balanceado";
                    CrearLD.Visible = true;
                }
                else
                {
                    Aviso.Text = "El libro diario no está balanceado";
                    CrearLD.Visible = false;
                }
            }
        }
        
        public string compararTipo(TiposDeCuentas cuenta)
        {
            if (cuenta.activo)
            {
                return "activo";
            }
            else if (cuenta.pasivo)
            {
                return "pasivo";
            }
            else if (cuenta.rPositivo)
            {
                return "RPositivo";
            }
            else if (cuenta.rNegativo)
            {
                return "RNegativo";
            }
            else if (cuenta.patrimonio)
            {
                return "Patrimonio";
            }

            return "indefinido";
        }

        public bool debeHaber(TiposDeCuentas cuenta)
        {
            if (cuenta.activo)
            {
                if (cuenta.subeOBaja)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (cuenta.pasivo)
            {
                if (cuenta.subeOBaja)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (cuenta.rPositivo)
            {
                return false;
            }
            else if (cuenta.rNegativo)
            {
                return true;
            }
            else if (cuenta.patrimonio)
            {
                if (cuenta.subeOBaja)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            throw new Exception("No se reconoce el tipo de operación");
        }

        public void iniciarLista(LibroDiario libroDiario)
        {
            ListaNombre.SelectionMode = SelectionMode.None;
            ListaClasificacion.SelectionMode = SelectionMode.None;
            ListaTipo.SelectionMode = SelectionMode.None;
            ListaDebe.SelectionMode = SelectionMode.None;
            ListaHaber.SelectionMode = SelectionMode.None;
            
            List<string> nombre = new List<string>();
            List<string> tipo = new List<string>();
            List<string> monto = new List<string>();
            List<string> clasificacion = new List<string>();
            List<string> debe = new List<string>();
            List<string> haber = new List<string>();
            
            
            foreach (var i in libroDiario.cuentas)
            {
                nombre.Add(i.nombreOperacion);
                tipo.Add(i.tipoOperacion);
              //  monto.Add(i.valor.ToString());
                clasificacion.Add(compararTipo(i));
                
                if (debeHaber(i))
                {
                   debe.Add(i.valor.ToString());
                   haber.Add("");
                }
                else
                {
                    haber.Add(i.valor.ToString());
                    debe.Add("");
                }
            }

            ListaNombre.DataSource = nombre;
            ListaTipo.DataSource = tipo;
            ListaClasificacion.DataSource = clasificacion;
            ListaDebe.DataSource = debe;
            ListaHaber.DataSource = haber;

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        private void ListaNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CrearLD_Click(object sender, EventArgs e)
        {
           libroDiario.fecha = Fecha.Value;
            
           ListaNombre.DataSource = null;
           ListaTipo.DataSource = null;
           ListaClasificacion.DataSource = null;
           ListaDebe.DataSource = null;
           ListaHaber.DataSource = null;
           
           ListaNombre.Refresh();
           ListaTipo.Refresh();
           ListaClasificacion.Refresh();
           ListaDebe.Refresh();
           ListaHaber.Refresh();


           libroCreado.Value = true;
           MessageBox.Show($"Se creó el libro diario, con fecha en {Fecha.Value}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
           
           Close();
        }
    }
}