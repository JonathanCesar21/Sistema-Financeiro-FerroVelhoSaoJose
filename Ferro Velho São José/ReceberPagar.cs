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
    public partial class ReceberPagar : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        DataTable dtReceber = new DataTable();
        DataTable dtPagar = new DataTable();

        string strSQL;
        public ReceberPagar()
        {
            InitializeComponent();
        }

        private void ReceberPagar_Load(object sender, EventArgs e)
        {

            string hoje = DateTime.Now.ToShortDateString();

            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                strSQL = "SELECT Vencimento,Nome_cli, Valor, N_parcela, T_parcelas, N_boleto, Obs FROM receber_tb WHERE vencimento ='"+hoje+"'";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtgvReceber.DataSource = ds.Tables[0];
                dtReceber = ds.Tables[0];

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

                dtgvPagar.DataSource = ds.Tables[0];
                dtPagar = ds.Tables[0];

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

        private void NotificarBalaoPagar()
        {
            notifyReceber.ShowBalloonTip(999999999, "Sistema gestão", "Contas a Receber Hoje!!!", ToolTipIcon.Info);
        }

        private void NotificarBalaoReceber()
        {
            notifyPagar.ShowBalloonTip(999999999, "Sistema gestão", "Contas a Pagar Hoje!!!", ToolTipIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void btnPesquisarReceber_Click(object sender, EventArgs e)
        {
            FiltrarVencimentoReceber();

        }

        private void FiltrarVencimentoReceber()
        {
            dtReceber.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Vencimento", mtbVencimentoReceber.Text);
            dtgvReceber.DataSource = dtReceber;
        }

        private void btnPesquisarPagar_Click(object sender, EventArgs e)
        {
            FiltrarVencimentoPagar();

        }

        private void FiltrarVencimentoPagar()
        {
            dtPagar.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Vencimento", mtbVencimentoPagar.Text);
            dtgvPagar.DataSource = dtPagar;
        }
        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void ComboBoxSetFocus(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            cb.Focus();
        }

        private void ReceberPagar_LocationChanged(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
