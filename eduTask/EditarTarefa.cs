using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eduTask
{
    public partial class EditarTarefa : Form
    {
        DAO atu;
        public EditarTarefa()
        {
            atu = new DAO();
            InitializeComponent();
            maskedTextBox5.ReadOnly = false;
            maskedTextBox1.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            maskedTextBox6.ReadOnly = true;
        }

        private void EditarTarefa_Load(object sender, EventArgs e)
        {

            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda

            button3.FlatStyle = FlatStyle.Flat;

            button3.FlatAppearance.BorderSize = 0; // Remove a borda


        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox5.Text == "")
            {
                maskedTextBox1.Text = "Informe o código";
                maskedTextBox4.Text = "Informe o código";
                maskedTextBox2.Text = "Informe o código";
                maskedTextBox3.Text = "Informe o código";
                maskedTextBox6.Text = "Informe o código";
            }
            else
            {
                int codigo = Convert.ToInt32(maskedTextBox5.Text);//coletando

                maskedTextBox1.Text = atu.RetornarMateria(codigo);//preenchendo o campo materia
                maskedTextBox4.Text = atu.RetornarProfessor(codigo);//preenchendo o campo professor
                maskedTextBox2.Text = atu.RetornarData(codigo);//preenchendo o campo data
                maskedTextBox3.Text = atu.RetornarConteudo(codigo);//preenchendo o campo conteudo
                maskedTextBox6.Text = atu.RetornarSituacao(codigo);//preenchendo o campo conteudo


                maskedTextBox5.ReadOnly = true;
                maskedTextBox1.ReadOnly = false;
                maskedTextBox4.ReadOnly = false;
                maskedTextBox2.ReadOnly = false;
                maskedTextBox3.ReadOnly = false;
                maskedTextBox6.ReadOnly = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedTextBox5.Text);
            string materia = maskedTextBox1.Text;
            string professor = maskedTextBox4.Text;
            string dataa = maskedTextBox2.Text;
            string conteudo = maskedTextBox3.Text;
            string situacao = maskedTextBox6.Text;


            atu.Atualizar(codigo, "materia", materia);
            atu.Atualizar(codigo, "professor", professor);
            atu.Atualizar(codigo, "dataa", dataa);
            atu.Atualizar(codigo, "conteudo", conteudo);
            atu.Atualizar(codigo, "situacao", situacao);
            MessageBox.Show("Dados atualizado com sucesso!");
            this.Close();
        }
        private void ArredondarListView1(System.Windows.Forms.ListView listView1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView1.Width - raio, listView1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView1.Region = new Region(path);
        } // Fim

      

        private void ArredondarListView2(System.Windows.Forms.ListView listView2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView2.Width - raio, listView2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView2.Region = new Region(path);
        } // Fim


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
