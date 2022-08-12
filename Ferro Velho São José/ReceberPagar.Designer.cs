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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceberPagar));
            this.dtgvPagar = new System.Windows.Forms.DataGridView();
            this.dtgvReceber = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyReceber = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyPagar = new System.Windows.Forms.NotifyIcon(this.components);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contas a Receber Hoje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contas a Pagar Hoje";
            // 
            // notifyReceber
            // 
            this.notifyReceber.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyReceber.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyReceber.Icon")));
            this.notifyReceber.Text = "Contas a Receber Hoje";
            this.notifyReceber.Visible = true;
            // 
            // notifyPagar
            // 
            this.notifyPagar.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyPagar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyPagar.Icon")));
            this.notifyPagar.Text = "Contas a Pagar Hoje";
            this.notifyPagar.Visible = true;
            // 
            // ReceberPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtgvReceber);
            this.Controls.Add(this.dtgvPagar);
            this.Name = "ReceberPagar";
            this.Text = "ReceberPagar";
            this.Load += new System.EventHandler(this.ReceberPagar_Load);
            this.LocationChanged += new System.EventHandler(this.ReceberPagar_LocationChanged);
            this.Click += new System.EventHandler(this.ReceberPagar_LocationChanged);
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
        private Label label1;
        private Label label2;
        private NotifyIcon notifyReceber;
        private NotifyIcon notifyPagar;
    }
}