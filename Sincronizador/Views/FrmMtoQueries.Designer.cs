namespace Sincronizador.Views
{
    partial class FrmMtoQueries
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DpFecha = new System.Windows.Forms.DateTimePicker();
            this.Parametrizar = new System.Windows.Forms.CheckBox();
            this.Vigente = new System.Windows.Forms.CheckBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(13, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 31);
            this.label13.TabIndex = 258;
            this.label13.Text = "Mantenimiento queries";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Location = new System.Drawing.Point(1, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(707, 10);
            this.label14.TabIndex = 257;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSql);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(19, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(674, 274);
            this.groupBox1.TabIndex = 256;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comando sql";
            // 
            // TxtSql
            // 
            this.TxtSql.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSql.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSql.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSql.Location = new System.Drawing.Point(8, 23);
            this.TxtSql.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSql.Size = new System.Drawing.Size(658, 243);
            this.TxtSql.TabIndex = 234;
            this.TxtSql.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 260;
            this.label5.Text = "♥CLAVE";
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.SystemColors.Window;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.Location = new System.Drawing.Point(19, 109);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(152, 29);
            this.TxtClave.TabIndex = 238;
            this.TxtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClave_KeyDown);
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescrip.ForeColor = System.Drawing.Color.Black;
            this.TxtDescrip.Location = new System.Drawing.Point(179, 109);
            this.TxtDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(291, 29);
            this.TxtDescrip.TabIndex = 261;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(175, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 262;
            this.label7.Text = "DESCRIPCIÓN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(476, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 24);
            this.label8.TabIndex = 264;
            this.label8.Text = "ULT. SINCRONIZACIÓN";
            // 
            // DpFecha
            // 
            this.DpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.DpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpFecha.Location = new System.Drawing.Point(478, 109);
            this.DpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.DpFecha.Name = "DpFecha";
            this.DpFecha.Size = new System.Drawing.Size(215, 29);
            this.DpFecha.TabIndex = 263;
            // 
            // Parametrizar
            // 
            this.Parametrizar.AutoSize = true;
            this.Parametrizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Parametrizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Parametrizar.Location = new System.Drawing.Point(19, 146);
            this.Parametrizar.Margin = new System.Windows.Forms.Padding(4);
            this.Parametrizar.Name = "Parametrizar";
            this.Parametrizar.Size = new System.Drawing.Size(654, 28);
            this.Parametrizar.TabIndex = 265;
            this.Parametrizar.Text = "PARAMETRIZAR EL COMANDO SQL CON LA FECHA SELECCIONADA ";
            this.Parametrizar.UseVisualStyleBackColor = true;
            // 
            // Vigente
            // 
            this.Vigente.AutoSize = true;
            this.Vigente.Checked = true;
            this.Vigente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Vigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Vigente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Vigente.Location = new System.Drawing.Point(19, 182);
            this.Vigente.Margin = new System.Windows.Forms.Padding(4);
            this.Vigente.Name = "Vigente";
            this.Vigente.Size = new System.Drawing.Size(115, 28);
            this.Vigente.TabIndex = 266;
            this.Vigente.Text = "VIGENTE";
            this.Vigente.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(423, 500);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(127, 48);
            this.BtnAceptar.TabIndex = 267;
            this.BtnAceptar.Text = "&ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(558, 500);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 48);
            this.BtnCancelar.TabIndex = 268;
            this.BtnCancelar.Text = "SALIR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmMtoQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 558);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Vigente);
            this.Controls.Add(this.Parametrizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DpFecha);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMtoQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMtoQueries";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DpFecha;
        private System.Windows.Forms.CheckBox Parametrizar;
        private System.Windows.Forms.CheckBox Vigente;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}