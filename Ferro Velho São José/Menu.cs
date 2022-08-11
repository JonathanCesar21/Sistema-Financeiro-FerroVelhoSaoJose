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

        private void FormShow(Form frm)
        {
            
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void ActiveFormClose()
        {
            
        }
        
        private void ActiveButton(Button frmAtivo)
        {
            foreach(Control ctrl in panelPrincipal.Controls)
            {
                ctrl.ForeColor = Color.White;
            }

            frmAtivo.ForeColor = Color.Black;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //
            //ActiveFormClose();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContasReceberCadastro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnContasReceberCadastro);
            FormShow(new Receber());

        }

        private void btnContasPagarCadastro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnContasPagarCadastro);
            FormShow(new Lancamento());
        }

        private void panelForm_Click(object sender, EventArgs e)
        {

        }

        private void btnReceberPagar_Click(object sender, EventArgs e)
        {
            ActiveButton(btnReceberPagar);
            FormShow(new ReceberPagar());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
