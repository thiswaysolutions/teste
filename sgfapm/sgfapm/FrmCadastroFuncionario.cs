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
    }
}
