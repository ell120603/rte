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
    public partial class FrmConsultarProdId : Form
    {
        MySqlConnection con = new MySqlConnection();

        MySqlDataReader leitorDados;

        MySqlCommand comandoMysql;


        string sqlTipo;

        int idTipo, nreg;
        public FrmConsultarProdId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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


                comandoMysql = new MySqlCommand(sqlDados, con);

                leitorDados = comandoMysql.ExecuteReader();
                if (leitorDados.HasRows)
                {

                    leitorDados.Read();


                    textBox2.Text = leitorDados["nome_pro"].ToString();
                    textBox3.Text = leitorDados["marca_pro"].ToString();
                    textBox4.Text = leitorDados["valor_pro"].ToString();
                    comboBox1.Text = leitorDados["nome_tipo"].ToString();
                    LabelNome.Visible = false;
                    LabelMarca.Visible = false;
                    LabelTipo.Visible = false;
                    label6.Visible = false;

                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    comboBox1.Visible = true;
                    button2.Visible = true;
                    this.Size = new Size(748, 623);
                    groupBox1.Size = new Size(695, 655);
                    button3.Location = new System.Drawing.Point(572, 519);
                }
                else
                {
                    MessageBox.Show("Não Encontrado");
                    LabelNome.Visible = false;
                    LabelMarca.Visible = false;
                    LabelTipo.Visible = false;
                    label6.Visible = false;


                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
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


        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Dispose();
            frmMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlUpdate = " UPDATE TB_PRODUTOS " +
                               " SET NOME_PRO ='" + textBox2.Text + "'," +
                               " MARCA_PRO =  '" + textBox3.Text + "' , " +
                               " VALOR_PRO = '" + textBox4.Text + "' , " +
                               " ID_TIPO = " + idTipo +
                               " WHERE ID_PRO = " + nreg;

            comandoMysql = new MySqlCommand(sqlUpdate, con);

            int linhas = comandoMysql.ExecuteNonQuery();

            if (linhas == 1)
            {

                MessageBox.Show("Dados Alterados com sucesso");
            }
            else
            {

                MessageBox.Show("Não alterados");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipo = comboBox1.SelectedIndex + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlDel = "delete from tb_produto where id_pro= " + textBox1.Text;

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

        private void FrmConsultarProdId_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "server=localhost; database=BD_Crud; " +
                    "user id=root; password=1819";
                con.Open();
                LabelNome.Visible = false;
                LabelMarca.Visible = false;
                LabelTipo.Visible = false;
                label6.Visible = false;

                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                comboBox1.Visible = false;
                button2.Visible = false;
                this.Size = new Size(748, 200);
                groupBox1.Size = new Size(695, 130);
                button3.Location = new System.Drawing.Point(515, 43);
                MessageBox.Show(con.State.ToString());
                sqlTipo = "SELECT * FROM TB_TIPO";
                comandoMysql = new MySqlCommand(sqlTipo, con);
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
    }
}
