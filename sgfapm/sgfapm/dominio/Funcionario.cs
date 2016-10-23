using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgfapm.dominio
{
    // Funcionario implementa a interface de Usuario e pode ser autenticado
    class Funcionario : iUsuario
    {
        // Propriedades
        private int codigo;
        private String nome;
        private String cargo;
        private double salario;
        private String dataAdmissao;
        private String cpf;
        private String rg;
        private String telefone;
        private String celular;
        private String eMail;
        private String rua;
        private String numero;
        private String complemento;
        private String cep;
        private String bairro;
        private String cidade;
        private String estado;
        private String usuario;
        private String senha;
        private String perfil;

        // Getters e Setters
        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String _nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String _cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double _salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public String _dataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        public String _cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String _rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public String _telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String _celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String _eMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public String _rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public String _numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String _complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public String _cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String _bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String _cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String _estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // @Override
        public String _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        // @Override
        public String _senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String _perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}
