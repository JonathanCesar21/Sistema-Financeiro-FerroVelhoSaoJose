using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ferro_Velho_São_José
{
    public partial class Menu : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        DataTable dtReceber = new DataTable();
        DataTable dtPagar = new DataTable();

        string strSQL;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        } 
   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContasReceberCadastro_Click(object sender, EventArgs e)
        {
            Receber child = new Receber();
            child.MdiParent = Menu.ActiveForm;
            child.Show();

            //ActiveButton(btnContasReceberCadastro);
            //FormShow(new Receber());

        }

        private void btnContasPagarCadastro_Click(object sender, EventArgs e)
        {
            Pagar child = new Pagar();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }

        private void panelForm_Click(object sender, EventArgs e)
        {

        }

        private void btnReceberPagar_Click(object sender, EventArgs e)
        {
            ReceberPagar child = new ReceberPagar();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width - 20;
            int h = Screen.PrimaryScreen.Bounds.Height - 50;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            string hoje = DateTime.Now.ToShortDateString();

            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                strSQL = "SELECT Vencimento,Nome_cli, Valor, N_parcela, T_parcelas, N_boleto, Obs FROM receber_tb WHERE vencimento ='" + hoje + "'";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);


                SqlDataAdapter dpr = new SqlDataAdapter(strSQL, conexao);
                DataTable dtr = new DataTable();
                dpr.Fill(dtr);

                if (dtr.Rows.Count > 0)
                {
                    NotificarBalaoReceber();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                strSQL = "select Vencimento, Nome_frn, Valor, N_parcela, T_parcelas, N_boleto, Obs from lancamentos_tb WHERE vencimento ='" + hoje + "'";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                SqlDataAdapter dpp = new SqlDataAdapter(strSQL, conexao);
                DataTable dtp = new DataTable();
                dpp.Fill(dtp);

                if (dtp.Rows.Count > 0)
                {
                    NotificarBalaoPagar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void NotificarBalaoReceber()
        {
            notifyReceber.ShowBalloonTip(9999999, "Sistema gestão", "Contas a Receber Hoje!!!", ToolTipIcon.Info);
        }

        private void NotificarBalaoPagar()
        {
            notifyPagar.ShowBalloonTip(9999999, "Sistema gestão", "Contas a Pagar Hoje!!!", ToolTipIcon.Warning);
        }

        private void contasAPagarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagar child = new Pagar();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }

        private void contasAReceberCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receber child = new Receber();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }

        private void contasAPagarReceberHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceberPagar child = new ReceberPagar();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }

        private void cadastroDeFormasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor child = new CadastroFornecedor();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }
    }

}

