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
    public partial class FrmInicial : Form
    {
        private FrmCadastroAluno frmCadastraAluno;
        private FrmCadastroFuncionario frmCadastraFuncionario;

        public FrmInicial()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraAluno = new FrmCadastroAluno();
            frmCadastraAluno.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCadastraAluno = new FrmCadastroAluno();
            frmCadastraAluno.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraFuncionario = new FrmCadastroFuncionario();
            frmCadastraFuncionario.Show();
        }
    }
}
