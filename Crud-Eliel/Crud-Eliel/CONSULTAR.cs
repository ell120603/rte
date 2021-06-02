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
    public partial class CONSULTAR : Form
    {

        MySqlConnection con = new MySqlConnection();

        MySqlDataReader leitorDados;

        MySqlCommand comandoMysql;

  
        string sqlEstado;

        int idEst, nreg;

        public CONSULTAR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           FrmMenu frmMenu = new FrmMenu();
            this.Dispose();
            frmMenu.ShowDialog();
        }

        private void CONSULTAR_Load(object sender, EventArgs e)
        {
            try
            {
                
                con.ConnectionString = "server=localhost; database=BD_Crud; " +
                    "user id = root; password=1819";

                con.Open();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;


                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                comboBox1.Visible = false;
                button2.Visible = false;

                this.Size = new Size(748, 200);
                groupBox1.Size = new Size(695, 130);
                button3.Location = new System.Drawing.Point(515, 43);


                MessageBox.Show(con.State.ToString());
                sqlEstado = "SELECT * FROM TB_ESTADO";
          
                comandoMysql = new MySqlCommand(sqlEstado, con);

                leitorDados = comandoMysql.ExecuteReader();

                while (leitorDados.Read())
                {

                    comboBox1.Items.Add(leitorDados[1]);
                }
                leitorDados.Close();
            }
            catch (MySqlException erro)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                    

                    if (leitorDados["login_log"].ToString() != String.Empty)
                    {


                        textBox8.Visible = true;
                        textBox7.Visible = true;

                        label8.Visible = true;
                        label9.Visible = true;

                        textBox7.Text = leitorDados["login_log"].ToString();
                        textBox8.Text = leitorDados["senha_log"].ToString();
                    }
                    else
                    {

                        textBox8.Visible = false;
                        textBox7.Visible = false;

                        label8.Visible = false;
                        label9.Visible = false;

                        textBox7.Clear(); textBox8.Clear();
                    }

                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                   label8.Visible = true;

                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    comboBox1.Visible = true;
                    button2.Visible = true;
                    this.Size = new Size(748, 623);
                    groupBox1.Size = new Size(695, 655);
                    button3.Location = new System.Drawing.Point(572, 519);
                }
                else
                {
                    MessageBox.Show("Não Encontrado");
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;


                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    comboBox1.Visible = false;

                    button2.Visible = false;
               this.Size = new Size(748, 200);
                    groupBox1.Size = new Size(695, 130);
                    button3.Location = new System.Drawing.Point(515, 43);


                }

                leitorDados.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Dados errado");
            }


        

    }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlUpdate = " UPDATE TB_CLIENTES " +
                               " SET NOME_CLI ='" + textBox2.Text + "'," +
                               " N_CLI =  '" + textBox4.Text + "' , " +
                               " END_CLI = '" + textBox3.Text + "' , " +
                               " BAIRRO_CLI = '" + textBox5.Text + "', " +
                               " CIDADE_CLI = '" + textBox6.Text + "', " +
                               " ID_EST = "+ idEst +
                               " WHERE ID_CLI = " + nreg;
            comandoMysql = new MySqlCommand(sqlUpdate, con);

            int linhas =   comandoMysql.ExecuteNonQuery();

            if (linhas == 1)
            {
                if (textBox7.Text != String.Empty)
                {
                    string sqlLogin = " Update tb_login " +
                                     " set login_log = '" + textBox7.Text + "' ," +
                                     "     senha_log = '" + textBox8.Text + "' " +
                                     " where id_cli = " + nreg;
                    // 
                    comandoMysql = new MySqlCommand(sqlLogin, con);
                    comandoMysql.ExecuteNonQuery();
                }

                MessageBox.Show("Dados Alterados com sucesso");
            }
            else {

                MessageBox.Show("Não alterados");
            }

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlDelfk = "delete from tb_login where id_cli=" + textBox1.Text;
            comandoMysql = new MySqlCommand(sqlDelfk, con);
            comandoMysql.ExecuteNonQuery();
            string sqlDel = "delete from tb_clientes where id_cli= " + textBox1.Text;

            comandoMysql = new MySqlCommand(sqlDel, con);
            int linha = comandoMysql.ExecuteNonQuery();
            if(linha == 1)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEst = comboBox1.SelectedIndex + 1;
            
        }
    }
}
