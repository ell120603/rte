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
    public partial class FrmCadastroCliente : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comandoMysql;
        MySqlDataReader leituraDados;
        string sqlestado;
        int idEstado;
       

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

            con.ConnectionString= "SERVER=localhost; DATABASE=BD_Crud; USER ID=root ; PASSWORD=1819 ;";
            con.Open();
            sqlestado = " select * from TB_ESTADO";
            comandoMysql = new MySqlCommand(sqlestado, con);
            leituraDados = comandoMysql.ExecuteReader();
            while (leituraDados.Read())
            {
                comboestado.Items.Add(leituraDados["NOME_EST"]);
            }
            leituraDados.Close();
            label7.Visible = false;
            label9.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;


        }

        private void comboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEstado = comboestado.SelectedIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlInsert = "insert into tb_clientes(nome_cli, end_cli," +
                " n_cli, bairro_cli, cidade_cli, id_est)" +
      "values( '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "'," + idEstado + ")";
            comandoMysql = new MySqlCommand(sqlInsert, con);

            int linha = comandoMysql.ExecuteNonQuery();
            if (linha > 0){
               // MessageBox.Show(comandoMysql.LastInsertedId.ToString());
               int id_cliente = int.Parse(comandoMysql.LastInsertedId.ToString());
                if (checkBox1.Checked)
                {
                    string sqlLogin = "insert into tb_login(login_log, senha_log, id_cli)" +
                    "values('" + textBox6.Text + "', '" + textBox7.Text + "'," + id_cliente + ")";
                    comandoMysql = new MySqlCommand(sqlLogin, con);
                    comandoMysql.ExecuteNonQuery();
                }
                MessageBox.Show("usuario cadastrado com sucesso");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label7.Visible = true;
                label9.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;

            }
            else
            {
                label7.Visible = false;
                label9.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox6.Clear();
                textBox7.Clear();
            }
        }
    }
}
