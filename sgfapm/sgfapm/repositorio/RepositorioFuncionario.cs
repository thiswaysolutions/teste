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
    class RepositorioFuncionario
    {
        // Constantes com os comandos Sql
        public const String TABELA_FUNCIONARIO = " TB_FUNCIONARIOS ";
        public const String TABELA_DETALHE_FUNCIONARIO = " TB_DETALHES_FUNCIONARIO ";
        public const String TABELA_ENDERECO_FUNCIONARIO = " TB_ENDERECO_FUNCIONARIO ";
        public const String TABELA_USUARIOS = " TB_USUARIOS ";
        private const String COMANDO_INSERT = "INSERT INTO ";
        private const String CONDICIONAL_WHERE = " WHERE ";
        private const String COLUNA_ID = " CODIGO ";
        private const String COLUNA_ID_FK = " COD_FUNCIONARIO ";
        private const String COMANDO_SELECT = " SELECT USUARIO, SENHA FROM ";

        // Instancia de conexao com o Banco de Dados
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        public bool salvar(Funcionario funcionario)
        {
            try
            {
                salvarTB_Funcionarios(funcionario);
                salvarTB_DetalhesFuncionario(funcionario);
                salvarTB_EnderecoFuncionario(funcionario);
                salvarTB_Usuarios(funcionario);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao salvar funcionario no banco de dados. \n Detalhes do Erro: " + e);
            }
            return false;
        }

        private void salvarTB_Usuarios(Funcionario funcionario)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_USUARIOS + " VALUES (" +
                funcionario._codigo + ", '" +
                funcionario._usuario + "', '" +
                funcionario._senha + "', '" +
                funcionario._perfil + "');";

            executar(comando);
        }

        private void salvarTB_EnderecoFuncionario(Funcionario funcionario)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_ENDERECO_FUNCIONARIO + " VALUES (" +
                funcionario._codigo + ", '" +
                funcionario._rua + "', '" +
                funcionario._numero + "', '" +
                funcionario._complemento + "', '" +
                funcionario._cep + "', '" +
                funcionario._bairro + "', '" +
                funcionario._cidade + "', '" +
                funcionario._estado + "');";

            executar(comando);
        }

        private void salvarTB_DetalhesFuncionario(Funcionario funcionario)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_DETALHE_FUNCIONARIO + " VALUES (" +
                funcionario._codigo + ", '" +
                funcionario._cargo + "', " +
                funcionario._salario + ", '" +
                funcionario._dataAdmissao + "', '" +
                funcionario._cpf + "', '" +
                funcionario._rg + "', '" +
                funcionario._telefone + "', '" +
                funcionario._celular + "', '" +
                funcionario._eMail + "');";

            executar(comando);
        }

        private void salvarTB_Funcionarios(Funcionario funcionario)
        {
            comando.CommandText = COMANDO_INSERT + TABELA_FUNCIONARIO +
                " VALUES ('" + funcionario._nome + "');";

            executar(comando);
        }

        // Isolado em um método a execução do comando
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

        // nao esta funcionando
        public bool autentica(iUsuario func)
        {
            comando.CommandText = COMANDO_SELECT + TABELA_USUARIOS +
                CONDICIONAL_WHERE + " USUARIO = '" + func._usuario + "'";
            try
            {
                
                comando.Connection = conexao.desconectarBD();
                comando.Connection = conexao.conectarBD();

                SqlDataReader dr = comando.ExecuteReader();
                MessageBox.Show(dr["USUARIO"].ToString() + " " + dr["SENHA"].ToString());
                if ((dr["USUARIO"].ToString().Equals(func._usuario) && (dr["SENHA"].ToString().Equals(func._senha))))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nao deu \nErro: " + e);
            }
            finally
            {
                conexao.desconectarBD();
            }
            
            return false;
        }
    }
}
