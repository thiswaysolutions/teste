CREATE DATABASE DB_SGFAPM;
GO
USE DB_SGFAPM;
GO
CREATE TABLE TB_ALUNOS(
RA INT  NOT NULL PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
CONTRIBUINTE BIT
);
GO
CREATE TABLE TB_DETALHES_ALUNO(
RA_ALUNO INT NOT NULL REFERENCES TB_ALUNOS,
IDADE INT NOT NULL,
TELEFONE VARCHAR(20),
CELULAR VARCHAR(20),
E_MAIL VARCHAR(50) NOT NULL
);
GO
CREATE TABLE TB_ENDERECO_ALUNO(
RA_ALUNO INT NOT NULL REFERENCES TB_ALUNOS,
RUA VARCHAR(100),
NUMERO VARCHAR(10),
COMPLEMENTO VARCHAR(50),
CEP VARCHAR(20),
BAIRRO VARCHAR(50),
CIDADE VARCHAR(50),
ESTADO VARCHAR(10)
);
GO
CREATE TABLE TB_ALUNO_CONTRIBUINTE(
RA_ALUNO INT NOT NULL REFERENCES TB_ALUNOS,
CURSO VARCHAR(50) NOT NULL,
PERIODO VARCHAR(50) NOT NULL,
MODULO VARCHAR(10) NOT NULL,
ARMARIO INT NOT NULL
);
GO
CREATE TABLE TB_FUNCIONARIOS(
CODIGO INT NOT NULL PRIMARY KEY,
NOME VARCHAR(100) NOT NULL
);
GO
CREATE TABLE TB_DETALHES_FUNCIONARIO(
COD_FUNCIONARIO INT NOT NULL REFERENCES TB_FUNCIONARIOS,
CARGO VARCHAR(30) NOT NULL,
SALARIO MONEY NOT NULL,
DATA_ADMISSAO VARCHAR(15),
DATA_DEMISSAO VARCHAR(15),
CPF VARCHAR(20) NOT NULL,
RG VARCHAR(20) NOT NULL,
TELEFONE VARCHAR(20),
CELULAR VARCHAR(20),
E_MAIL VARCHAR(50) NOT NULL,
);
GO
CREATE TABLE TB_ENDERECO_FUNCIONARIO(
COD_FUNCIONARIO INT NOT NULL REFERENCES TB_FUNCIONARIOS,
RUA VARCHAR(100) NOT NULL,
NUMERO VARCHAR(10) NOT NULL,
COMPLEMENTO VARCHAR(50),
CEP VARCHAR(20) NOT NULL,
BAIRRO VARCHAR(50) NOT NULL,
CIDADE VARCHAR(50) NOT NULL,
ESTADO VARCHAR(10) NOT NULL
);
GO
CREATE TABLE TB_USUARIOS(
COD_FUNCIONARIO INT NOT NULL REFERENCES TB_FUNCIONARIOS,
USUARIO VARCHAR(50) NOT NULL UNIQUE,
SENHA VARCHAR(50) NOT NULL,
PERFIL VARCHAR(20) NOT NULL
);
GO
--COMANDO SELECT Alunos
SELECT * FROM TB_ALUNOS
GO
SELECT * FROM TB_DETALHES_ALUNO
GO
SELECT * FROM TB_ENDERECO_ALUNO
GO
SELECT * FROM TB_ALUNO_CONTRIBUINTE