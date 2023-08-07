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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }// fim construtor

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim cpf

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "pessoa");
            MessageBox.Show("Excluido com sucesso!");
        }// fim botão 
    }// fim classe
}// fim projeto
