using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgfapm.utilitario
{
    class Conexao
    {
        //String de conexão
        SqlConnection conexao =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_SGFAPM.mdf;Integrated Security=True");

        // Método de conexão do banco de dados
        public SqlConnection conectarBD()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar. \nDetalhes do erro: " + e);
            }
            return conexao;
        }

        //Método de desconexão com banco de dados
        public SqlConnection desconectarBD()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao desconectar. \nDetalhes do erro: " + e);
            }
            return conexao;
        }

        //Método de teste de conexão com banco de dados
        public void checarConexao()
        {
            if ((conexao != null) && (conexao.State != ConnectionState.Closed))
            {
                MessageBox.Show("Conectado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao conectar Banco de dados!");
            }
        }
    }
}
