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
using static MaterialSkin.MaterialSkinManager;

namespace Login
{
    public partial class Form1 : MaterialForm
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        MaterialSkinManager manager;


        public Form1()
        {
            InitializeComponent();

            //Banco de dados
            con = new MySqlConnection("Server=localhost;Database=pizzeriadb;User=root;Pwd=;SslMode=none");

            //Pacote de Skin
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Pink200, TextShade.WHITE);
            manager.Theme = MaterialSkinManager.Themes.DARK;


        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //criando um comando mysql
            cmd = new MySqlCommand();
            //abrindo a conexção com o banco
            con.Open();
            //atribue a conexção do comando
            cmd.Connection = con;
            //determina o SQl do comando
            cmd.CommandText = "SELECT * FROM cliente where nome_completo = '" + txtusuario.Text + "' AND senha = '" + txtSenha.Text + "'";
            //executa o comando e retorna um resultado
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                var Adicionar = new Adicionar();
                Adicionar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            var Form3 = new Form3();
            Form3.ShowDialog();
        }
    }
}
