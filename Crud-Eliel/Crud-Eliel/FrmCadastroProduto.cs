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
    public partial class FrmCadastroProduto : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comandoMysql;
        MySqlDataReader leituraDados;
        string sqlTipo;
        int idTipo;
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlInsert = "insert into tb_produtos(nome_pro, marca_pro," +
              " valor_pro, id_tipo)" +
    "values( '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', " + idTipo + ")";
            comandoMysql = new MySqlCommand(sqlInsert, con);
            int linha = comandoMysql.ExecuteNonQuery();
            if (linha > 0)
            {
                MessageBox.Show("Produto cadastrado com sucesso");
            }



                textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "SERVER=localhost; DATABASE=BD_Crud; USER ID=root ; PASSWORD=1819 ;";
            con.Open();
            sqlTipo = "select * from tb_tipo";
            comandoMysql = new MySqlCommand(sqlTipo, con);
            leituraDados = comandoMysql.ExecuteReader();
            while (leituraDados.Read())
            {
                comboBox1.Items.Add(leituraDados["NOME_TIPO"]);
            }
            leituraDados.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipo = comboBox1.SelectedIndex + 1;
        }
    }
}
