using sgfapm.dominio;
using sgfapm.repositorio;
using sgfapm.utilitario;
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
    public partial class FrmCadastroFuncionario : Form
    {
        // Declara e instancia os objetos globais
        Conexao conexao = new Conexao();
        Funcionario funcionario;
        RepositorioFuncionario rf = new RepositorioFuncionario();

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void mskSalario_Click(object sender, EventArgs e)
        {
            // Quando clicar no mskSalario o cursor se posiciona no inicio
            posicionarCursor(sender, 3);
        }

        private void mskDataAdmissao_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskCEP_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskCPF_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskRG_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void posicionarCursor(object componente, int posicao)
        {
            // Converte o object para MaskedTextBox e chama o metodo para posicionar
            posicionarCursor((MaskedTextBox)componente, posicao);
        }

        private void posicionarCursor(MaskedTextBox componente, int posicao)
        {
            // Posiciona o cursor no inicio do componente
            componente.SelectionStart = posicao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Cria um objeto do tipo Aluno e preenche seus atributos com as informações da tela
            funcionario = new Funcionario();
            setFuncionario();

            // O metodo retorna true ou false, de acordo com o valor mostra uma mensagem
            if (rf.salvar(funcionario))
            {
                MessageBox.Show("Funcionário cadastrado!");
            }
            else
            {
                MessageBox.Show("Funcionário não cadastrado!");
            }
        }

        private void setFuncionario()
        {
            funcionario._codigo = Convert.ToInt32(txtCodigo.Text);
            funcionario._nome = txtNome.Text;
            funcionario._cargo = txtCargo.Text;
            funcionario._salario = Convert.ToDouble(mskSalario.Text.Trim('R', '$', ' '));
            funcionario._dataAdmissao = mskDataAdmissao.Text;
            funcionario._cpf = mskCPF.Text;
            funcionario._rg = mskRG.Text;
            funcionario._telefone = mskTelefone.Text;
            funcionario._celular = mskCelular.Text;
            funcionario._eMail = txtEMail.Text;
            funcionario._rua = txtEndereco.Text;
            funcionario._numero = txtNumero.Text;
            funcionario._complemento = txtComplemento.Text;
            funcionario._cep = mskCEP.Text;
            funcionario._bairro = txtBairro.Text;
            funcionario._cidade = txtCidade.Text;
            funcionario._estado = cboEstado.SelectedItem.ToString();
            funcionario._usuario = txtUsuario.Text;
            funcionario._senha = txtSenha.Text;
            funcionario._perfil = cboPerfil.SelectedItem.ToString();
        }
    }
}
