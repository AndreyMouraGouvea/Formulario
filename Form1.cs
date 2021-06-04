using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturar respostas
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoM;
            bool generoF;
            int numeroCadastro;

            nomeUsuario = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBox1.Text;
            generoM = radioButton1.Checked;
            generoF = radioButton2.Checked;
            numeroCadastro = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Nome: "+ nomeUsuario);
            MessageBox.Show("Nascimento: " + dataNascimento);
            MessageBox.Show("Cidade: " + cidade);
            if (generoM == true)
            {
                MessageBox.Show("Sexo Masculino: " + generoM);

            }
            else
            {
                MessageBox.Show("Sexo Feminino: " + generoF);
            }
            MessageBox.Show("Número de Cadastro: " + numeroCadastro);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
