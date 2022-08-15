namespace Ferro_Velho_São_José
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnReceberPagar = new System.Windows.Forms.Button();
            this.btnContasPagarCadastro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContasReceberCadastro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarPagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarBaixarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarExcluidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberRecebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberBaixarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberExcluidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarReceberHojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyPagar = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyReceber = new System.Windows.Forms.NotifyIcon(this.components);
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFormasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCentrosDeCustoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGruposCentrrosDeCustoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Orange;
            this.panelPrincipal.Controls.Add(this.btnReceberPagar);
            this.panelPrincipal.Controls.Add(this.btnContasPagarCadastro);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.btnContasReceberCadastro);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(125, 461);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReceberPagar
            // 
            this.btnReceberPagar.FlatAppearance.BorderSize = 0;
            this.btnReceberPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceberPagar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnReceberPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceberPagar.Location = new System.Drawing.Point(0, 215);
            this.btnReceberPagar.Name = "btnReceberPagar";
            this.btnReceberPagar.Size = new System.Drawing.Size(125, 41);
            this.btnReceberPagar.TabIndex = 3;
            this.btnReceberPagar.Text = "Receber/Pagar";
            this.btnReceberPagar.UseVisualStyleBackColor = true;
            this.btnReceberPagar.Click += new System.EventHandler(this.btnReceberPagar_Click);
            // 
            // btnContasPagarCadastro
            // 
            this.btnContasPagarCadastro.FlatAppearance.BorderSize = 0;
            this.btnContasPagarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContasPagarCadastro.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnContasPagarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContasPagarCadastro.Location = new System.Drawing.Point(0, 169);
            this.btnContasPagarCadastro.Name = "btnContasPagarCadastro";
            this.btnContasPagarCadastro.Size = new System.Drawing.Size(125, 40);
            this.btnContasPagarCadastro.TabIndex = 2;
            this.btnContasPagarCadastro.Text = "Contas a Pagar";
            this.btnContasPagarCadastro.UseVisualStyleBackColor = true;
            this.btnContasPagarCadastro.Click += new System.EventHandler(this.btnContasPagarCadastro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 107);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferro_Velho_São_José.Properties.Resources.logo_preta;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnContasReceberCadastro
            // 
            this.btnContasReceberCadastro.FlatAppearance.BorderSize = 0;
            this.btnContasReceberCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContasReceberCadastro.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnContasReceberCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContasReceberCadastro.Location = new System.Drawing.Point(0, 123);
            this.btnContasReceberCadastro.Name = "btnContasReceberCadastro";
            this.btnContasReceberCadastro.Size = new System.Drawing.Size(125, 40);
            this.btnContasReceberCadastro.TabIndex = 1;
            this.btnContasReceberCadastro.Text = "Contas a Receber";
            this.btnContasReceberCadastro.UseVisualStyleBackColor = true;
            this.btnContasReceberCadastro.Click += new System.EventHandler(this.btnContasReceberCadastro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(125, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.financeiroToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarPagasToolStripMenuItem,
            this.contasAReceberRecebidasToolStripMenuItem,
            this.contasAPagarReceberHojeToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarPagasToolStripMenuItem
            // 
            this.contasAPagarPagasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarCadastroToolStripMenuItem,
            this.contasAPagarBaixarToolStripMenuItem,
            this.contasAPagarExcluidasToolStripMenuItem});
            this.contasAPagarPagasToolStripMenuItem.Name = "contasAPagarPagasToolStripMenuItem";
            this.contasAPagarPagasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.contasAPagarPagasToolStripMenuItem.Text = "Contas a Pagar/Pagas";
            // 
            // contasAPagarCadastroToolStripMenuItem
            // 
            this.contasAPagarCadastroToolStripMenuItem.Name = "contasAPagarCadastroToolStripMenuItem";
            this.contasAPagarCadastroToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasAPagarCadastroToolStripMenuItem.Text = "Contas a Pagar - Cadastro";
            this.contasAPagarCadastroToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarCadastroToolStripMenuItem_Click);
            // 
            // contasAPagarBaixarToolStripMenuItem
            // 
            this.contasAPagarBaixarToolStripMenuItem.Name = "contasAPagarBaixarToolStripMenuItem";
            this.contasAPagarBaixarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasAPagarBaixarToolStripMenuItem.Text = "Contas a Pagar - Baixar";
            // 
            // contasAPagarExcluidasToolStripMenuItem
            // 
            this.contasAPagarExcluidasToolStripMenuItem.Name = "contasAPagarExcluidasToolStripMenuItem";
            this.contasAPagarExcluidasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasAPagarExcluidasToolStripMenuItem.Text = "Contas a Pagar - Excluidas";
            // 
            // contasAReceberRecebidasToolStripMenuItem
            // 
            this.contasAReceberRecebidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAReceberCadastroToolStripMenuItem,
            this.contasAReceberBaixarToolStripMenuItem,
            this.contasAReceberExcluidasToolStripMenuItem});
            this.contasAReceberRecebidasToolStripMenuItem.Name = "contasAReceberRecebidasToolStripMenuItem";
            this.contasAReceberRecebidasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.contasAReceberRecebidasToolStripMenuItem.Text = "Contas a Receber/Recebidas";
            // 
            // contasAReceberCadastroToolStripMenuItem
            // 
            this.contasAReceberCadastroToolStripMenuItem.Name = "contasAReceberCadastroToolStripMenuItem";
            this.contasAReceberCadastroToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.contasAReceberCadastroToolStripMenuItem.Text = "Contas a Receber - Cadastro";
            this.contasAReceberCadastroToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberCadastroToolStripMenuItem_Click);
            // 
            // contasAReceberBaixarToolStripMenuItem
            // 
            this.contasAReceberBaixarToolStripMenuItem.Name = "contasAReceberBaixarToolStripMenuItem";
            this.contasAReceberBaixarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.contasAReceberBaixarToolStripMenuItem.Text = "Contas a Receber - Baixar";
            // 
            // contasAReceberExcluidasToolStripMenuItem
            // 
            this.contasAReceberExcluidasToolStripMenuItem.Name = "contasAReceberExcluidasToolStripMenuItem";
            this.contasAReceberExcluidasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.contasAReceberExcluidasToolStripMenuItem.Text = "Contas a Receber - Excluidas";
            // 
            // contasAPagarReceberHojeToolStripMenuItem
            // 
            this.contasAPagarReceberHojeToolStripMenuItem.Name = "contasAPagarReceberHojeToolStripMenuItem";
            this.contasAPagarReceberHojeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.contasAPagarReceberHojeToolStripMenuItem.Text = "Contas a Pagar/Receber - Hoje";
            this.contasAPagarReceberHojeToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarReceberHojeToolStripMenuItem_Click);
            // 
            // notifyPagar
            // 
            this.notifyPagar.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyPagar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyPagar.Icon")));
            this.notifyPagar.Text = "Contas a Pagar Hoje";
            this.notifyPagar.Visible = true;
            // 
            // notifyReceber
            // 
            this.notifyReceber.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyReceber.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyReceber.Icon")));
            this.notifyReceber.Text = "Contas a Pagar Hoje";
            this.notifyReceber.Visible = true;
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeFornecedoresToolStripMenuItem});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // financeiroToolStripMenuItem1
            // 
            this.financeiroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFormasDePagamentoToolStripMenuItem,
            this.cadastroDeCentrosDeCustoToolStripMenuItem,
            this.cadastroDeGruposCentrrosDeCustoToolStripMenuItem});
            this.financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            this.financeiroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores";
            this.cadastroDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // cadastroDeFormasDePagamentoToolStripMenuItem
            // 
            this.cadastroDeFormasDePagamentoToolStripMenuItem.Name = "cadastroDeFormasDePagamentoToolStripMenuItem";
            this.cadastroDeFormasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.cadastroDeFormasDePagamentoToolStripMenuItem.Text = "Cadastro de Formas de Pagamento";
            this.cadastroDeFormasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFormasDePagamentoToolStripMenuItem_Click);
            // 
            // cadastroDeCentrosDeCustoToolStripMenuItem
            // 
            this.cadastroDeCentrosDeCustoToolStripMenuItem.Name = "cadastroDeCentrosDeCustoToolStripMenuItem";
            this.cadastroDeCentrosDeCustoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.cadastroDeCentrosDeCustoToolStripMenuItem.Text = "Cadastro de Centros de Custo";
            // 
            // cadastroDeGruposCentrrosDeCustoToolStripMenuItem
            // 
            this.cadastroDeGruposCentrrosDeCustoToolStripMenuItem.Name = "cadastroDeGruposCentrrosDeCustoToolStripMenuItem";
            this.cadastroDeGruposCentrrosDeCustoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.cadastroDeGruposCentrrosDeCustoToolStripMenuItem.Text = "Cadastro de Grupos Centrros de Custo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelPrincipal;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnContasReceberCadastro;
        private Button btnReceberPagar;
        private Button btnContasPagarCadastro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem contasAPagarPagasToolStripMenuItem;
        private ToolStripMenuItem contasAPagarCadastroToolStripMenuItem;
        private ToolStripMenuItem contasAPagarBaixarToolStripMenuItem;
        private ToolStripMenuItem contasAPagarExcluidasToolStripMenuItem;
        private ToolStripMenuItem contasAReceberRecebidasToolStripMenuItem;
        private ToolStripMenuItem contasAPagarReceberHojeToolStripMenuItem;
        private ToolStripMenuItem contasAReceberCadastroToolStripMenuItem;
        private ToolStripMenuItem contasAReceberBaixarToolStripMenuItem;
        private ToolStripMenuItem contasAReceberExcluidasToolStripMenuItem;
        private NotifyIcon notifyPagar;
        private NotifyIcon notifyReceber;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem1;
        private ToolStripMenuItem cadastroDeFormasDePagamentoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCentrosDeCustoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeGruposCentrrosDeCustoToolStripMenuItem;
    }
}