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
    public partial class login : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-1HS5HBK\SQLEXPRESS;Database=ferrovelho;Trusted_Connection=True;");
                conexao.Open();

                strSQL = "SELECT * FROM usuarios_tb where usuario = '" + txtUsuario.Text + "' AND senha ='" + txtSenha.Text + "'";

                SqlDataAdapter dp = new SqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    Lancamento TelaLancamentos = new Lancamento();
                    this.Hide();
                    TelaLancamentos.Show();
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Select();
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
    }
}
