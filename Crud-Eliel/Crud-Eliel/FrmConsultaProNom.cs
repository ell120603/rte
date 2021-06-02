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
    public partial class FrmConsultaProNom : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comandoMysql;
        private MySqlDataAdapter AdaptarDados = new MySqlDataAdapter();
        public FrmConsultaProNom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_pro = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           FrmAltDelPro frmCons = new FrmAltDelPro(id_pro);
            this.Dispose();
            frmCons.ShowDialog();
        }

        private void FrmConsultaProNom_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con.ConnectionString = "server=localhost; database= BD_CRUD;" +
               " user id=root; Password=1819";
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Dispose();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlLike = "SELECT * FROM bd_crud.tb_produtos where " +
                        " nome_pro like '%" + textBox1.Text + "%' ";

            AdaptarDados = new MySqlDataAdapter(sqlLike, con);
            DataSet conjuntoDados = new DataSet();
            AdaptarDados.Fill(conjuntoDados);
            dataGridView1.DataSource = conjuntoDados.Tables[0];
        }
    }
}
