using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ferro_Velho_São_José
{
    public partial class Lancamento : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public Lancamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            int NParcela = Convert.ToInt32(txtNParcela.Text);
            int TParcelas = Convert.ToInt32(txtTParcelas.Text);
            string dateInString = mtbVencimento.Text;
            DateTime nextDate = DateTime.Parse(dateInString);

            if (TParcelas > 1)
            {
                MessageBox.Show("Você irá gerar " + TParcelas + " parcelas, ok?");

                while (NParcela <= TParcelas)
                {
                    try
                    {
                        conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                        strSQL = "INSERT INTO lancamentos_tb (N_parcela, T_parcelas, Nome_frn, Dt_mov, C_corrente, C_plano, C_custos, Obs, Vencimento, N_Boleto, Valor) VALUES (@N_parcela, @T_parcelas, @Nome_frn, @Dt_mov, @C_corrente, @C_plano, @C_custos, @Obs, @Vencimento, @N_Boleto, @Valor)";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@N_parcela", NParcela);
                        comando.Parameters.AddWithValue("@T_parcelas", txtTParcelas.Text);
                        comando.Parameters.AddWithValue("@Nome_frn", txtFornecedor.Text);
                        comando.Parameters.AddWithValue("@Dt_mov", mtbDataMov.Text);
                        comando.Parameters.AddWithValue("@C_corrente", cbContas.Text);
                        comando.Parameters.AddWithValue("@C_plano", cbPlano.Text);
                        comando.Parameters.AddWithValue("@C_custos", cbCustos.Text);
                        comando.Parameters.AddWithValue("@Vencimento", nextDate.ToShortDateString());
                        comando.Parameters.AddWithValue("@N_boleto", txtNBoleto.Text);
                        comando.Parameters.AddWithValue("@Valor", txtValor.Text);
                        comando.Parameters.AddWithValue("@Obs", txtObs.Text);

                        conexao.Open();
                        comando.ExecuteNonQuery();

                        nextDate = nextDate.AddMonths(1);
                        MessageBox.Show("Parcela " +NParcela+ " Cadastrada com Sucesso!!!");
                        NParcela++;

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
            }
            else if(TParcelas == 1)
            {
                try
                {
                    conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");

                    strSQL = "INSERT INTO lancamentos_tb (N_parcela, T_parcelas, Nome_frn, Dt_mov, C_corrente, C_plano, C_custos, Obs, Vencimento, N_Boleto, Valor) VALUES (@N_parcela, @T_parcelas, @Nome_frn, @Dt_mov, @C_corrente, @C_plano, @C_custos, @Obs, @Vencimento, @N_Boleto, @Valor)";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@N_parcela", NParcela);
                    comando.Parameters.AddWithValue("@T_parcelas", txtTParcelas.Text);
                    comando.Parameters.AddWithValue("@Nome_frn", txtFornecedor.Text);
                    comando.Parameters.AddWithValue("@Dt_mov", mtbDataMov.Text);
                    comando.Parameters.AddWithValue("@C_corrente", cbContas.Text);
                    comando.Parameters.AddWithValue("@C_plano", cbPlano.Text);
                    comando.Parameters.AddWithValue("@C_custos", cbCustos.Text);
                    comando.Parameters.AddWithValue("@Vencimento", mtbVencimento.Text);
                    comando.Parameters.AddWithValue("@N_boleto", txtNBoleto.Text);
                    comando.Parameters.AddWithValue("@Valor", txtValor.Text);
                    comando.Parameters.AddWithValue("@Obs", txtObs.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Parcela Cadastrada com Sucesso!!!");

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
           

        }
            

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void mtbDataMov_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbDataMov.Select(0, 0);
            });
        }

        private void cbContas_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                cbContas.Select(0, 0);
            });
        }

        private void cbPlano_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                cbPlano.Select(0, 0);
            });
        }

        private void cbCustos_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                cbCustos.Select(0, 0);
            });
        }

        private void mtbVencimento_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbVencimento.Select(0, 0);
            });
        }
    }
}