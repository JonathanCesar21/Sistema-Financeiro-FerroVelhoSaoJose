namespace Ferro_Velho_São_José
{
    partial class ReceberPagar
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
            this.dtgvPagar = new System.Windows.Forms.DataGridView();
            this.dtgvReceber = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.btnPesquisarReceber = new System.Windows.Forms.Button();
            this.mtbVencimentoReceber = new System.Windows.Forms.MaskedTextBox();
            this.mtbVencimentoPagar = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPagar
            // 
            this.dtgvPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPagar.Location = new System.Drawing.Point(12, 352);
            this.dtgvPagar.Name = "dtgvPagar";
            this.dtgvPagar.RowTemplate.Height = 25;
            this.dtgvPagar.Size = new System.Drawing.Size(775, 187);
            this.dtgvPagar.TabIndex = 1;
            // 
            // dtgvReceber
            // 
            this.dtgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReceber.Location = new System.Drawing.Point(12, 67);
            this.dtgvReceber.Name = "dtgvReceber";
            this.dtgvReceber.RowTemplate.Height = 25;
            this.dtgvReceber.Size = new System.Drawing.Size(775, 187);
            this.dtgvReceber.TabIndex = 2;
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
            this.lblData.Location = new System.Drawing.Point(620, 11);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(10, 15);
            this.lblData.TabIndex = 3;
            this.lblData.Text = ".";
            // 
            // btnPesquisarReceber
            // 
            this.btnPesquisarReceber.Location = new System.Drawing.Point(85, 36);
            this.btnPesquisarReceber.Name = "btnPesquisarReceber";
            this.btnPesquisarReceber.Size = new System.Drawing.Size(63, 23);
            this.btnPesquisarReceber.TabIndex = 4;
            this.btnPesquisarReceber.Text = "Pesquisar";
            this.btnPesquisarReceber.UseVisualStyleBackColor = true;
            this.btnPesquisarReceber.Click += new System.EventHandler(this.btnPesquisarReceber_Click);
            // 
            // mtbVencimentoReceber
            // 
            this.mtbVencimentoReceber.Location = new System.Drawing.Point(12, 37);
            this.mtbVencimentoReceber.Mask = "00/00/0000";
            this.mtbVencimentoReceber.Name = "mtbVencimentoReceber";
            this.mtbVencimentoReceber.Size = new System.Drawing.Size(67, 23);
            this.mtbVencimentoReceber.TabIndex = 5;
            // 
            // mtbVencimentoPagar
            // 
            this.mtbVencimentoPagar.Location = new System.Drawing.Point(12, 323);
            this.mtbVencimentoPagar.Mask = "00/00/0000";
            this.mtbVencimentoPagar.Name = "mtbVencimentoPagar";
            this.mtbVencimentoPagar.Size = new System.Drawing.Size(67, 23);
            this.mtbVencimentoPagar.TabIndex = 7;
            // 
            // btnPesquisarPagar
            // 
            this.btnPesquisarPagar.Location = new System.Drawing.Point(85, 322);
            this.btnPesquisarPagar.Name = "btnPesquisarPagar";
            this.btnPesquisarPagar.Size = new System.Drawing.Size(63, 23);
            this.btnPesquisarPagar.TabIndex = 6;
            this.btnPesquisarPagar.Text = "Pesquisar";
            this.btnPesquisarPagar.UseVisualStyleBackColor = true;
            this.btnPesquisarPagar.Click += new System.EventHandler(this.btnPesquisarPagar_Click);
            // 
            // ReceberPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 568);
            this.Controls.Add(this.mtbVencimentoPagar);
            this.Controls.Add(this.btnPesquisarPagar);
            this.Controls.Add(this.mtbVencimentoReceber);
            this.Controls.Add(this.btnPesquisarReceber);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtgvReceber);
            this.Controls.Add(this.dtgvPagar);
            this.Name = "ReceberPagar";
            this.Text = "ReceberPagar";
            this.Load += new System.EventHandler(this.ReceberPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dtgvPagar;
        private DataGridView dtgvReceber;
        private System.Windows.Forms.Timer timer1;
        private Label lblData;
        private Button btnPesquisarReceber;
        private MaskedTextBox mtbVencimentoReceber;
        private MaskedTextBox mtbVencimentoPagar;
        private Button btnPesquisarPagar;
    }
}