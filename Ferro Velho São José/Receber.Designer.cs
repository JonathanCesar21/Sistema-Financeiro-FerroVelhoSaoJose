namespace Ferro_Velho_São_José
{
    partial class Receber
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNParcela = new System.Windows.Forms.TextBox();
            this.txtTParcelas = new System.Windows.Forms.TextBox();
            this.dtgvReceber = new System.Windows.Forms.DataGridView();
            this.txtNBoleto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbDataMov = new System.Windows.Forms.MaskedTextBox();
            this.datamov = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mtbFim = new System.Windows.Forms.MaskedTextBox();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.rbCTodas = new System.Windows.Forms.RadioButton();
            this.rbCAbertas = new System.Windows.Forms.RadioButton();
            this.rbCPagas = new System.Windows.Forms.RadioButton();
            this.mtbDataNf = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.cbCentroCustos = new System.Windows.Forms.ComboBox();
            this.cbGrupoCustos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "1º Vencimento";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(175, 22);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(303, 23);
            this.txtFornecedor.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::Ferro_Velho_São_José.Properties.Resources.borracha1;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(10, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(58, 41);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor R$";
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSize = true;
            this.Fornecedor.Location = new System.Drawing.Point(172, 4);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(67, 15);
            this.Fornecedor.TabIndex = 12;
            this.Fornecedor.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parcela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "de:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Observação:";
            // 
            // mtbVencimento
            // 
            this.mtbVencimento.Location = new System.Drawing.Point(8, 22);
            this.mtbVencimento.Mask = "00/00/0000";
            this.mtbVencimento.Name = "mtbVencimento";
            this.mtbVencimento.Size = new System.Drawing.Size(81, 23);
            this.mtbVencimento.TabIndex = 20;
            this.mtbVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbVencimento.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbVencimento.Enter += new System.EventHandler(this.mtbVencimento_Enter);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 224);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(781, 33);
            this.txtObs.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "CNPJ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(259, 114);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(88, 23);
            this.mtbCpf.TabIndex = 27;
            this.mtbCpf.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbCpf.Enter += new System.EventHandler(this.mtbCpf_Enter);
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Location = new System.Drawing.Point(353, 114);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(105, 23);
            this.mtbCnpj.TabIndex = 28;
            this.mtbCnpj.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbCnpj.Enter += new System.EventHandler(this.mtbCnpj_Enter);
            // 
            // txtNParcela
            // 
            this.txtNParcela.Location = new System.Drawing.Point(81, 67);
            this.txtNParcela.Name = "txtNParcela";
            this.txtNParcela.Size = new System.Drawing.Size(45, 23);
            this.txtNParcela.TabIndex = 29;
            // 
            // txtTParcelas
            // 
            this.txtTParcelas.Location = new System.Drawing.Point(132, 67);
            this.txtTParcelas.Name = "txtTParcelas";
            this.txtTParcelas.Size = new System.Drawing.Size(47, 23);
            this.txtTParcelas.TabIndex = 30;
            // 
            // dtgvReceber
            // 
            this.dtgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReceber.Location = new System.Drawing.Point(12, 263);
            this.dtgvReceber.Name = "dtgvReceber";
            this.dtgvReceber.ReadOnly = true;
            this.dtgvReceber.RowTemplate.Height = 25;
            this.dtgvReceber.Size = new System.Drawing.Size(781, 323);
            this.dtgvReceber.TabIndex = 31;
            // 
            // txtNBoleto
            // 
            this.txtNBoleto.Location = new System.Drawing.Point(158, 114);
            this.txtNBoleto.Name = "txtNBoleto";
            this.txtNBoleto.Size = new System.Drawing.Size(95, 23);
            this.txtNBoleto.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "NF/Fatura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(97, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 23);
            this.textBox2.TabIndex = 34;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(709, 22);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 23);
            this.txtValor.TabIndex = 36;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(625, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(10, 15);
            this.lblData.TabIndex = 37;
            this.lblData.Text = ".";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Ferro_Velho_São_José.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(138, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 41);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Ferro_Velho_São_José.Properties.Resources.delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(211, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(58, 41);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = global::Ferro_Velho_São_José.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(275, 11);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 41);
            this.btnAtualizar.TabIndex = 40;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnBaixar
            // 
            this.btnBaixar.FlatAppearance.BorderSize = 0;
            this.btnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixar.Image = global::Ferro_Velho_São_José.Properties.Resources.baixar;
            this.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaixar.Location = new System.Drawing.Point(346, 11);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(58, 41);
            this.btnBaixar.TabIndex = 41;
            this.btnBaixar.Text = "Baixa";
            this.btnBaixar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaixar.UseVisualStyleBackColor = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::Ferro_Velho_São_José.Properties.Resources.restaurar;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestaurar.Location = new System.Drawing.Point(410, 11);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(66, 41);
            this.btnRestaurar.TabIndex = 42;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Image = global::Ferro_Velho_São_José.Properties.Resources.gravar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(74, 11);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(58, 41);
            this.btnGravar.TabIndex = 43;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbDataMov);
            this.panel1.Controls.Add(this.datamov);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.mtbFim);
            this.panel1.Controls.Add(this.mtbInicio);
            this.panel1.Controls.Add(this.rbCTodas);
            this.panel1.Controls.Add(this.rbCAbertas);
            this.panel1.Controls.Add(this.rbCPagas);
            this.panel1.Controls.Add(this.mtbDataNf);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbBanco);
            this.panel1.Controls.Add(this.cbCentroCustos);
            this.panel1.Controls.Add(this.cbGrupoCustos);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtNBoleto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDesconto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtbCnpj);
            this.panel1.Controls.Add(this.cbFormaPagamento);
            this.panel1.Controls.Add(this.mtbCpf);
            this.panel1.Controls.Add(this.txtTParcelas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mtbVencimento);
            this.panel1.Controls.Add(this.txtNParcela);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtFornecedor);
            this.panel1.Controls.Add(this.Fornecedor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(10, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 402);
            this.panel1.TabIndex = 44;
            // 
            // mtbDataMov
            // 
            this.mtbDataMov.Location = new System.Drawing.Point(8, 114);
            this.mtbDataMov.Mask = "00/00/0000";
            this.mtbDataMov.Name = "mtbDataMov";
            this.mtbDataMov.Size = new System.Drawing.Size(69, 23);
            this.mtbDataMov.TabIndex = 60;
            this.mtbDataMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datamov
            // 
            this.datamov.AutoSize = true;
            this.datamov.Location = new System.Drawing.Point(8, 96);
            this.datamov.Name = "datamov";
            this.datamov.Size = new System.Drawing.Size(58, 15);
            this.datamov.TabIndex = 59;
            this.datamov.Text = "Data Mov";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 58;
            this.label16.Text = "Pesquisar Período";
            // 
            // mtbFim
            // 
            this.mtbFim.Location = new System.Drawing.Point(556, 114);
            this.mtbFim.Mask = "00/00/0000";
            this.mtbFim.Name = "mtbFim";
            this.mtbFim.Size = new System.Drawing.Size(69, 23);
            this.mtbFim.TabIndex = 56;
            this.mtbFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbInicio
            // 
            this.mtbInicio.Location = new System.Drawing.Point(481, 114);
            this.mtbInicio.Mask = "00/00/0000";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(69, 23);
            this.mtbInicio.TabIndex = 54;
            this.mtbInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbCTodas
            // 
            this.rbCTodas.AutoSize = true;
            this.rbCTodas.Location = new System.Drawing.Point(661, 136);
            this.rbCTodas.Name = "rbCTodas";
            this.rbCTodas.Size = new System.Drawing.Size(56, 19);
            this.rbCTodas.TabIndex = 52;
            this.rbCTodas.TabStop = true;
            this.rbCTodas.Text = "Todos";
            this.rbCTodas.UseVisualStyleBackColor = true;
            this.rbCTodas.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbCAbertas
            // 
            this.rbCAbertas.AutoSize = true;
            this.rbCAbertas.Location = new System.Drawing.Point(660, 99);
            this.rbCAbertas.Name = "rbCAbertas";
            this.rbCAbertas.Size = new System.Drawing.Size(105, 19);
            this.rbCAbertas.TabIndex = 51;
            this.rbCAbertas.TabStop = true;
            this.rbCAbertas.Text = "Contas Abertas";
            this.rbCAbertas.UseVisualStyleBackColor = true;
            // 
            // rbCPagas
            // 
            this.rbCPagas.AutoSize = true;
            this.rbCPagas.Location = new System.Drawing.Point(661, 118);
            this.rbCPagas.Name = "rbCPagas";
            this.rbCPagas.Size = new System.Drawing.Size(96, 19);
            this.rbCPagas.TabIndex = 50;
            this.rbCPagas.TabStop = true;
            this.rbCPagas.Text = "Contas Pagas";
            this.rbCPagas.UseVisualStyleBackColor = true;
            // 
            // mtbDataNf
            // 
            this.mtbDataNf.Location = new System.Drawing.Point(83, 114);
            this.mtbDataNf.Mask = "00/00/0000";
            this.mtbDataNf.Name = "mtbDataNf";
            this.mtbDataNf.Size = new System.Drawing.Size(69, 23);
            this.mtbDataNf.TabIndex = 49;
            this.mtbDataNf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(83, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Data NF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(529, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "Banco";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 45;
            this.label13.Text = "Centro de Custo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Grupo Centro de Custo";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(529, 67);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(248, 23);
            this.cbBanco.TabIndex = 43;
            // 
            // cbCentroCustos
            // 
            this.cbCentroCustos.FormattingEnabled = true;
            this.cbCentroCustos.Location = new System.Drawing.Point(357, 67);
            this.cbCentroCustos.Name = "cbCentroCustos";
            this.cbCentroCustos.Size = new System.Drawing.Size(166, 23);
            this.cbCentroCustos.TabIndex = 42;
            // 
            // cbGrupoCustos
            // 
            this.cbGrupoCustos.FormattingEnabled = true;
            this.cbGrupoCustos.Location = new System.Drawing.Point(185, 67);
            this.cbGrupoCustos.Name = "cbGrupoCustos";
            this.cbGrupoCustos.Size = new System.Drawing.Size(166, 23);
            this.cbGrupoCustos.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(8, 67);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(69, 23);
            this.txtDesconto.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Forma de Pagamento";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(484, 22);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(219, 23);
            this.cbFormaPagamento.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(474, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 37);
            this.panel2.TabIndex = 57;
            // 
            // Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(799, 590);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtgvReceber);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Name = "Receber";
            this.Text = "Manutenção de contas a Receber/Recebidas";
            this.Load += new System.EventHandler(this.Receber_Load);
            this.Click += new System.EventHandler(this.Receber_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txtFornecedor;
        private Button btnLimpar;
        private Label label2;
        private Label Fornecedor;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtbVencimento;
        private TextBox txtObs;
        private Label label7;
        private Label label8;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbCnpj;
        private TextBox txtNParcela;
        private TextBox txtTParcelas;
        private DataGridView dtgvReceber;
        private TextBox txtNBoleto;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox txtValor;
        private System.Windows.Forms.Timer timer1;
        private Label lblData;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnBaixar;
        private Button btnRestaurar;
        private Button btnGravar;
        private Panel panel1;
        private Label label3;
        private ComboBox cbFormaPagamento;
        private MaskedTextBox mtbDataNf;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox cbBanco;
        private ComboBox cbCentroCustos;
        private ComboBox cbGrupoCustos;
        private Label label11;
        private TextBox txtDesconto;
        private RadioButton rbCTodas;
        private RadioButton rbCAbertas;
        private RadioButton rbCPagas;
        private MaskedTextBox mtbFim;
        private MaskedTextBox mtbInicio;
        private Panel panel2;
        private Label label16;
        private MaskedTextBox mtbDataMov;
        private Label datamov;
    }
}