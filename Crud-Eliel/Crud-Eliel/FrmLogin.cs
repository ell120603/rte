using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Crud_Eliel
{
    public partial class FrmLogin : Form
    {
        MySqlConnection con;
        MySqlCommand comandoMysql;
        string caminhoBanco = "SERVER=localhost; DATABASE=BD_Crud; USER ID=root ; PASSWORD=1819 ;";
        MySqlDataReader leitura_dados;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(caminhoBanco);
            con.Open();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Campo Login Obrigatorio");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Campo Senha Obrigatorio");
                textBox2.Focus();
                return;
            }
            string sql = "select * from tb_login " +
                " where login_log = '" + textBox1.Text + "' and " +
                " senha_log = '" +textBox2.Text +"' ";
            comandoMysql = new MySqlCommand(sql, con);
            leitura_dados = comandoMysql.ExecuteReader();
            if (leitura_dados.Read())
            {
                leitura_dados.Close();
                con.Close();
                FrmMenu frm = new FrmMenu();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" usuario não encontrado ");
            }

        }
    }
}
