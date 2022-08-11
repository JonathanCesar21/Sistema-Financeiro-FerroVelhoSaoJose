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
    public partial class Receber : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Receber()
        {
            InitializeComponent();
        }

        private void Receber_Load(object sender, EventArgs e)
        {
            this.mtbCpf.Mask = @"009\.009\.009\-00";
            this.mtbCnpj.Mask = @"00\.000\.000/0000-00";

        }

        private void mtbVencimento_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbVencimento.Select(0, 0);
            });
        }
        private void mtbCnpj_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbCnpj.Select(0, 0);
            });
        }
        private void mtbCpf_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbCpf.Select(0, 0);
            });
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                strSQL = "INSERT INTO receber_tb (Nome_cli, Cpf_cli, Cnpj_cli, Vencimento, Valor, N_parcela, T_parcelas, Obs, N_boleto) VALUES (@Nome_cli, @Cpf_cli, @Cnpj_cli, @Vencimento, @Valor, @N_parcela, @T_parcelas, @Obs, @N_boleto)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nome_cli", txtCliente.Text);
                comando.Parameters.AddWithValue("@Cpf_cli", mtbCpf.Text);
                comando.Parameters.AddWithValue("@Cnpj_cli", mtbCnpj.Text);
                comando.Parameters.AddWithValue("@Vencimento", mtbVencimento.Text);
                comando.Parameters.AddWithValue("@Valor", txtValor.Text);
                comando.Parameters.AddWithValue("@N_parcela", txtNParcela.Text);
                comando.Parameters.AddWithValue("@T_parcelas", txtTParcelas.Text);
                comando.Parameters.AddWithValue("@Obs", txtObs.Text);
                comando.Parameters.AddWithValue("@N_boleto", txtNBoleto.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try { 
            conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

            strSQL = "select Vencimento,Nome_cli, Valor, N_parcela, T_parcelas, N_boleto from receber_tb";

            DataSet ds = new DataSet();

            da = new SqlDataAdapter(strSQL, conexao);

            conexao.Open();

            da.Fill(ds);

            dtgvReceber.DataSource = ds.Tables[0];
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }
    }
}
