namespace Sincronizador.Views
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ChLanzarConWindows = new System.Windows.Forms.CheckBox();
            this.Ninterval = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NMinAbiertas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ChkLanzarTimer = new System.Windows.Forms.CheckBox();
            this.NMinCat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ninterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinAbiertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 31);
            this.label13.TabIndex = 260;
            this.label13.Text = "Configuracón gral.";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Location = new System.Drawing.Point(1, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(870, 12);
            this.label14.TabIndex = 259;
            // 
            // ChLanzarConWindows
            // 
            this.ChLanzarConWindows.AutoSize = true;
            this.ChLanzarConWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ChLanzarConWindows.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChLanzarConWindows.Location = new System.Drawing.Point(13, 67);
            this.ChLanzarConWindows.Margin = new System.Windows.Forms.Padding(4);
            this.ChLanzarConWindows.Name = "ChLanzarConWindows";
            this.ChLanzarConWindows.Size = new System.Drawing.Size(346, 28);
            this.ChLanzarConWindows.TabIndex = 266;
            this.ChLanzarConWindows.Text = "LANZAR APP AL INICIAR WINDOWS";
            this.ChLanzarConWindows.UseVisualStyleBackColor = true;
            // 
            // Ninterval
            // 
            this.Ninterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Ninterval.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ninterval.Location = new System.Drawing.Point(181, 144);
            this.Ninterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Ninterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ninterval.Name = "Ninterval";
            this.Ninterval.Size = new System.Drawing.Size(125, 29);
            this.Ninterval.TabIndex = 267;
            this.Ninterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 268;
            this.label7.Text = "TIMER INTERVAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(585, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 269;
            this.label1.Text = "MINUTOS";
            // 
            // NMinAbiertas
            // 
            this.NMinAbiertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NMinAbiertas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NMinAbiertas.Location = new System.Drawing.Point(453, 188);
            this.NMinAbiertas.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NMinAbiertas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NMinAbiertas.Name = "NMinAbiertas";
            this.NMinAbiertas.Size = new System.Drawing.Size(125, 29);
            this.NMinAbiertas.TabIndex = 270;
            this.NMinAbiertas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 24);
            this.label2.TabIndex = 271;
            this.label2.Text = "SINCRONIZAR ATENCIONES ABIERTAS CADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(313, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 272;
            this.label3.Text = "MILISEGUNDOS";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(601, 449);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(127, 48);
            this.BtnAceptar.TabIndex = 273;
            this.BtnAceptar.Text = "&ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(736, 449);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 48);
            this.BtnCancelar.TabIndex = 274;
            this.BtnCancelar.Text = "SALIR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ChkLanzarTimer
            // 
            this.ChkLanzarTimer.AutoSize = true;
            this.ChkLanzarTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ChkLanzarTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChkLanzarTimer.Location = new System.Drawing.Point(13, 103);
            this.ChkLanzarTimer.Margin = new System.Windows.Forms.Padding(4);
            this.ChkLanzarTimer.Name = "ChkLanzarTimer";
            this.ChkLanzarTimer.Size = new System.Drawing.Size(338, 28);
            this.ChkLanzarTimer.TabIndex = 275;
            this.ChkLanzarTimer.Text = "LANZAR TIMER AL INICIAR LA APP";
            this.ChkLanzarTimer.UseVisualStyleBackColor = true;
            // 
            // NMinCat
            // 
            this.NMinCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NMinCat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NMinCat.Location = new System.Drawing.Point(453, 234);
            this.NMinCat.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NMinCat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NMinCat.Name = "NMinCat";
            this.NMinCat.Size = new System.Drawing.Size(125, 29);
            this.NMinCat.TabIndex = 277;
            this.NMinCat.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(9, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 24);
            this.label4.TabIndex = 278;
            this.label4.Text = "SINCRONIZAR CATÁLOGOS AUTO.  CADA   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(585, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 276;
            this.label5.Text = "MINUTOS";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.NMinCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChkLanzarTimer);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NMinAbiertas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ninterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChLanzarConWindows);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfig";
            ((System.ComponentModel.ISupportInitialize)(this.Ninterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinAbiertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ChLanzarConWindows;
        private System.Windows.Forms.NumericUpDown Ninterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NMinAbiertas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.CheckBox ChkLanzarTimer;
        private System.Windows.Forms.NumericUpDown NMinCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}