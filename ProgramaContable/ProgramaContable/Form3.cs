using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ProgramaContable
{
    public partial class Form3 : Form
    {
        private string tipo = "activo";
        private LibroMayor libroMayor;
        public Form3(LibroMayor libroMayor)
        {
            InitializeComponent();
            SerialArch serial = new SerialArch();
            
            this.libroMayor = libroMayor;
            cuenta.Visible = false;
            Debe.Visible = false;
            Haber.Visible = false;
            Console.WriteLine(desde.Value);
            try
            {
                desde.Value = DateTime.Now.AddDays(-1);
            }
            catch (Exception e)
            {
            }
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void ActivoButton_CheckedChanged(object sender, EventArgs e)
        {
            ListaPatrimonio.Text = "";
            ListaPatrimonio.DataSource = Tipo.activo;
            tipo = "activo";
            actualizarLibro();
            
        }

        private void PasivoButton_CheckedChanged(object sender, EventArgs e)
        {
            ListaPatrimonio.Text = "";
            ListaPatrimonio.DataSource = Tipo.pasivo;
            tipo = "pasivo";
            actualizarLibro();
        }

        private void RPButton_CheckedChanged(object sender, EventArgs e)
        {
            ListaPatrimonio.Text = "";
            ListaPatrimonio.DataSource = Tipo.RPositivo;
            tipo = "RP";
            actualizarLibro();
        }

        private void RNButton_CheckedChanged(object sender, EventArgs e)
        {
            ListaPatrimonio.Text = "";
            ListaPatrimonio.DataSource = Tipo.RNegativo;
            tipo = "RN";
            actualizarLibro();
        }

        private void PatrimonioButton_CheckedChanged(object sender, EventArgs e)
        {
            ListaPatrimonio.Text = "";
            ListaPatrimonio.DataSource = Tipo.Patrimonio;
            tipo = "patrimonio";
            actualizarLibro();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void actualizarLibro()
        {
            string c = ListaPatrimonio.SelectedItem.ToString();
            cuenta.Text = c;
            List<TiposDeCuentas> cuetasDebe = libroMayor.cuentasDebe(c,tipo,desde.Value,hasta.Value);
            List<TiposDeCuentas> cuetasHaber = libroMayor.cuentasHaber(c,tipo,desde.Value,hasta.Value);
            List<string> nombrecuentasDebe = new List<string>();
            List<string> nombrecuentasHaber = new List<string>();
            double saldoDebe = 0;
            double saldoHaber = 0;
            foreach (var cuen in cuetasDebe)
            {
                saldoDebe += cuen.valor;
                nombrecuentasHaber.Add("");
                nombrecuentasDebe.Add(   cuen.nombreOperacion + ": " + cuen.valor.ToString());
            }
            foreach (var cuen in cuetasHaber)
            {
                saldoHaber += cuen.valor;
                nombrecuentasHaber.Add(cuen.nombreOperacion + ": " + cuen.valor.ToString());
            }

            SalDebe.Text = saldoDebe.ToString();
            SalHaber.Text = saldoHaber.ToString();
            double total = 0;
            if (saldoDebe > saldoHaber)
            {
                total = saldoDebe - saldoHaber;
                SalTotal.Text = "Saldo Deudor: " + total;
                
            }else if (saldoDebe < saldoHaber)
            {
                total = saldoHaber - saldoDebe;
                SalTotal.Text = "Saldo Acreedor: " + total;
            }
            else
            {
                SalTotal.Text = "Saldo Neutro";
            }
            Debe.DataSource = nombrecuentasDebe;
            Haber.DataSource = nombrecuentasHaber;
        }
        private void ListaPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuenta.Visible = true;
            Debe.Visible = true;
            Haber.Visible = true;
            actualizarLibro();
        }

        private void desde_ValueChanged(object sender, EventArgs e)
        {
            actualizarLibro();
        }

        private void hasta_ValueChanged(object sender, EventArgs e)
        {
            actualizarLibro();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}