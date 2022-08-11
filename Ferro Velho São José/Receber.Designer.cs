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
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(244, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(55, 41);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vencimento";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(236, 142);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(303, 23);
            this.txtCliente.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(434, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(65, 41);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(505, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parcela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nº Parcelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Observação:";
            // 
            // mtbVencimento
            // 
            this.mtbVencimento.Location = new System.Drawing.Point(151, 84);
            this.mtbVencimento.Mask = "00/00/0000";
            this.mtbVencimento.Name = "mtbVencimento";
            this.mtbVencimento.Size = new System.Drawing.Size(69, 23);
            this.mtbVencimento.TabIndex = 20;
            this.mtbVencimento.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbVencimento.Enter += new System.EventHandler(this.mtbVencimento_Enter);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(148, 235);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(560, 33);
            this.txtObs.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "CNPJ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(151, 186);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(121, 23);
            this.mtbCpf.TabIndex = 27;
            this.mtbCpf.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbCpf.Enter += new System.EventHandler(this.mtbCpf_Enter);
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Location = new System.Drawing.Point(278, 186);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(121, 23);
            this.mtbCnpj.TabIndex = 28;
            this.mtbCnpj.Click += new System.EventHandler(this.MaskedTextBoxSetFocus);
            this.mtbCnpj.Enter += new System.EventHandler(this.mtbCnpj_Enter);
            // 
            // txtNParcela
            // 
            this.txtNParcela.Location = new System.Drawing.Point(319, 84);
            this.txtNParcela.Name = "txtNParcela";
            this.txtNParcela.Size = new System.Drawing.Size(45, 23);
            this.txtNParcela.TabIndex = 29;
            // 
            // txtTParcelas
            // 
            this.txtTParcelas.Location = new System.Drawing.Point(387, 84);
            this.txtTParcelas.Name = "txtTParcelas";
            this.txtTParcelas.Size = new System.Drawing.Size(45, 23);
            this.txtTParcelas.TabIndex = 30;
            // 
            // dtgvReceber
            // 
            this.dtgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReceber.Location = new System.Drawing.Point(148, 274);
            this.dtgvReceber.Name = "dtgvReceber";
            this.dtgvReceber.RowTemplate.Height = 25;
            this.dtgvReceber.Size = new System.Drawing.Size(560, 187);
            this.dtgvReceber.TabIndex = 31;
            // 
            // txtNBoleto
            // 
            this.txtNBoleto.Location = new System.Drawing.Point(410, 186);
            this.txtNBoleto.Name = "txtNBoleto";
            this.txtNBoleto.Size = new System.Drawing.Size(129, 23);
            this.txtNBoleto.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nº Boleto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(151, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 23);
            this.textBox2.TabIndex = 34;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(236, 84);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(63, 23);
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
            this.lblData.Location = new System.Drawing.Point(698, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(10, 15);
            this.lblData.TabIndex = 37;
            this.lblData.Text = ".";
            // 
            // Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(820, 462);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNBoleto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgvReceber);
            this.Controls.Add(this.txtTParcelas);
            this.Controls.Add(this.txtNParcela);
            this.Controls.Add(this.mtbCnpj);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.mtbVencimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Receber";
            this.Text = "Receber";
            this.Load += new System.EventHandler(this.Receber_Load);
            this.LocationChanged += new System.EventHandler(this.Receber_LocationChanged);
            this.Click += new System.EventHandler(this.Receber_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGravar;
        private Label label1;
        private TextBox txtCliente;
        private Button button2;
        private Button button3;
        private Button btnPesquisar;
        private Button button5;
        private Label label2;
        private Label label3;
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
    }
}