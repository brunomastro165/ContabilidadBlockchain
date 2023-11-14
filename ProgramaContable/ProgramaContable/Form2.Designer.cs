using System.ComponentModel;

namespace ProgramaContable
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timer1 = new System.Timers.Timer();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Timer = new System.Timers.Timer();
            this.ListaNombre = new System.Windows.Forms.ListBox();
            this.ListaTipo = new System.Windows.Forms.ListBox();
            this.ListaDebe = new System.Windows.Forms.ListBox();
            this.ListaClasificacion = new System.Windows.Forms.ListBox();
            this.ListaHaber = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aviso = new System.Windows.Forms.Label();
            this.CrearLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(9, 10);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(202, 20);
            this.Fecha.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.SynchronizingObject = this;
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Elapsed);
            // 
            // ListaNombre
            // 
            this.ListaNombre.FormattingEnabled = true;
            this.ListaNombre.Location = new System.Drawing.Point(10, 85);
            this.ListaNombre.Margin = new System.Windows.Forms.Padding(2);
            this.ListaNombre.MultiColumn = true;
            this.ListaNombre.Name = "ListaNombre";
            this.ListaNombre.Size = new System.Drawing.Size(137, 238);
            this.ListaNombre.TabIndex = 2;
            this.ListaNombre.SelectedIndexChanged += new System.EventHandler(this.ListaNombre_SelectedIndexChanged);
            // 
            // ListaTipo
            // 
            this.ListaTipo.FormattingEnabled = true;
            this.ListaTipo.Location = new System.Drawing.Point(255, 85);
            this.ListaTipo.Margin = new System.Windows.Forms.Padding(2);
            this.ListaTipo.MultiColumn = true;
            this.ListaTipo.Name = "ListaTipo";
            this.ListaTipo.Size = new System.Drawing.Size(156, 238);
            this.ListaTipo.TabIndex = 3;
            // 
            // ListaDebe
            // 
            this.ListaDebe.FormattingEnabled = true;
            this.ListaDebe.Location = new System.Drawing.Point(415, 85);
            this.ListaDebe.Margin = new System.Windows.Forms.Padding(2);
            this.ListaDebe.MultiColumn = true;
            this.ListaDebe.Name = "ListaDebe";
            this.ListaDebe.Size = new System.Drawing.Size(87, 238);
            this.ListaDebe.TabIndex = 4;
            // 
            // ListaClasificacion
            // 
            this.ListaClasificacion.FormattingEnabled = true;
            this.ListaClasificacion.Location = new System.Drawing.Point(150, 85);
            this.ListaClasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.ListaClasificacion.MultiColumn = true;
            this.ListaClasificacion.Name = "ListaClasificacion";
            this.ListaClasificacion.Size = new System.Drawing.Size(102, 238);
            this.ListaClasificacion.TabIndex = 5;
            // 
            // ListaHaber
            // 
            this.ListaHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaHaber.FormattingEnabled = true;
            this.ListaHaber.Location = new System.Drawing.Point(506, 85);
            this.ListaHaber.Margin = new System.Windows.Forms.Padding(2);
            this.ListaHaber.MultiColumn = true;
            this.ListaHaber.Name = "ListaHaber";
            this.ListaHaber.Size = new System.Drawing.Size(87, 238);
            this.ListaHaber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(435, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Debe";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(523, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Haber";
            // 
            // Aviso
            // 
            this.Aviso.Location = new System.Drawing.Point(228, 348);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(166, 37);
            this.Aviso.TabIndex = 10;
            this.Aviso.Text = "El libro diario no está balanceado";
            // 
            // CrearLD
            // 
            this.CrearLD.Location = new System.Drawing.Point(480, 354);
            this.CrearLD.Name = "CrearLD";
            this.CrearLD.Size = new System.Drawing.Size(103, 30);
            this.CrearLD.TabIndex = 11;
            this.CrearLD.Text = "FInalizar";
            this.CrearLD.UseVisualStyleBackColor = true;
            this.CrearLD.Click += new System.EventHandler(this.CrearLD_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.CrearLD);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaHaber);
            this.Controls.Add(this.ListaClasificacion);
            this.Controls.Add(this.ListaDebe);
            this.Controls.Add(this.ListaTipo);
            this.Controls.Add(this.ListaNombre);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.Button CrearLD;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox ListaHaber;

        private System.Windows.Forms.ListBox ListaClasificacion;

        private System.Windows.Forms.ListBox ListaTipo;
        private System.Windows.Forms.ListBox ListaDebe;

        private System.Windows.Forms.ListBox ListaNombre;

        private System.Timers.Timer Timer;

        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Timers.Timer timer1;

        #endregion
    }
}