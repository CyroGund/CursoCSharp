using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoXML
{
    public partial class Form1 : Form
    {
        PessoasDAO pessoas = new PessoasDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.codigo = Convert.ToInt32(txtCodigo.Value);
            p.nome = txtNome.Text;
            p.telefone = txtTelefone.Text;
            pessoas.AdicionarPessoa(p);
            gridPessoas.DataSource = pessoas.ListarPessoas();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridPessoas.DataSource = pessoas.ListarPessoas();
        }

        private void gridPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = gridPessoas.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nome = gridPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
            string telefone = gridPessoas.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtCodigo.Value = Convert.ToInt32(codigo);
            txtNome.Text = nome;
            txtTelefone.Text = telefone;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtCodigo.Value > 0)
            {
                Pessoa p = new Pessoa()
                {
                    nome = txtNome.Text,
                    telefone = txtTelefone.Text,
                    codigo = Convert.ToInt32(txtCodigo.Value)
                };
                pessoas.ExcluirPessoa(p.codigo);
                gridPessoas.DataSource = pessoas.ListarPessoas();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Value > 0)
            {
                Pessoa p = new Pessoa()
                {
                    nome = txtNome.Text,
                    telefone = txtTelefone.Text,
                    codigo = Convert.ToInt32(txtCodigo.Value)
                };
                pessoas.EditarPessoa(p);
                gridPessoas.DataSource = pessoas.ListarPessoas();
            }
        }
    }
}
