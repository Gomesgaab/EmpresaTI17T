using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Importando a classe da dados do MYSQL

namespace TelaEmpresa
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[]   cpf;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] UF;
        public int      i;
        public int      contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexao com o banco de dados  
                MessageBox.Show("Conectado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo dey errado! \n\n" + erro.Message);
            }
        }// fim DAO

        // metodo inserção
        public string inserir(long cpf, string nome, string telefone, string cidade, string UF, string nomeTabela)
        {
            string inserir   = $"insert into {nomeTabela}(cpf, nome, telefone, cidade, UF) values('{cpf}','{nome}','{telefone}','{cidade}','{UF}')";//codigo banco de dados
            MySqlCommand sql = new MySqlCommand(inserir, conexao);//preparando para executar 
            string resultado = sql.ExecuteNonQuery() + "Executado!";//executando dentro do banco, "control enter"
            return resultado;
        }// fim metodo 

        public void PreencherVetor()
        {
            string query = "Select * from pessoa";

            // instanciar 
            this.cpf      = new long[100];
            this.nome     = new string[100];
            this.telefone = new string[100];
            this.cidade   = new string[100];
            this.UF       = new string[100];

            // preparar comando 
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //leitor 
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while(leitura.Read())
            {
                cpf[i]      = Convert.ToInt64(leitura["cpf"]);
                nome[i]     = leitura["nome"]     + "";
                telefone[i] = leitura["telefone"] + "";
                cidade[i]   = leitura["cidade"]   + "";
                UF[i]       = leitura["UF"]       + "";
                i++;// posição do vetor
                contador++;// definingo quantos dados tem
            }//fim while 
            
            //encerrar comunicação com o banco
            leitura.Close();
        }// fim metodo 
        
        public int QuantidadeDeDados()
        {
            return contador;
        }// fim metodo

        public string Atualizar(long cpf, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand (query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }// fim do método atualizar

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!";
            return resultado;
        }// fim método excluir 
    }// fim classe
}// fim projeto
