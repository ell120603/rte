namespace Crud_Eliel
{
    partial class FrmMenu
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
            this.PRC = new System.Diagnostics.Process();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PRC
            // 
            this.PRC.StartInfo.Domain = "";
            this.PRC.StartInfo.LoadUserProfile = false;
            this.PRC.StartInfo.Password = null;
            this.PRC.StartInfo.StandardErrorEncoding = null;
            this.PRC.StartInfo.StandardOutputEncoding = null;
            this.PRC.StartInfo.UserName = "";
            this.PRC.SynchronizingObject = this;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastarItemToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Cadastro";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "&Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // cadastarItemToolStripMenuItem
            // 
            this.cadastarItemToolStripMenuItem.Name = "cadastarItemToolStripMenuItem";
            this.cadastarItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.cadastarItemToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastarItemToolStripMenuItem.Text = "&Cadastar Item";
            this.cadastarItemToolStripMenuItem.Click += new System.EventHandler(this.cadastarItemToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClienteToolStripMenuItem,
            this.consultaItemToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // consultaClienteToolStripMenuItem
            // 
            this.consultaClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripMenuItem,
            this.codigoToolStripMenuItem});
            this.consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            this.consultaClienteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultaClienteToolStripMenuItem.Text = "Consulta cliente ";
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nomeToolStripMenuItem.Text = "Nome";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.nomeToolStripMenuItem_Click);
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.codigoToolStripMenuItem.Text = "Codigo";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoToolStripMenuItem_Click);
            // 
            // consultaItemToolStripMenuItem
            // 
            this.consultaItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripMenuItem1,
            this.nomeToolStripMenuItem1});
            this.consultaItemToolStripMenuItem.Name = "consultaItemToolStripMenuItem";
            this.consultaItemToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultaItemToolStripMenuItem.Text = "Consulta item";
            // 
            // codigoToolStripMenuItem1
            // 
            this.codigoToolStripMenuItem1.Name = "codigoToolStripMenuItem1";
            this.codigoToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.codigoToolStripMenuItem1.Text = "Codigo";
            this.codigoToolStripMenuItem1.Click += new System.EventHandler(this.codigoToolStripMenuItem1_Click);
            // 
            // nomeToolStripMenuItem1
            // 
            this.nomeToolStripMenuItem1.Name = "nomeToolStripMenuItem1";
            this.nomeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.nomeToolStripMenuItem1.Text = "Nome";
            this.nomeToolStripMenuItem1.Click += new System.EventHandler(this.nomeToolStripMenuItem1_Click);
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.consultaToolStripMenuItem,
            this.funçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.Process PRC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}