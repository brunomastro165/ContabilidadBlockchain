namespace ProgramaContable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }
         
                 /// <summary>
                 /// Clean up any resources being used.
                 /// </summary>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaPatrimonio = new System.Windows.Forms.ListBox();
            this.ListaRN = new System.Windows.Forms.ListBox();
            this.ListaRP = new System.Windows.Forms.ListBox();
            this.ListaPasivos = new System.Windows.Forms.ListBox();
            this.ListaActivos = new System.Windows.Forms.ListBox();
            this.Clasificación = new System.Windows.Forms.GroupBox();
            this.PatrimonioButton = new System.Windows.Forms.RadioButton();
            this.RNButton = new System.Windows.Forms.RadioButton();
            this.RPButton = new System.Windows.Forms.RadioButton();
            this.PasivoButton = new System.Windows.Forms.RadioButton();
            this.ActivoButton = new System.Windows.Forms.RadioButton();
            this.NombreOperacion = new System.Windows.Forms.TextBox();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DebeButton = new System.Windows.Forms.RadioButton();
            this.HaberButton = new System.Windows.Forms.RadioButton();
            this.DebeHaberGroup = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LDButton = new System.Windows.Forms.Button();
            this.LibroMayor = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.AgregarListaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AgregarTextBox = new System.Windows.Forms.TextBox();
            this.Clasificación.SuspendLayout();
            this.DebeHaberGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaPatrimonio
            // 
            this.ListaPatrimonio.FormattingEnabled = true;
            this.ListaPatrimonio.Location = new System.Drawing.Point(117, 224);
            this.ListaPatrimonio.Name = "ListaPatrimonio";
            this.ListaPatrimonio.Size = new System.Drawing.Size(384, 121);
            this.ListaPatrimonio.TabIndex = 19;
            // 
            // ListaRN
            // 
            this.ListaRN.FormattingEnabled = true;
            this.ListaRN.Location = new System.Drawing.Point(117, 224);
            this.ListaRN.Name = "ListaRN";
            this.ListaRN.Size = new System.Drawing.Size(384, 121);
            this.ListaRN.TabIndex = 18;
            // 
            // ListaRP
            // 
            this.ListaRP.FormattingEnabled = true;
            this.ListaRP.Location = new System.Drawing.Point(117, 224);
            this.ListaRP.Name = "ListaRP";
            this.ListaRP.Size = new System.Drawing.Size(384, 121);
            this.ListaRP.TabIndex = 17;
            // 
            // ListaPasivos
            // 
            this.ListaPasivos.FormattingEnabled = true;
            this.ListaPasivos.Location = new System.Drawing.Point(117, 224);
            this.ListaPasivos.Name = "ListaPasivos";
            this.ListaPasivos.Size = new System.Drawing.Size(384, 121);
            this.ListaPasivos.TabIndex = 16;
            // 
            // ListaActivos
            // 
            this.ListaActivos.FormattingEnabled = true;
            this.ListaActivos.Location = new System.Drawing.Point(116, 224);
            this.ListaActivos.Name = "ListaActivos";
            this.ListaActivos.Size = new System.Drawing.Size(384, 121);
            this.ListaActivos.TabIndex = 15;
            // 
            // Clasificación
            // 
            this.Clasificación.Controls.Add(this.PatrimonioButton);
            this.Clasificación.Controls.Add(this.RNButton);
            this.Clasificación.Controls.Add(this.RPButton);
            this.Clasificación.Controls.Add(this.PasivoButton);
            this.Clasificación.Controls.Add(this.ActivoButton);
            this.Clasificación.Location = new System.Drawing.Point(117, 144);
            this.Clasificación.Name = "Clasificación";
            this.Clasificación.Size = new System.Drawing.Size(384, 57);
            this.Clasificación.TabIndex = 14;
            this.Clasificación.TabStop = false;
            this.Clasificación.Text = "Clasificación";
            // 
            // PatrimonioButton
            // 
            this.PatrimonioButton.Location = new System.Drawing.Point(299, 19);
            this.PatrimonioButton.Name = "PatrimonioButton";
            this.PatrimonioButton.Size = new System.Drawing.Size(77, 33);
            this.PatrimonioButton.TabIndex = 6;
            this.PatrimonioButton.TabStop = true;
            this.PatrimonioButton.Text = "Patrimonio";
            this.PatrimonioButton.UseVisualStyleBackColor = true;
            this.PatrimonioButton.CheckedChanged += new System.EventHandler(this.PatrimonioButton_CheckedChanged);
            // 
            // RNButton
            // 
            this.RNButton.Location = new System.Drawing.Point(229, 18);
            this.RNButton.Name = "RNButton";
            this.RNButton.Size = new System.Drawing.Size(51, 33);
            this.RNButton.TabIndex = 5;
            this.RNButton.TabStop = true;
            this.RNButton.Text = "RN";
            this.RNButton.UseVisualStyleBackColor = true;
            this.RNButton.CheckedChanged += new System.EventHandler(this.RNButton_CheckedChanged_1);
            // 
            // RPButton
            // 
            this.RPButton.Location = new System.Drawing.Point(166, 18);
            this.RPButton.Name = "RPButton";
            this.RPButton.Size = new System.Drawing.Size(51, 33);
            this.RPButton.TabIndex = 4;
            this.RPButton.TabStop = true;
            this.RPButton.Text = "RP";
            this.RPButton.UseVisualStyleBackColor = true;
            this.RPButton.CheckedChanged += new System.EventHandler(this.RPButton_CheckedChanged_1);
            // 
            // PasivoButton
            // 
            this.PasivoButton.Location = new System.Drawing.Point(86, 19);
            this.PasivoButton.Name = "PasivoButton";
            this.PasivoButton.Size = new System.Drawing.Size(74, 33);
            this.PasivoButton.TabIndex = 3;
            this.PasivoButton.TabStop = true;
            this.PasivoButton.Text = "Pasivo";
            this.PasivoButton.UseVisualStyleBackColor = true;
            this.PasivoButton.CheckedChanged += new System.EventHandler(this.PasivoButton_CheckedChanged_1);
            // 
            // ActivoButton
            // 
            this.ActivoButton.Location = new System.Drawing.Point(9, 19);
            this.ActivoButton.Name = "ActivoButton";
            this.ActivoButton.Size = new System.Drawing.Size(74, 33);
            this.ActivoButton.TabIndex = 2;
            this.ActivoButton.TabStop = true;
            this.ActivoButton.Text = "Activo";
            this.ActivoButton.UseVisualStyleBackColor = true;
            this.ActivoButton.CheckedChanged += new System.EventHandler(this.ActivoButton_CheckedChanged_1);
            // 
            // NombreOperacion
            // 
            this.NombreOperacion.Location = new System.Drawing.Point(126, 82);
            this.NombreOperacion.Name = "NombreOperacion";
            this.NombreOperacion.Size = new System.Drawing.Size(367, 20);
            this.NombreOperacion.TabIndex = 13;
            // 
            // labelAgregar
            // 
            this.labelAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregar.Location = new System.Drawing.Point(169, 9);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(280, 31);
            this.labelAgregar.TabIndex = 20;
            this.labelAgregar.Text = "Registro de operaciones";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(50, 95);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 24);
            this.label.TabIndex = 21;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(116, 538);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(385, 20);
            this.Monto.TabIndex = 22;
            this.Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Monto_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Monto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DebeButton
            // 
            this.DebeButton.Location = new System.Drawing.Point(10, 21);
            this.DebeButton.Name = "DebeButton";
            this.DebeButton.Size = new System.Drawing.Size(64, 34);
            this.DebeButton.TabIndex = 24;
            this.DebeButton.TabStop = true;
            this.DebeButton.Text = "Sube";
            this.DebeButton.UseVisualStyleBackColor = true;
            this.DebeButton.CheckedChanged += new System.EventHandler(this.DebeButton_CheckedChanged);
            // 
            // HaberButton
            // 
            this.HaberButton.Location = new System.Drawing.Point(134, 21);
            this.HaberButton.Name = "HaberButton";
            this.HaberButton.Size = new System.Drawing.Size(71, 34);
            this.HaberButton.TabIndex = 25;
            this.HaberButton.TabStop = true;
            this.HaberButton.Text = "Baja";
            this.HaberButton.UseVisualStyleBackColor = true;
            this.HaberButton.CheckedChanged += new System.EventHandler(this.HaberButton_CheckedChanged);
            // 
            // DebeHaberGroup
            // 
            this.DebeHaberGroup.Controls.Add(this.HaberButton);
            this.DebeHaberGroup.Controls.Add(this.DebeButton);
            this.DebeHaberGroup.Location = new System.Drawing.Point(212, 576);
            this.DebeHaberGroup.Name = "DebeHaberGroup";
            this.DebeHaberGroup.Size = new System.Drawing.Size(211, 61);
            this.DebeHaberGroup.TabIndex = 26;
            this.DebeHaberGroup.TabStop = false;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(245, 652);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(126, 39);
            this.AgregarButton.TabIndex = 28;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LDButton
            // 
            this.LDButton.Location = new System.Drawing.Point(475, 656);
            this.LDButton.Name = "LDButton";
            this.LDButton.Size = new System.Drawing.Size(126, 39);
            this.LDButton.TabIndex = 29;
            this.LDButton.Text = "Ver libro diario";
            this.LDButton.UseVisualStyleBackColor = true;
            this.LDButton.Click += new System.EventHandler(this.LDButton_Click);
            // 
            // LibroMayor
            // 
            this.LibroMayor.Location = new System.Drawing.Point(12, 656);
            this.LibroMayor.Name = "LibroMayor";
            this.LibroMayor.Size = new System.Drawing.Size(126, 39);
            this.LibroMayor.TabIndex = 30;
            this.LibroMayor.Text = "Ver libro mayor";
            this.LibroMayor.UseVisualStyleBackColor = true;
            this.LibroMayor.Click += new System.EventHandler(this.LibroMayor_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(507, 224);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(109, 30);
            this.EliminarButton.TabIndex = 33;
            this.EliminarButton.Text = "Eliminar cuenta";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click_1);
            // 
            // AgregarListaButton
            // 
            this.AgregarListaButton.Location = new System.Drawing.Point(507, 311);
            this.AgregarListaButton.Name = "AgregarListaButton";
            this.AgregarListaButton.Size = new System.Drawing.Size(109, 30);
            this.AgregarListaButton.TabIndex = 34;
            this.AgregarListaButton.Text = "Agregar cuenta";
            this.AgregarListaButton.UseVisualStyleBackColor = true;
            this.AgregarListaButton.Click += new System.EventHandler(this.AgregarListaButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(126, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // AgregarTextBox
            // 
            this.AgregarTextBox.Location = new System.Drawing.Point(507, 347);
            this.AgregarTextBox.Name = "AgregarTextBox";
            this.AgregarTextBox.Size = new System.Drawing.Size(109, 20);
            this.AgregarTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 707);
            this.Controls.Add(this.AgregarTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgregarListaButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.LibroMayor);
            this.Controls.Add(this.LDButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.DebeHaberGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelAgregar);
            this.Controls.Add(this.ListaPatrimonio);
            this.Controls.Add(this.ListaRN);
            this.Controls.Add(this.ListaRP);
            this.Controls.Add(this.ListaPasivos);
            this.Controls.Add(this.ListaActivos);
            this.Controls.Add(this.Clasificación);
            this.Controls.Add(this.NombreOperacion);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Clasificación.ResumeLayout(false);
            this.DebeHaberGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox AgregarTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button AgregarListaButton;

        private System.Windows.Forms.Button AgregarCuentaButton;

        private System.Windows.Forms.Button EliminarButton;

        private System.Windows.Forms.Button LibroMayor;


        private System.Windows.Forms.Button LDButton;

        private System.Windows.Forms.Button AgregarButton;

        private System.Windows.Forms.RadioButton DebeButton;
        private System.Windows.Forms.RadioButton HaberButton;
        private System.Windows.Forms.GroupBox DebeHaberGroup;

        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelAgregar;
        private System.Windows.Forms.Label label;

        private System.Windows.Forms.ListBox ListaPatrimonio;

        private System.Windows.Forms.ListBox ListaRN;

        private System.Windows.Forms.ListBox ListaRP;

        private System.Windows.Forms.ListBox ListaPasivos;

        private System.Windows.Forms.ListBox ListaActivos;

        private System.Windows.Forms.RadioButton PasivoButton;
        private System.Windows.Forms.RadioButton RPButton;
        private System.Windows.Forms.RadioButton RNButton;
        private System.Windows.Forms.RadioButton PatrimonioButton;

        private System.Windows.Forms.TextBox NombreOperacion;
        private System.Windows.Forms.GroupBox Clasificación;
        private System.Windows.Forms.RadioButton ActivoButton;

        #endregion
    }
}