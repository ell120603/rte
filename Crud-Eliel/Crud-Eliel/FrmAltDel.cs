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
    public partial class FrmAltDel : Form
    {
        string sqlDados = "select  tb_clientes.id_cli, " +
                                     " tb_clientes.nome_cli, " +
                                     " tb_clientes.end_cli, " +
                                     " tb_clientes.n_cli, " +
                                     " tb_clientes.bairro_cli," +
                                     " tb_clientes.cidade_cli, " +
                                     " tb_estado.nome_est, " +
                                     " tb_estado.id_est, " +
                                     " tb_login.login_log, " +
                                     " tb_login.senha_log " +
                                     " from tb_clientes inner join tb_estado " +
                                     " on tb_clientes.id_est = tb_estado.id_est " +
                                     " left join tb_login " +
                                     " on tb_login.id_cli = tb_clientes.id_cli " +
                                     " where tb_clientes.id_cli = ";
        MySqlConnection con = new MySqlConnection();
        MySqlDataReader leitorDados;
        MySqlCommand comandoMysql;
        string sqlEstado;
        int indiceEstado, nreg;
        public FrmAltDel()
        {
            InitializeComponent();
        }
        public FrmAltDel(string value)
        {
            InitializeComponent();

            sqlDados += value;
        }

        private void FrmAltDel_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost; database=BD_CRUD; " +
                   "user id = root; password=1819";

            con.Open();
            sqlEstado = "SELECT * FROM TB_ESTADO";
            comandoMysql = new MySqlCommand(sqlEstado, con);
            leitorDados = comandoMysql.ExecuteReader();

            while (leitorDados.Read())
            {

                comboBox1.Items.Add(leitorDados[1]);
            }
            leitorDados.Close();
            comandoMysql = new MySqlCommand(sqlDados, con);
            leitorDados = comandoMysql.ExecuteReader();
            leitorDados.Read();
            textBox1.Text = leitorDados["id_cli"].ToString();
            textBox2.Text = leitorDados["nome_cli"].ToString();
            textBox3.Text = leitorDados["end_cli"].ToString();
            textBox4.Text = leitorDados["n_cli"].ToString();
            textBox5.Text = leitorDados["cidade_cli"].ToString();
            textBox6.Text = leitorDados["bairro_cli"].ToString();
            comboBox1.SelectedIndex = int.Parse(leitorDados["id_est"].ToString()) - 1;

            if (leitorDados["login_log"].ToString() != String.Empty)
            {
                textBox7.Text = leitorDados["login_log"].ToString();
                textBox8.Text = leitorDados["senha_log"].ToString();
            }


            leitorDados.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceEstado = comboBox1.SelectedIndex;
            MessageBox.Show(indiceEstado.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Dispose();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indiceEstado = indiceEstado + 1;
            string sqlupdate = " update tb_clientes " +
                              " set nome_cli = '" + textBox2.Text + "'  , " +
                              "     end_cli = '" + textBox3.Text + "' ," +
                              "     n_cli = '" + textBox4.Text + "' , " +
                              "     cidade_cli ='" + textBox5.Text + "' , " +
                              "     bairro_cli = '" + textBox6.Text + "' , " +
                              "     id_est     = " + indiceEstado +
                              "    where id_cli =" + textBox1.Text;
            string sqlLogin = " update tb_login " +
                              " set LOGIN_LOG = '" + textBox7.Text + "', " +
                              "     SENHA_LOG = '" + textBox8.Text + "' " +
                              " WHERE ID_CLI = " + textBox1.Text;
            comandoMysql = new MySqlCommand(sqlupdate, con);

            int linha = comandoMysql.ExecuteNonQuery();
            if (linha > 0)
            {
                if (linha > 0)
                {


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlDelfk = "delete from tb_login where id_cli=" + textBox1.Text;
            comandoMysql = new MySqlCommand(sqlDelfk, con);
            comandoMysql.ExecuteNonQuery();
            string sqlDel = "delete from tb_clientes where id_cli= " + textBox1.Text;

            comandoMysql = new MySqlCommand(sqlDel, con);
            int linha = comandoMysql.ExecuteNonQuery();
            if (linha == 1)
            {
                MessageBox.Show("deletado com sucesso");
            }
            else
            {
                MessageBox.Show("falha ao deletar");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlDados = "select  tb_clientes.id_cli, " +
                                  " tb_clientes.nome_cli, " +
                                  " tb_clientes.end_cli, " +
                                  " tb_clientes.n_cli, " +
                                  " tb_clientes.bairro_cli," +
                                  " tb_clientes.cidade_cli, " +
                                  " tb_estado.nome_est, " +
                                  " tb_estado.id_est, " +
                                  " tb_login.login_log, " +
                                  " tb_login.senha_log " +
                                  " from tb_clientes inner join tb_estado " +
                                  " on tb_clientes.id_est = tb_estado.id_est " +
                                  " left join tb_login " +
                                  " on tb_login.id_cli = tb_clientes.id_cli " +
                                  " where tb_clienteS.id_cli = " + textBox1.Text;

            nreg = Convert.ToInt32(textBox1.Text);


            comandoMysql = new MySqlCommand(sqlDados, con);

            leitorDados = comandoMysql.ExecuteReader();

            if (leitorDados.HasRows)
            {

                leitorDados.Read();


                textBox2.Text = leitorDados["nome_cli"].ToString();
                textBox3.Text = leitorDados["end_cli"].ToString();
                textBox4.Text = leitorDados["n_cli"].ToString();
                textBox5.Text = leitorDados["cidade_cli"].ToString();
                textBox6.Text = leitorDados["bairro_cli"].ToString();

                comboBox1.Text = leitorDados["nome_est"].ToString();
                leitorDados.Close();
            }
            leitorDados.Close();

        }
        }
}
