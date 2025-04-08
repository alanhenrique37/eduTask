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
    public partial class AdicionarTarefa : Form
    {
        public AdicionarTarefa()
        {
            InitializeComponent();
            DAO conexao = new DAO();
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

        private void ArredondarConteudo(MaskedTextBox maskedTextBox3, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(maskedTextBox3.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(maskedTextBox3.Width - raio, maskedTextBox3.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, maskedTextBox3.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            maskedTextBox3.Region = new Region(path);
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
        private void ArredondarBotaoAdicionarT(System.Windows.Forms.Button button1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button1.Width - raio, button1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoVoltar(System.Windows.Forms.Button button2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button2.Width - raio, button2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button2.Region = new Region(path);
        } // Fim

        private void ArredondarCodigo(MaskedTextBox maskedTextBox5, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(maskedTextBox5.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(maskedTextBox5.Width - raio, maskedTextBox5.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, maskedTextBox5.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            maskedTextBox5.Region = new Region(path);
        } // Fim



        private void AdicionarTarefa_Load(object sender, EventArgs e)
        {

            // Remove a borda do TextBox
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox3.BorderStyle = BorderStyle.None;
            maskedTextBox5.BorderStyle = BorderStyle.None;

            maskedTextBox4.BorderStyle = BorderStyle.None;

            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda



            button1.FlatAppearance.MouseDownBackColor = button1.BackColor; // Sem cor de fundo ao clic

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0; // Remove a borda
            button2.FlatAppearance.MouseDownBackColor = button2.BackColor; // Sem cor de fundo ao clic


            ArredondarMateria(maskedTextBox1, 10);
            ArredondarData(maskedTextBox2, 10);
            ArredondarConteudo(maskedTextBox3, 10);
            ArredondarProfessor(maskedTextBox4, 10);
            ArredondarBotaoAdicionarT(button1, 20);
            ArredondarBotaoVoltar(button2, 20);
            ArredondarCodigo(maskedTextBox5, 10);


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
            //Instanciando a classe DAO
            DAO inserir = new DAO();
            //Coletando os dados dos campos
            int codigo = Convert.ToInt32(maskedTextBox5.Text);
            string materia = maskedTextBox1.Text;
            string professor = maskedTextBox4.Text;
            string dataa = maskedTextBox2.Text;
            string conteudo =  maskedTextBox3.Text;
            //Chamando o método inserir
            MessageBox.Show(inserir.Inserir(codigo, materia, professor, dataa, conteudo));
            this.Close();//Fechar a janela cadastrar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }//botao voltar

    

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }//espaço conteudo

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
