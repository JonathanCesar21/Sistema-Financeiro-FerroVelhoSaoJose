using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferro_Velho_São_José
{
    public partial class Menu : Form
    {
        private Form frmAtivo;
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
            Lancamento child = new Lancamento();
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
        }

        private void contasAPagarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancamento child = new Lancamento();
            child.MdiParent = Menu.ActiveForm;
            child.Show();
        }
    }
}
