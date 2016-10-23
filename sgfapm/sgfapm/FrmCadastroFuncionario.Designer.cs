namespace sgfapm
{
    partial class FrmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblArmario = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::sgfapm.Properties.Resources.save;
            this.btnCadastrar.Location = new System.Drawing.Point(771, 575);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 49);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblArmario
            // 
            this.lblArmario.AutoSize = true;
            this.lblArmario.Location = new System.Drawing.Point(495, 463);
            this.lblArmario.Name = "lblArmario";
            this.lblArmario.Size = new System.Drawing.Size(40, 17);
            this.lblArmario.TabIndex = 60;
            this.lblArmario.Text = "Perfil";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(39, 300);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(87, 22);
            this.mskCEP.TabIndex = 9;
            this.mskCEP.Text = "12345678";
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCEP.Click += new System.EventHandler(this.mskCEP_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(35, 279);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(35, 17);
            this.lblCelular.TabIndex = 58;
            this.lblCelular.Text = "CEP";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(524, 385);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTelefone.Mask = "(99) 9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(111, 22);
            this.mskTelefone.TabIndex = 15;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.Click += new System.EventHandler(this.mskTelefone_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(521, 366);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 56;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(640, 213);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(321, 22);
            this.txtComplemento.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(492, 213);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 22);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.Text = "1";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(39, 213);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(380, 22);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.Text = "Rua";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(637, 193);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(94, 17);
            this.lblComplemento.TabIndex = 48;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(495, 192);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 46;
            this.lblNumero.Text = "Número";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(36, 192);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(69, 17);
            this.lblEndereco.TabIndex = 44;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(392, 124);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(243, 22);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.Text = "Cargo";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(389, 103);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(46, 17);
            this.lblIdade.TabIndex = 36;
            this.lblIdade.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 124);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(35, 26);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(52, 17);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(39, 47);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(89, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Salário";
            // 
            // mskSalario
            // 
            this.mskSalario.Location = new System.Drawing.Point(697, 124);
            this.mskSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskSalario.Mask = "$ 99999,99";
            this.mskSalario.Name = "mskSalario";
            this.mskSalario.Size = new System.Drawing.Size(104, 22);
            this.mskSalario.TabIndex = 4;
            this.mskSalario.Text = "9999999";
            this.mskSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskSalario.Click += new System.EventHandler(this.mskSalario_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(583, 299);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(187, 22);
            this.txtCidade.TabIndex = 11;
            this.txtCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(237, 300);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(244, 22);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(864, 299);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(97, 24);
            this.cboEstado.TabIndex = 12;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(769, 385);
            this.mskCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCelular.Mask = "(99) 99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(128, 22);
            this.mskCelular.TabIndex = 16;
            this.mskCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCelular.Click += new System.EventHandler(this.mskCelular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Celular";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(284, 385);
            this.mskRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskRG.Mask = "99.999.999-a";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(104, 22);
            this.mskRG.TabIndex = 14;
            this.mskRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskRG.Click += new System.EventHandler(this.mskRG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "RG";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(39, 385);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(121, 22);
            this.mskCPF.TabIndex = 13;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCPF.Click += new System.EventHandler(this.mskCPF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "CPF";
            // 
            // mskDataAdmissao
            // 
            this.mskDataAdmissao.Location = new System.Drawing.Point(864, 124);
            this.mskDataAdmissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskDataAdmissao.Mask = "00/00/0000";
            this.mskDataAdmissao.Name = "mskDataAdmissao";
            this.mskDataAdmissao.Size = new System.Drawing.Size(97, 22);
            this.mskDataAdmissao.TabIndex = 5;
            this.mskDataAdmissao.Text = "23102016";
            this.mskDataAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDataAdmissao.ValidatingType = typeof(System.DateTime);
            this.mskDataAdmissao.Click += new System.EventHandler(this.mskDataAdmissao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(860, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Data admissão";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(40, 486);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 22);
            this.txtUsuario.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(269, 485);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(179, 22);
            this.txtSenha.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Senha";
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cboPerfil.Location = new System.Drawing.Point(499, 484);
            this.cboPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(179, 24);
            this.cboPerfil.TabIndex = 19;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(725, 484);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(236, 22);
            this.txtEMail.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(723, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 86;
            this.label11.Text = "E-mail";
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 663);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskDataAdmissao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskRG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblArmario);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblArmario;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSalario;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDataAdmissao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label11;
    }
}