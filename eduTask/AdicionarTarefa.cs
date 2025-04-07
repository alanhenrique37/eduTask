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

namespace eduTask
{
    public partial class AdicionarTarefa : Form
    {
        public AdicionarTarefa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArredondarMateria(MaskedTextBox maskedTextBox1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(maskedTextBox1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(maskedTextBox1.Width - raio, maskedTextBox1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, maskedTextBox1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            maskedTextBox1.Region = new Region(path);
        } // Fim

        private void ArredondarData(MaskedTextBox maskedTextBox2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(maskedTextBox2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(maskedTextBox2.Width - raio, maskedTextBox2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, maskedTextBox2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            maskedTextBox2.Region = new Region(path);
        } // Fim

        private void ArredondarConteudo(TextBox textBox1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(textBox1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(textBox1.Width - raio, textBox1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, textBox1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            textBox1.Region = new Region(path);
        } // Fim
        private void ArredondarProfessor(MaskedTextBox maskedTextBox4, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(maskedTextBox4.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(maskedTextBox4.Width - raio, maskedTextBox4.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, maskedTextBox4.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            maskedTextBox4.Region = new Region(path);
        } // Fim
        private void ArredondarBotaoAdicionarT(Button button1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button1.Width - raio, button1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoVoltar(Button button2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button2.Width - raio, button2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button2.Region = new Region(path);
        } // Fim



        private void AdicionarTarefa_Load(object sender, EventArgs e)
        {

            // Remove a borda do TextBox
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            textBox1.BorderStyle = BorderStyle.None;
            maskedTextBox4.BorderStyle = BorderStyle.None;

            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda



            button1.FlatAppearance.MouseDownBackColor = button1.BackColor; // Sem cor de fundo ao clic

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0; // Remove a borda
            button2.FlatAppearance.MouseDownBackColor = button2.BackColor; // Sem cor de fundo ao clic


            ArredondarMateria(maskedTextBox1, 10);
            ArredondarData(maskedTextBox2, 10);
            ArredondarConteudo(textBox1, 10);
            ArredondarProfessor(maskedTextBox4, 10);
            ArredondarBotaoAdicionarT(button1, 20);
            ArredondarBotaoVoltar(button2, 20);


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }//botao voltar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
