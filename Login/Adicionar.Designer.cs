namespace Login
{
    partial class Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comple = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAtualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcuir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtddd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.data,
            this.Telefone,
            this.ddd,
            this.CEP,
            this.Comple,
            this.Senha});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 272);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.Text = "nome";
            this.nome.Width = 91;
            // 
            // data
            // 
            this.data.Text = "data nascimento";
            this.data.Width = 105;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 70;
            // 
            // ddd
            // 
            this.ddd.Text = "ddd";
            this.ddd.Width = 43;
            // 
            // CEP
            // 
            this.CEP.Text = "CEP";
            this.CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CEP.Width = 64;
            // 
            // Comple
            // 
            this.Comple.Text = "Complemento";
            this.Comple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Comple.Width = 125;
            // 
            // Senha
            // 
            this.Senha.Text = "Senha";
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.Width = 83;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(27, 86);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(194, 58);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Buscar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(494, 101);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(83, 29);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lb
            // 
            this.lb.Depth = 0;
            this.lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb.Location = new System.Drawing.Point(421, 495);
            this.lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(156, 23);
            this.lb.TabIndex = 19;
            this.lb.Text = "Data de nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 534);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(238, 453);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(206, 23);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.Location = new System.Drawing.Point(12, 495);
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(175, 23);
            this.txtTelefone.TabIndex = 14;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtCEP
            // 
            this.txtCEP.Depth = 0;
            this.txtCEP.Hint = "CEP";
            this.txtCEP.Location = new System.Drawing.Point(213, 495);
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(127, 23);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.UseSystemPasswordChar = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Hint = "Complemento";
            this.txtComplemento.Location = new System.Drawing.Point(12, 534);
            this.txtComplemento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.Size = new System.Drawing.Size(273, 23);
            this.txtComplemento.TabIndex = 12;
            this.txtComplemento.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome Completo";
            this.txtNome.Location = new System.Drawing.Point(15, 453);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(206, 23);
            this.txtNome.TabIndex = 11;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 26;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Location = new System.Drawing.Point(257, 101);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = true;
            this.btnAtualizar.Size = new System.Drawing.Size(83, 29);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcuir
            // 
            this.btnExcuir.Depth = 0;
            this.btnExcuir.Location = new System.Drawing.Point(364, 101);
            this.btnExcuir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcuir.Name = "btnExcuir";
            this.btnExcuir.Primary = true;
            this.btnExcuir.Size = new System.Drawing.Size(83, 29);
            this.btnExcuir.TabIndex = 21;
            this.btnExcuir.Text = "excluir";
            this.btnExcuir.UseVisualStyleBackColor = true;
            this.btnExcuir.Click += new System.EventHandler(this.btnExcuir_Click);
            // 
            // txtddd
            // 
            this.txtddd.Depth = 0;
            this.txtddd.Hint = "DDD";
            this.txtddd.Location = new System.Drawing.Point(475, 453);
            this.txtddd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtddd.Name = "txtddd";
            this.txtddd.PasswordChar = '\0';
            this.txtddd.SelectedText = "";
            this.txtddd.SelectionLength = 0;
            this.txtddd.SelectionStart = 0;
            this.txtddd.Size = new System.Drawing.Size(83, 23);
            this.txtddd.TabIndex = 22;
            this.txtddd.UseSystemPasswordChar = false;
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 577);
            this.Controls.Add(this.txtddd);
            this.Controls.Add(this.btnExcuir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listView1);
            this.Name = "Adicionar";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader ddd;
        private System.Windows.Forms.ColumnHeader Comple;
        private System.Windows.Forms.ColumnHeader Senha;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public System.Windows.Forms.ColumnHeader CEP;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private MaterialSkin.Controls.MaterialLabel lb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private System.Windows.Forms.ColumnHeader id;
        private MaterialSkin.Controls.MaterialRaisedButton btnAtualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcuir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtddd;
    }
}