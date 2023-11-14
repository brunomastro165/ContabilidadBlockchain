using System.ComponentModel;

namespace ProgramaContable
{
    partial class Form3
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
            this.Clasificación = new System.Windows.Forms.GroupBox();
            this.PatrimonioButton = new System.Windows.Forms.RadioButton();
            this.RNButton = new System.Windows.Forms.RadioButton();
            this.RPButton = new System.Windows.Forms.RadioButton();
            this.PasivoButton = new System.Windows.Forms.RadioButton();
            this.ActivoButton = new System.Windows.Forms.RadioButton();
            this.ListaPatrimonio = new System.Windows.Forms.ListBox();
            this.cuenta = new System.Windows.Forms.Label();
            this.Debe = new System.Windows.Forms.ListBox();
            this.Haber = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.SalHaber = new System.Windows.Forms.Label();
            this.SalDebe = new System.Windows.Forms.Label();
            this.SalTotal = new System.Windows.Forms.Label();
            this.Clasificación.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clasificación
            // 
            this.Clasificación.Controls.Add(this.PatrimonioButton);
            this.Clasificación.Controls.Add(this.RNButton);
            this.Clasificación.Controls.Add(this.RPButton);
            this.Clasificación.Controls.Add(this.PasivoButton);
            this.Clasificación.Controls.Add(this.ActivoButton);
            this.Clasificación.Location = new System.Drawing.Point(160, 10);
            this.Clasificación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clasificación.Name = "Clasificación";
            this.Clasificación.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clasificación.Size = new System.Drawing.Size(322, 46);
            this.Clasificación.TabIndex = 15;
            this.Clasificación.TabStop = false;
            this.Clasificación.Text = "Clasificación";
            // 
            // PatrimonioButton
            // 
            this.PatrimonioButton.Location = new System.Drawing.Point(245, 15);
            this.PatrimonioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatrimonioButton.Name = "PatrimonioButton";
            this.PatrimonioButton.Size = new System.Drawing.Size(89, 27);
            this.PatrimonioButton.TabIndex = 6;
            this.PatrimonioButton.TabStop = true;
            this.PatrimonioButton.Text = "Patrimonio";
            this.PatrimonioButton.UseVisualStyleBackColor = true;
            this.PatrimonioButton.CheckedChanged += new System.EventHandler(this.PatrimonioButton_CheckedChanged);
            // 
            // RNButton
            // 
            this.RNButton.Location = new System.Drawing.Point(194, 15);
            this.RNButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RNButton.Name = "RNButton";
            this.RNButton.Size = new System.Drawing.Size(47, 27);
            this.RNButton.TabIndex = 5;
            this.RNButton.TabStop = true;
            this.RNButton.Text = "RN";
            this.RNButton.UseVisualStyleBackColor = true;
            this.RNButton.CheckedChanged += new System.EventHandler(this.RNButton_CheckedChanged);
            // 
            // RPButton
            // 
            this.RPButton.Location = new System.Drawing.Point(142, 15);
            this.RPButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RPButton.Name = "RPButton";
            this.RPButton.Size = new System.Drawing.Size(47, 27);
            this.RPButton.TabIndex = 4;
            this.RPButton.TabStop = true;
            this.RPButton.Text = "RP";
            this.RPButton.UseVisualStyleBackColor = true;
            this.RPButton.CheckedChanged += new System.EventHandler(this.RPButton_CheckedChanged);
            // 
            // PasivoButton
            // 
            this.PasivoButton.Location = new System.Drawing.Point(67, 15);
            this.PasivoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasivoButton.Name = "PasivoButton";
            this.PasivoButton.Size = new System.Drawing.Size(70, 27);
            this.PasivoButton.TabIndex = 3;
            this.PasivoButton.TabStop = true;
            this.PasivoButton.Text = "Pasivo";
            this.PasivoButton.UseVisualStyleBackColor = true;
            this.PasivoButton.CheckedChanged += new System.EventHandler(this.PasivoButton_CheckedChanged);
            // 
            // ActivoButton
            // 
            this.ActivoButton.Location = new System.Drawing.Point(7, 15);
            this.ActivoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActivoButton.Name = "ActivoButton";
            this.ActivoButton.Size = new System.Drawing.Size(56, 27);
            this.ActivoButton.TabIndex = 2;
            this.ActivoButton.TabStop = true;
            this.ActivoButton.Text = "Activo";
            this.ActivoButton.UseVisualStyleBackColor = true;
            this.ActivoButton.CheckedChanged += new System.EventHandler(this.ActivoButton_CheckedChanged);
            // 
            // ListaPatrimonio
            // 
            this.ListaPatrimonio.FormattingEnabled = true;
            this.ListaPatrimonio.Location = new System.Drawing.Point(173, 61);
            this.ListaPatrimonio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaPatrimonio.Name = "ListaPatrimonio";
            this.ListaPatrimonio.Size = new System.Drawing.Size(300, 121);
            this.ListaPatrimonio.TabIndex = 20;
            this.ListaPatrimonio.SelectedIndexChanged += new System.EventHandler(this.ListaPatrimonio_SelectedIndexChanged);
            // 
            // cuenta
            // 
            this.cuenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuenta.Location = new System.Drawing.Point(159, 266);
            this.cuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(335, 55);
            this.cuenta.TabIndex = 21;
            this.cuenta.Text = "cuenta";
            this.cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuenta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Debe
            // 
            this.Debe.Cursor = System.Windows.Forms.Cursors.Default;
            this.Debe.FormattingEnabled = true;
            this.Debe.Location = new System.Drawing.Point(152, 323);
            this.Debe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Debe.Name = "Debe";
            this.Debe.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Debe.Size = new System.Drawing.Size(171, 160);
            this.Debe.TabIndex = 22;
            // 
            // Haber
            // 
            this.Haber.FormattingEnabled = true;
            this.Haber.Location = new System.Drawing.Point(324, 323);
            this.Haber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Haber.Name = "Haber";
            this.Haber.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Haber.Size = new System.Drawing.Size(171, 160);
            this.Haber.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(222, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(373, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hasta";
            // 
            // desde
            // 
            this.desde.Location = new System.Drawing.Point(174, 231);
            this.desde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(146, 20);
            this.desde.TabIndex = 26;
            this.desde.ValueChanged += new System.EventHandler(this.desde_ValueChanged);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(324, 231);
            this.hasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(146, 20);
            this.hasta.TabIndex = 27;
            this.hasta.ValueChanged += new System.EventHandler(this.hasta_ValueChanged);
            // 
            // SalHaber
            // 
            this.SalHaber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalHaber.Location = new System.Drawing.Point(324, 485);
            this.SalHaber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalHaber.Name = "SalHaber";
            this.SalHaber.Size = new System.Drawing.Size(170, 19);
            this.SalHaber.TabIndex = 28;
            this.SalHaber.Text = "Saldo Haber";
            this.SalHaber.Click += new System.EventHandler(this.label3_Click);
            // 
            // SalDebe
            // 
            this.SalDebe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalDebe.Location = new System.Drawing.Point(152, 485);
            this.SalDebe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalDebe.Name = "SalDebe";
            this.SalDebe.Size = new System.Drawing.Size(170, 19);
            this.SalDebe.TabIndex = 29;
            this.SalDebe.Text = "Saldo Debe";
            // 
            // SalTotal
            // 
            this.SalTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalTotal.Location = new System.Drawing.Point(242, 518);
            this.SalTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalTotal.Name = "SalTotal";
            this.SalTotal.Size = new System.Drawing.Size(170, 19);
            this.SalTotal.TabIndex = 30;
            this.SalTotal.Text = "Saldo ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 615);
            this.Controls.Add(this.SalTotal);
            this.Controls.Add(this.SalDebe);
            this.Controls.Add(this.SalHaber);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.desde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Haber);
            this.Controls.Add(this.Debe);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.ListaPatrimonio);
            this.Controls.Add(this.Clasificación);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Clasificación.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label SalTotal;

        private System.Windows.Forms.Label SalDebe;

        private System.Windows.Forms.Label SalHaber;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.DateTimePicker hasta;

        private System.Windows.Forms.ListBox Debe;
        private System.Windows.Forms.ListBox Haber;

        private System.Windows.Forms.Label cuenta;

        private System.Windows.Forms.ListBox ListaPatrimonio;

        private System.Windows.Forms.GroupBox Clasificación;
        private System.Windows.Forms.RadioButton PatrimonioButton;
        private System.Windows.Forms.RadioButton RNButton;
        private System.Windows.Forms.RadioButton RPButton;
        private System.Windows.Forms.RadioButton PasivoButton;
        private System.Windows.Forms.RadioButton ActivoButton;

        #endregion
    }
}