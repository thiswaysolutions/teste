using sgfapm.dominio;
using sgfapm.utilitario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgfapm.repositorio
{
    class RepositorioAluno
    {
        // Constantes com os comandos Sql
        public const String TABELA_ALUNOS = "TB_ALUNOS";
        public const String TABELA_DETALHE_ALUNO = "TB_DETALHES_ALUNO";
        public const String TABELA_ENDERECO_ALUNO = "TB_ENDERECO_ALUNO";
        public const String TABELA_ALUNO_CONTRIBUINTE = "TB_ALUNO_CONTRIBUINTE";
        private const String COMANDO_INSERT = "INSERT INTO ";
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_ID = "RA";
        private const String COLUNA_ID_FK = "RA_ALUNO";

        // Instancia de conexao com o Banco de Dados
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        // Metodo de salvamento do contato no Banco de Dados
        public bool salvar(Aluno aluno)
        {
            try
            {
                salvarTB_Alunos(aluno);
                salvarTB_DetalhesAluno(aluno);
                salvarTB_EnderecoAluno(aluno);
                salvarTB_AlunoContribuinte(aluno);
                
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao salvar aluno no banco de dados. \n Detalhes do Erro: " + e);
            }
            return false;
        }

        private void salvarTB_AlunoContribuinte(Aluno aluno)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_ALUNO_CONTRIBUINTE +
                " VALUES (" + aluno._ra + ", '" +
                aluno._curso + "', '" +
                aluno._periodo + "', '" +
                aluno._modulo + "', " +
                aluno._armario +
                ");";

            executar(comando);
        }

        private void salvarTB_EnderecoAluno(Aluno aluno)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_ENDERECO_ALUNO +
                " VALUES (" + aluno._ra + ", '" +
                aluno._rua + "', '" +
                aluno._numero+ "', '" +
                aluno._complemento+ "', '" +
                aluno._cep + "', '" +
                aluno._bairro + "', '" +
                aluno._cidade + "', '" +
                aluno._estado +
                "');";

            executar(comando);
        }

        private void salvarTB_DetalhesAluno(Aluno aluno)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_DETALHE_ALUNO +
                " VALUES (" + aluno._ra + ", " +
                aluno._idade + ", '" +
                aluno._telefone + "', '" +
                aluno._celular + "', '" +
                aluno._eMail +
                "');";

            executar(comando);
        }

        private void salvarTB_Alunos(Aluno aluno)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_ALUNOS +
                " VALUES (" + aluno._ra + ", '" +
                aluno._nome + "', " +
                aluno._contribuinte + ");";

            executar(comando);
        }

        private void executar(SqlCommand comando)
        {
            // Desconectar do Banco para garantir e conectar novamente
            comando.Connection = conexao.desconectarBD();
            comando.Connection = conexao.conectarBD();

            // Tenta executar o comando, se der erro mostra mensagem e no fim desconecta
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                //MessageBox.Show("Falha ao salvar no banco de dados. \n Detalhes do Erro: " + e);
            }
            finally
            {
                conexao.desconectarBD();
            }
        }
    }
}