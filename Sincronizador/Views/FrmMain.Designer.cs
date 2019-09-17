namespace Sincronizador.Views
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnIniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDetener = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMtoQuerys = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConnOracle = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConnLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigGral = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnActualizarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLanzar = new System.Windows.Forms.ToolStripMenuItem();
            this.LblStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnSectores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.LblStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnIniciar,
            this.BtnDetener,
            this.BtnReset,
            this.BtnSalir});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(171, 32);
            this.BtnIniciar.Text = "&Iniciar";
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(171, 32);
            this.BtnDetener.Text = "&Detener";
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(171, 32);
            this.BtnReset.Text = "&Reiniciar";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(171, 32);
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.configuracionToolStripMenuItem.Text = "Configuración";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMtoQuerys,
            this.BtnConnOracle,
            this.BtnConnLocal,
            this.btnConfigGral,
            this.BtnActualizarCat,
            this.BtnLanzar,
            this.BtnSectores});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // BtnMtoQuerys
            // 
            this.BtnMtoQuerys.Name = "BtnMtoQuerys";
            this.BtnMtoQuerys.Size = new System.Drawing.Size(284, 32);
            this.BtnMtoQuerys.Text = "&Queries";
            this.BtnMtoQuerys.Click += new System.EventHandler(this.BtnMtoQuerys_Click);
            // 
            // BtnConnOracle
            // 
            this.BtnConnOracle.Name = "BtnConnOracle";
            this.BtnConnOracle.Size = new System.Drawing.Size(284, 32);
            this.BtnConnOracle.Text = "&Conexión oracle";
            // 
            // BtnConnLocal
            // 
            this.BtnConnLocal.Name = "BtnConnLocal";
            this.BtnConnLocal.Size = new System.Drawing.Size(284, 32);
            this.BtnConnLocal.Text = "&Conexión local";
            // 
            // btnConfigGral
            // 
            this.btnConfigGral.Name = "btnConfigGral";
            this.btnConfigGral.Size = new System.Drawing.Size(284, 32);
            this.btnConfigGral.Text = "&Config general";
            this.btnConfigGral.Click += new System.EventHandler(this.BtnConfigGral_Click);
            // 
            // BtnActualizarCat
            // 
            this.BtnActualizarCat.Name = "BtnActualizarCat";
            this.BtnActualizarCat.Size = new System.Drawing.Size(284, 32);
            this.BtnActualizarCat.Text = "&Actualizar catálogos  ";
            this.BtnActualizarCat.Click += new System.EventHandler(this.BtnActualizarCat_Click);
            // 
            // BtnLanzar
            // 
            this.BtnLanzar.Name = "BtnLanzar";
            this.BtnLanzar.Size = new System.Drawing.Size(284, 32);
            this.BtnLanzar.Text = "Lanzar";
            this.BtnLanzar.Click += new System.EventHandler(this.BtnLanzar_Click);
            // 
            // LblStatusBar
            // 
            this.LblStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LblStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.LblStatus});
            this.LblStatusBar.Location = new System.Drawing.Point(0, 524);
            this.LblStatusBar.Name = "LblStatusBar";
            this.LblStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.LblStatusBar.Size = new System.Drawing.Size(843, 34);
            this.LblStatusBar.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(88, 28);
            this.toolStripStatusLabel.Text = "ESTADO:";
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(149, 28);
            this.LblStatus.Text = "DESCONOCIDO";
            // 
            // BtnSectores
            // 
            this.BtnSectores.Name = "BtnSectores";
            this.BtnSectores.Size = new System.Drawing.Size(284, 32);
            this.BtnSectores.Text = "Sectores";
            this.BtnSectores.Click += new System.EventHandler(this.BtnSectores_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.LblStatusBar);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.LblStatusBar.ResumeLayout(false);
            this.LblStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip LblStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnMtoQuerys;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripMenuItem BtnConnOracle;
        private System.Windows.Forms.ToolStripMenuItem BtnConnLocal;
        private System.Windows.Forms.ToolStripMenuItem btnConfigGral;
        private System.Windows.Forms.ToolStripMenuItem BtnActualizarCat;
        private System.Windows.Forms.ToolStripMenuItem BtnIniciar;
        private System.Windows.Forms.ToolStripMenuItem BtnDetener;
        private System.Windows.Forms.ToolStripMenuItem BtnReset;
        private System.Windows.Forms.ToolStripMenuItem BtnSalir;
        private System.Windows.Forms.ToolStripMenuItem BtnLanzar;
        private System.Windows.Forms.ToolStripMenuItem BtnSectores;
    }
}



