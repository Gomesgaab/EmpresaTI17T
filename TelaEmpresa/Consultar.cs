using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaEmpresa
{
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDatagrid();// chamando 
            NomeColunas();      // nomear o titulo das colunas 
            AdicionarDados();  //Preenchendo o dataGridView1

        }// fim consultor
        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "cpf";
            dataGridView1.Columns[1].Name = "nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";
        }// fim metodo
        public void ConfigurarDatagrid()
        { 
            dataGridView1.AllowUserToAddRows       = false;   // adiccionar linha
            dataGridView1.AllowUserToDeleteRows    = false;  // Deletar linhas 
            dataGridView1.AllowUserToResizeColumns = false; // Redimencionar linhas 
            dataGridView1.AllowUserToResizeRows    = false;// Redimencionar linhas 

            dataGridView1.ColumnCount = 5;
        }// fim configuração
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }//fim

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void AdicionarDados()
        {
            consul.PreencherVetor();// preenchendo vetor
            for (int i = 0; i < consul.QuantidadeDeDados(); i++)
            {

                dataGridView1.Rows.Add(consul.cpf[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.UF[i]);

            }// Adicionar dados no dataGridView1
        }// fim do método
    }// fim classe
}// fim projeto 
