using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Eliel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCC = new FrmCadastroCliente();
            this.Hide();
            frmCC.ShowDialog();
        }

        private void cadastarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCP = new FrmCadastroProduto();
            this.Hide();
            frmCP.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTAR Frm = new CONSULTAR();
            this.Hide();
            Frm.ShowDialog();
            
        }

        private void codigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarProdId Frm = new FrmConsultarProdId();
                this.Hide();
            Frm.ShowDialog();

        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaNome Frm = new FrmConsultaNome();
            this.Hide();
            Frm.ShowDialog();
        }

        private void nomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaProNom Frm = new FrmConsultaProNom();
            this.Hide();
            Frm.ShowDialog();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltDel Frm = new FrmAltDel();
            this.Hide();
            Frm.ShowDialog();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltDelPro Frm = new FrmAltDelPro();
            this.Hide();
            Frm.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
