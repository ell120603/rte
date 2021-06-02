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
    public partial class FrmAltDelPro : Form
    {
        string sqlDados = " select tb_produtos.id_pro, " +
                              " tb_produtos.nome_pro, " +
                              " tb_produtos.marca_pro, " +
                              " tb_produtos.valor_pro, " +
                              " tb_tipo.nome_tipo, " +
                              " tb_tipo.id_tipo " +
                              " from tb_produtos inner join tb_tipo " +
                              " on tb_produtos.id_tipo = tb_tipo.id_tipo " +
                              " where tb_produtos.id_pro = " ;
        MySqlConnection con = new MySqlConnection();
        MySqlDataReader leitorDados;
        MySqlCommand comandoMysql;
        string sqlTipo;
        int indiceTipo, nreg;

        public FrmAltDelPro()
        {
            InitializeComponent();
        }
        public FrmAltDelPro(string value)
        {
            InitializeComponent();

            sqlDados += value;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAltDelPro_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost; database=BD_CRUD; " +
            "user id = root; password=1819";

            con.Open();
            sqlTipo = "SELECT * FROM TB_TIPO";
            comandoMysql = new MySqlCommand(sqlTipo, con);
            leitorDados = comandoMysql.ExecuteReader();

            while (leitorDados.Read())
            {

                comboBox1.Items.Add(leitorDados[1]);
            }
            leitorDados.Close();



            comandoMysql = new MySqlCommand(sqlDados, con);
            leitorDados = comandoMysql.ExecuteReader();
            leitorDados.Read();
            textBox1.Text = leitorDados["id_pro"].ToString();
            textBox2.Text = leitorDados["nome_pro"].ToString();
            textBox3.Text = leitorDados["marca_pro"].ToString();
            textBox4.Text = leitorDados["valor_pro"].ToString();
            comboBox1.SelectedIndex = int.Parse(leitorDados["id_tipo"].ToString()) - 1;



            leitorDados.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTipo = comboBox1.SelectedIndex;
            MessageBox.Show(indiceTipo.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Dispose();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indiceTipo = indiceTipo + 1;
            string sqlupdate = " update tb_produtos " +
                              " set nome_pro = '" + textBox2.Text + "'  , " +
                              "     marca_pro = '" + textBox3.Text + "' ," +
                              "     valor_pro = '" + textBox4.Text + "' , " +
                              "     id_tipo     = " + indiceTipo +
                              "    where id_pro =" + textBox1.Text;
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
            string sqlDel = "delete from tb_produtos where id_pro= " + textBox1.Text;

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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlDados = " select tb_produtos.id_pro, " +
                            " tb_produtos.nome_pro, " +
                            " tb_produtos.marca_pro, " +
                            " tb_produtos.valor_pro, " +
                            " tb_tipo.nome_tipo, " +
                            " tb_tipo.id_tipo " +
                            " from tb_produtos inner join tb_tipo " +
                            " on tb_produtos.id_tipo = tb_tipo.id_tipo " +
                            " where tb_produtos.id_pro = " + textBox1.Text;
            nreg = Convert.ToInt32(textBox1.Text);

            nreg = Convert.ToInt32(textBox1.Text);


            comandoMysql = new MySqlCommand(sqlDados, con);

            leitorDados = comandoMysql.ExecuteReader();

            if (leitorDados.HasRows)
            {

                leitorDados.Read();


                textBox2.Text = leitorDados["nome_pro"].ToString();
                textBox3.Text = leitorDados["marca_pro"].ToString();
                textBox4.Text = leitorDados["valor_pro"].ToString();
                comboBox1.Text = leitorDados["nome_tipo"].ToString();
                leitorDados.Close();
            }
            leitorDados.Close();
        }
    }
    }
