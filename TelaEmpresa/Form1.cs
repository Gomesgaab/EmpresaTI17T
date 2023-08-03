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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir   exc;


        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }// fim do construtor


        private void label6_Click(object sender, EventArgs e)
        {

        }//Titulo      

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();// abre a tela
        }//cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();
        }// consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();  
        }//atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }// excluir
    }// fim classe
}// fim projeto
