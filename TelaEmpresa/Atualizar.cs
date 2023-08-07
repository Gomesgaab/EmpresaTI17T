using Google.Protobuf.WellKnownTypes;
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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }// fim construtor

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "nome", nome.Text);// atualizo nome
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "telefone", telefone.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "cidade", cidade.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "uf", uf.Text);
            MessageBox.Show("Dados atualizados com sucesso!");
        }// botão atualizar

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
