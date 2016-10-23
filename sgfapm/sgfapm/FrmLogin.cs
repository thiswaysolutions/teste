using sgfapm.dominio;
using sgfapm.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgfapm
{
    public partial class FrmLogin : Form
    {
        iUsuario usuario;
        RepositorioFuncionario rf =
            new RepositorioFuncionario();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
            else
            {
                // Cria um funcionario do tipo Usuario para autenticar
                usuario = new Funcionario();
                usuario._usuario = txtUsuario.Text;
                usuario._senha = txtSenha.Text;

                if (rf.autentica(usuario))
                {
                    FrmInicial inicio = new FrmInicial();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos!");
                }
            }
            */
            
            
            FrmInicial inicio = new FrmInicial();
            inicio.Show();
            
        }
    }
}
