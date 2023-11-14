using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable
{
    
    public class BoolWrapper
    {
        public bool Value { get; set; }
    }
    
    

    public partial class Form1 : Form
    {
        bool DH = false;
        LibroDiario libroDiario;
        LibroMayor libroMayor;
        List<LibroDiario> librosDiarios;
        BoolWrapper libroCreado;
        SerialArch serial;
        Blockchain blockchain;
        public Form1()
        {
            InitializeComponent();
            //Leer blockchain
            serial = new SerialArch();
            blockchain = new Blockchain();
            blockchain = serial.LeerCadena();
            libroDiario = new LibroDiario();
            librosDiarios = new  List<LibroDiario>();

            for (int i = 0; i < blockchain.Blocks.Count; i++)
            {
                librosDiarios.Add(blockchain.Blocks[i].Cuentas);
            }
            
            libroMayor = new LibroMayor(librosDiarios);
            
            libroCreado = new BoolWrapper();
            
            
            Console.WriteLine(blockchain.Blocks.Count);
            
            
            if (blockchain.Blocks.Count == 0) /* Si se inicia por primera vez el programa y no hay bloques creados
            en la Blockchain, se guardan los archivos .json con las List<string> predefinidas
            */
            {
                SerialTipo.GuardarPasivo(Tipo.pasivo);
                SerialTipo.GuardarActivo(Tipo.activo);
                SerialTipo.GuardarRNegativo(Tipo.RNegativo);
                SerialTipo.GuardarRPositivo(Tipo.RPositivo);
                SerialTipo.GuardarPatrimonio(Tipo.Patrimonio);
            }
            else  // Hacemos que los Tipo.List<string> se conviertan en su Leer ya modificado
            {
                Tipo.activo = SerialTipo.LeerActivo();
                Tipo.pasivo = SerialTipo.LeerPasivo();
                Tipo.RNegativo = SerialTipo.LeerRNegativo();
                Tipo.RPositivo = SerialTipo.LeerRPositivo();
                Tipo.Patrimonio = SerialTipo.LeerPatrimonio();
            }

            //Setear visibilidad inicial de las listas
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaRP.Visible = false;
            ListaRN.Visible = false;
            ListaPatrimonio.Visible = false;

            AgregarListaButton.Visible = false;
            EliminarButton.Visible = false;
            AgregarTextBox.Visible = false;
            
            //Agrego las listas al código
            ListaActivos.DataSource = Tipo.activo;
            ListaPasivos.DataSource = Tipo.pasivo;
            ListaRP.DataSource = Tipo.RPositivo;
            ListaRN.DataSource = Tipo.RNegativo;
            ListaPatrimonio.DataSource = Tipo.Patrimonio;

            // testLD.DataSource = libroDiario;

        }
        
        private void PasivoButton_CheckedChanged(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            ListaActivos.Visible = false;
            ListaPasivos.Visible = true;
            ListaRP.Visible = false;
            ListaRN.Visible = false;
            ListaPatrimonio.Visible = false;
        }
        
        private void RPButton_CheckedChanged(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            
            ListaRP.Visible = true;
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaRN.Visible = false;
            ListaPatrimonio.Visible = false;
        }

        private void RNButton_CheckedChanged(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            ListaRN.Visible = true;
            ListaRP.Visible = false;
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = false;
        }

        private void ActivoButton_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            ListaActivos.Visible = true;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = false;
            ListaRN.Visible = false;
            ListaRP.Visible = false;
            DebeHaberGroup.Visible = true;
        }
        
        private void RNButton_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = false;
            ListaRN.Visible = true;
            ListaRP.Visible = false;
            DebeHaberGroup.Visible = false;
            DebeButton.Checked = true;
        }

        private void PasivoButton_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            ListaActivos.Visible = false;
            ListaPasivos.Visible = true;
            ListaPatrimonio.Visible = false;
            ListaRN.Visible = false;
            ListaRP.Visible = false;
            DebeHaberGroup.Visible = true;
        }

        private void RPButton_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = false;
            ListaRN.Visible = false;
            ListaRP.Visible = true;
            DebeHaberGroup.Visible = false;
            HaberButton.Checked = true;
        }

        private void PatrimonioButton_CheckedChanged(object sender, EventArgs e)
        {
            AgregarListaButton.Visible = true;
            EliminarButton.Visible = true;
            AgregarTextBox.Visible = true;
            
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = true;
            ListaRN.Visible = false;
            ListaRP.Visible = false;
            DebeHaberGroup.Visible = true;
        }

        public void mostrarLD(LibroDiario libroDiario)
        {
            foreach (var i in libroDiario.cuentas)
            {
                if (i.activo)
                {
                    Console.WriteLine($"Activo: {i.nombreOperacion}, {i.subeOBaja}, {i.valor}");
                }
                else if (i.pasivo)
                {
                    Console.WriteLine($"Pasivo: {i.nombreOperacion}, {i.subeOBaja}, {i.valor}");
                }
                else if (i.patrimonio)
                {
                    Console.WriteLine($"Patrimonio: {i.nombreOperacion}, {i.subeOBaja}, {i.valor}");
                }
                else if (i.rPositivo)
                {
                    Console.WriteLine($"Resultado Negativo: {i.nombreOperacion}, {i.subeOBaja}, {i.valor}");
                }
                else if (i.rNegativo)
                {
                    Console.WriteLine($"Resultado Positivo: {i.nombreOperacion}, {i.subeOBaja}, {i.valor}");
                }
            }
            
            //Se aplican los valores del debe y haber al asiento
            Console.WriteLine(this.libroDiario.debe);
            Console.WriteLine(this.libroDiario.haber);
        }
        private void desSelect()
        {
            
            //Botones en groups
            foreach (Control control in Clasificación.Controls) 
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            
            ListaActivos.Visible = false;
            ListaPasivos.Visible = false;
            ListaPatrimonio.Visible = false;
            ListaRP.Visible = false;
            ListaRN.Visible = false;
           
            Monto.Text = "";
            NombreOperacion.Text = "";
            DebeButton.Checked = false;
            HaberButton.Checked = false;

            AgregarTextBox.Visible = false;
            AgregarListaButton.Visible = false;
            EliminarButton.Visible = false;
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {

            bool problema = false;
           
            if (NombreOperacion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para definir el asiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                problema = true;
            }
            
            if (Monto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un monto para el asiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                problema = true;
            }

            if (!DebeButton.Checked && !HaberButton.Checked)
            {
                MessageBox.Show("Ingrese correctamente la sección debe o haber del asiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                problema = true;
            }

            if (!problema)
            {
                if (ListaActivos.Visible == true)
               {
                   int valorSeleccionado = ListaActivos.SelectedIndex;
                   TiposDeCuentas cuenta = new TiposDeCuentas(Tipo.activo[valorSeleccionado], Double.Parse(Monto.Text), DH,
                       NombreOperacion.Text, true, false, false, false, false);
                   //Console.WriteLine($"{cuenta.tipoOperacion}, {cuenta.valor}, {cuenta.subeOBaja}, {cuenta.nombreOperacion}");
                  libroDiario.cuentas.Add(cuenta);
               }
               else if (ListaPasivos.Visible == true)
               {
                   int valorSeleccionado = ListaActivos.SelectedIndex;
                   TiposDeCuentas cuenta = new TiposDeCuentas(Tipo.pasivo[valorSeleccionado], Double.Parse(Monto.Text), DH,
                       NombreOperacion.Text, false, true, false, false, false);
                   libroDiario.cuentas.Add(cuenta);
                   
               }
               else if (ListaPatrimonio.Visible == true)
               {
                   int valorSeleccionado = ListaActivos.SelectedIndex;
                   TiposDeCuentas cuenta = new TiposDeCuentas(Tipo.Patrimonio[valorSeleccionado], Double.Parse(Monto.Text), DH,
                       NombreOperacion.Text, false, false, true, false, false);
                   libroDiario.cuentas.Add(cuenta);
               }
               else if (ListaRN.Visible == true)
               {
                   int valorSeleccionado = ListaActivos.SelectedIndex;
                   TiposDeCuentas cuenta = new TiposDeCuentas(Tipo.RNegativo[valorSeleccionado], Double.Parse(Monto.Text), true,
                       NombreOperacion.Text, false, false, false, false, true);
                   libroDiario.cuentas.Add(cuenta);
               }
               else if (ListaRP.Visible == true)
               {
                   int valorSeleccionado = ListaActivos.SelectedIndex;
                   TiposDeCuentas cuenta = new TiposDeCuentas(Tipo.RPositivo[valorSeleccionado], Double.Parse(Monto.Text), false,
                       NombreOperacion.Text, false, false, false, true, false);
                  libroDiario.cuentas.Add(cuenta);
               }
               else
               {
                   MessageBox.Show("Ingrese un tipo de clasificación para el asiento, posteriormente una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               
                
               desSelect();
               libroDiario.balanceado();
            }
           mostrarLD(libroDiario);
        }

       
        private void DebeButton_CheckedChanged(object sender, EventArgs e)
        {
            DH = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void HaberButton_CheckedChanged(object sender, EventArgs e)
        {
            DH = false;
        }


        //Corroboración de ingreso de datos
        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LDButton_Click(object sender, EventArgs e)
        {
            Form2 pantallaLibroDiario = new Form2(libroDiario, libroMayor, libroCreado);
            pantallaLibroDiario.ShowDialog();

            
            Console.WriteLine(libroCreado);
            if (libroCreado.Value==true)
            {
                librosDiarios.Add(libroDiario);
                blockchain.NewLibroDiario(libroDiario);
                blockchain.NewBlock(DateTime.Now,"libro diario");
                serial.GuardarCadena(blockchain);
                
                libroDiario = new LibroDiario();
                libroCreado.Value = false;
            }
        }

        private void LibroMayor_Click(object sender, EventArgs e)
        {
            foreach (var i in libroMayor.librosDiarios)
            {
                Console.WriteLine(i.fecha);
            }

            Form3 pantallaLibroMayor = new Form3(libroMayor);
            pantallaLibroMayor.ShowDialog();
        }
        
        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            
            if (ListaActivos.Visible)
            {
                
                Tipo.activo.RemoveAt(ListaActivos.SelectedIndex); // Eliminamos el index
                
                SerialTipo.GuardarActivo(Tipo.activo); // Guardamos el Tipo.List<string> con el index eliminado

                List<string> nuevoActivo = SerialTipo.LeerActivo();
                
                ListaActivos.DataSource = nuevoActivo;
                
                ListaActivos.Refresh();
            }
            else if (ListaPasivos.Visible)
            {
                
                Tipo.pasivo.RemoveAt(ListaPasivos.SelectedIndex); // Eliminamos el index
                
                SerialTipo.GuardarPasivo(Tipo.pasivo); // Guardamos el Tipo.List<string> con el index eliminado

                List<string> nuevoPasivo = SerialTipo.LeerPasivo();
                
                ListaPasivos.DataSource = nuevoPasivo;
                
                ListaPasivos.Refresh();
            }
            else if (ListaRP.Visible)
            {
                
                Tipo.RPositivo.RemoveAt(ListaRP.SelectedIndex); // Eliminamos el index
                
                SerialTipo.GuardarRPositivo(Tipo.RPositivo); // Guardamos el Tipo.List<string> con el index eliminado

                List<string> nuevoRP = SerialTipo.LeerRPositivo();
                
                ListaRP.DataSource = nuevoRP;
                
                ListaRP.Refresh();
            }
            else if (ListaRN.Visible)
            {
                
                Tipo.RNegativo.RemoveAt(ListaRN.SelectedIndex); // Eliminamos el index
                
                SerialTipo.GuardarRNegativo(Tipo.RNegativo); // Guardamos el Tipo.List<string> con el index eliminado

                List<string> nuevoRN = SerialTipo.LeerRNegativo();
                
                ListaRN.DataSource = nuevoRN;
                
                ListaRN.Refresh();
            }
            else if (ListaPatrimonio.Visible)
            {
                
                Tipo.Patrimonio.RemoveAt(ListaPatrimonio.SelectedIndex); // Eliminamos el index
                
                SerialTipo.GuardarPatrimonio(Tipo.Patrimonio); // Guardamos el Tipo.List<string> con el index eliminado

                List<string> nuevoPatrimonio = SerialTipo.LeerPatrimonio();
                
                ListaPatrimonio.DataSource = nuevoPatrimonio;
                
                ListaPatrimonio.Refresh();
            }
        }

        private void AgregarListaButton_Click(object sender, EventArgs e)
        {
            if (ListaActivos.Visible)
            {

                if (!AgregarTextBox.Text.Equals(""))
                {
                    string nuevaCuenta = AgregarTextBox.Text;
                    Tipo.activo.Add(nuevaCuenta);
                    SerialTipo.GuardarActivo(Tipo.activo);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre de la cuenta debajo de el botón 'agregar cuenta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                List<string> nuevoActivo = SerialTipo.LeerActivo();
                
                ListaActivos.DataSource = nuevoActivo;
                
                ListaActivos.Refresh();

                AgregarTextBox.Text = "";
                
            }
            else if (ListaPasivos.Visible)
            {
                if (!AgregarTextBox.Text.Equals(""))
                {
                    string nuevaCuenta = AgregarTextBox.Text;
                    Tipo.pasivo.Add(nuevaCuenta);
                    SerialTipo.GuardarPasivo(Tipo.pasivo);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre de la cuenta debajo de el botón 'agregar cuenta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<string> nuevoPasivo = SerialTipo.LeerPasivo();
                
                ListaPasivos.DataSource = nuevoPasivo;
                
                ListaPasivos.Refresh();
                
                AgregarTextBox.Text = "";
            }
            else if (ListaRP.Visible)
            {
                if (!AgregarTextBox.Text.Equals(""))
                {
                    string nuevaCuenta = AgregarTextBox.Text;
                    Tipo.RPositivo.Add(nuevaCuenta);
                    SerialTipo.GuardarRPositivo(Tipo.RPositivo);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre de la cuenta debajo de el botón 'agregar cuenta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<string> nuevoRP = SerialTipo.LeerRPositivo();
                
                ListaRP.DataSource = nuevoRP;
                
                ListaRP.Refresh();
                
                AgregarTextBox.Text = "";
            }
            else if (ListaRN.Visible)
            {
                if (!AgregarTextBox.Text.Equals(""))
                {
                    string nuevaCuenta = AgregarTextBox.Text;
                    Tipo.RNegativo.Add(nuevaCuenta);
                    SerialTipo.GuardarRNegativo(Tipo.RNegativo);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre de la cuenta debajo de el botón 'agregar cuenta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<string> nuevoRN = SerialTipo.LeerRNegativo();
                
                ListaRN.DataSource = nuevoRN;
                
                ListaRN.Refresh();
                
                AgregarTextBox.Text = "";
            }
            else if (ListaPatrimonio.Visible)
            {
                if (!AgregarTextBox.Text.Equals(""))
                {
                    string nuevaCuenta = AgregarTextBox.Text;
                    Tipo.Patrimonio.Add(nuevaCuenta);
                    SerialTipo.GuardarPatrimonio(Tipo.Patrimonio);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre de la cuenta debajo de el botón 'agregar cuenta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<string> nuevoPatrimonio = SerialTipo.LeerPatrimonio();
                
                ListaPatrimonio.DataSource = nuevoPatrimonio;
                
                ListaPatrimonio.Refresh();
                
                AgregarTextBox.Text = "";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelAgregar_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}