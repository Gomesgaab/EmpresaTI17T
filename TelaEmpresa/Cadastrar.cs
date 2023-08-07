using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaEmpresa
{
    public partial class Cadastrar : Form
    {
        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO(); //Ligando formulario ao banco de dados 
        }// fim construtor

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string result = conectar.inserir(Convert.ToInt64(cpf.Text), nome.Text, telefone.Text, cidade.Text, uf.Text, "pessoa");
                MessageBox.Show(result);
            }catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }// fim try catch
        }// fim do botão inserir 

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }// fim nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim telefone

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim cpf

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }// fim cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim uf

    }// fim classe
}// fim projeto
