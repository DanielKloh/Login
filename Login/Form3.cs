using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form3 : MaterialForm
    {
        //Banco de dados
        MySqlConnection con;
        MySqlCommand comand;

        //pacote de skin
        MaterialSkinManager manager;
        public Form3()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pizzeriadb;Uid=root;Pwd=;SslMode=none");

            //Pacote de Skin
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Pink200, TextShade.WHITE);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        
private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Obtem os valores do campo da tela
            string nome = txtNome.Text;
            string senha  = txtSenha.Text;
            string complemento = txtComplemento.Text;
            string telefone = txtTelefone.Text;
            string cep = txtCEP.Text;
            string ddd = txtddd.Text;
            //string nascimento = txtnascimento.Text;

            DateTime dateTime = dateTimePicker1.Value;
       

            con.Open();
            comand = con.CreateCommand();
            comand.Connection = con;
            comand.CommandText = "INSERT INTO cliente (nome_completo,data_nascimento,ddd,complemento,telefone,senha,CEP) values(@nome_completo,@data_nascimento,@ddd,@complemento,@telefone,@senha,@CEP)";
            comand.Parameters.AddWithValue("@nome_completo", nome);
            comand.Parameters.AddWithValue("@data_nascimento", dateTime);
            comand.Parameters.AddWithValue("@ddd", ddd);
            comand.Parameters.AddWithValue("@complemento", complemento);
            comand.Parameters.AddWithValue("@telefone", telefone);
            comand.Parameters.AddWithValue("@senha", senha);
            comand.Parameters.AddWithValue("@CEP", cep);

            int retornoInsert = comand.ExecuteNonQuery();

            con.Close();


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
