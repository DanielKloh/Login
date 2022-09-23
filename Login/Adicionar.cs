using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Login
{
    public partial class Adicionar : MaterialForm
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        MaterialSkinManager manager;
        class dados
        {
            public int id { get; set; }
            public string nome { get; set; }
            public DateTime data_nascimento { get; set; }
            public string telefone { get; set; }
            public string ddd { get; set; }

            public string complemento { get; set; }
            public string cep { get; set; }
            public string senha { get; set; }

        }
        public Adicionar()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pizzeriadb;User=root;Pwd=;SslMode=none");

            //Pacote de Skin
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500,
                Accent.Pink200, TextShade.WHITE);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<dados> lista = new List<dados>();
            
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select id_cliente,nome_completo,data_nascimento,telefone,ddd,complemento,CEP,senha from cliente";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dados Cliente = new dados();

                Cliente.id = Convert.ToInt32(dr["id_cliente"]);
                Cliente.nome = dr["nome_completo"].ToString();
                Cliente.data_nascimento = Convert.ToDateTime(dr["data_nascimento"].ToString());
                Cliente.telefone = dr["telefone"].ToString();
                Cliente.ddd = dr["ddd"].ToString();
                Cliente.cep = dr["CEP"].ToString();
                Cliente.complemento = dr["complemento"].ToString();
                Cliente.senha = dr["senha"].ToString();

                ListViewItem Lista = new ListViewItem();


                Lista.Text = Cliente.id.ToString();
                Lista.SubItems.Add(Cliente.nome);
                Lista.SubItems.Add(Cliente.data_nascimento.ToString("dd/MM/yyyy"));
                Lista.SubItems.Add(Cliente.telefone);
                Lista.SubItems.Add(Cliente.ddd);
                Lista.SubItems.Add(Cliente.complemento);
                Lista.SubItems.Add(Cliente.cep);
                Lista.SubItems.Add(Cliente.senha);


                listView1.Items.Add(Lista);

            }
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                //MessageBox.Show("select alguma coisa");

                var itemselecionado = listView1.SelectedItems[0];
                int ID = Convert.ToInt32(itemselecionado.Text);

                //Obtem os valores da linha selecionada do listView
                txtNome.Text = itemselecionado.SubItems[1].Text; //Valor da coluna 1
                txtSenha.Text = itemselecionado.SubItems[2].Text;//Valor da coluna 2
                txtComplemento.Text = itemselecionado.SubItems[3].Text;//Valor da coluna 3
                txtTelefone.Text = itemselecionado.SubItems[4].Text;//Valor da coluna 4
                txtCEP.Text = itemselecionado.SubItems[5].Text;//Valor da coluna 5
                txtddd.Text = itemselecionado.SubItems[6].Text;//Valor da coluna 6
            }
            
        }

        private void btnExcuir_Click(object sender, EventArgs e)
        {
            var itemselecionado = listView1.SelectedItems[0];
            int ID = Convert.ToInt32(itemselecionado.Text);

            

            con.Open();
            cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM cliente where id_cliente =@id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", ID);
            

            int retornoDelite = cmd.ExecuteNonQuery();

            con.Close();


            //Executar o evento de click no botão buscar
            materialRaisedButton1_Click(null, new EventArgs());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            var itemselecionado = listView1.SelectedItems[0];
            int ID = Convert.ToInt32(itemselecionado.Text);


            //Obtem os valores do campo da tela
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string complemento = txtComplemento.Text;
            string telefone = txtTelefone.Text;
            string cep = txtCEP.Text;
            string ddd = txtddd.Text;
            //string nascimento = txtnascimento.Text;

            DateTime dateTime = dateTimePicker1.Value;


            con.Open();
            cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "update cliente set nome_completo = @nome_completo,data_nascimento = @data_nascimento,ddd = @ddd,complemento = @complemento,telefone = @telefone,senha = @senha,CEP = @CEP where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@nome_completo", nome);
            cmd.Parameters.AddWithValue("@data_nascimento", dateTime);
            cmd.Parameters.AddWithValue("@ddd", ddd);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@CEP", cep);
            cmd.Parameters.AddWithValue("@id_cliente", ID);

            int retornoInsert = cmd.ExecuteNonQuery();

            con.Close();

            //Executar o evento de click no botão buscar
            materialRaisedButton1_Click(null, new EventArgs());
        }
    }
}
