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
    public partial class FrmCadastroAluno : Form
    {
        // Declara e instancia os objetos globais
        Conexao conexao = new Conexao();
        Aluno aluno;
        RepositorioAluno repositorioAluno = new RepositorioAluno();

       public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Cria um objeto do tipo Aluno e preenche seus atributos com as informações da tela
            aluno = new Aluno();
            setAluno();

            // O metodo retorna true ou false, de acordo com o valor mostra uma mensagem
            if (repositorioAluno.salvar(aluno))
            {
                MessageBox.Show("Aluno cadastrado!");
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!");
            }
        }

        private void setAluno()
        {
            aluno._ra = Convert.ToInt32(txtRA.Text);
            aluno._nome = txtNome.Text;
            aluno._contribuinte = converter(Convert.ToBoolean(ckbContribuinte.Checked));
            aluno._idade = Convert.ToInt16(txtIdade.Text);
            aluno._telefone = mskTelefone.Text;
            aluno._celular = mskCelular.Text;
            aluno._eMail = txtEMail.Text;
            aluno._rua = txtEndereco.Text;
            aluno._numero = txtNumero.Text;
            aluno._complemento = txtComplemento.Text;
            aluno._cep = mskCEP.Text;
            aluno._bairro = txtBairro.Text;
            aluno._cidade = txtCidade.Text;
            aluno._estado = cboEstado.SelectedItem.ToString();
            aluno._curso = cboCurso.SelectedItem.ToString();
            aluno._periodo = cboPeriodo.SelectedItem.ToString();
            aluno._modulo = cboModulo.SelectedItem.ToString();
            aluno._armario = Convert.ToInt32(txtArmario.Text);
        }

        // Converter boolean para o tipo BIT
        private int converter(bool valor)
        {
            if (valor)
            {
                return 1;
            }
            return 0;
        }

        private void mskRA_Click(object sender, EventArgs e)
        {
            posicionarCursor(sender, 0);
        }

        private void mskCEP_Click(object sender, EventArgs e)
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

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            conexao.conectarBD();
            conexao.checarConexao();
            conexao.desconectarBD();
        }

        private void txtRA_Leave(object sender, EventArgs e)
        {
            // Lógica para testar se o valor do RA é inteiro
            bool ok = false;
            try
            {
               //Variável que terá o valor, caso seja inteiro
                int inteiro;

                //Validando se é inteiro utilizando o recurso TryParse
                //No método passamos primeiro uma string, e depois a saída "out"
                bool isInteiro = int.TryParse(txtRA.Text, out inteiro);

                //Verificando se é um número
                if (isInteiro)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            catch(Exception ex)
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("RA inválido!");
                txtRA.Focus();
            }
        }
    }
}
