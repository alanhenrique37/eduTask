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
    public partial class paginaPrincipal : Form
    {
        public paginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }

        private void Criar_Click(object sender, EventArgs e)
        {

        }

        private void ArredondarTextBox(TextBox barraDeBusca, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(barraDeBusca.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(barraDeBusca.Width - raio, barraDeBusca.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, barraDeBusca.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            barraDeBusca.Region = new Region(path);
        } // Fim

        private void ArredondarBotao(Button button2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button2.Width - raio, button2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button2.Region = new Region(path);
        } // Fim



        private void ArredondarBotaoLupa(Button button1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button1.Width - raio, button1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoAdicionar(Button button3, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button3.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button3.Width - raio, button3.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button3.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button3.Region = new Region(path);
        } // Fim

        private void ArredondarListView1(ListView listView1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView1.Width - raio, listView1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView1.Region = new Region(path);
        } // Fim

        private void ArredondarListView3(ListView listView3, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView3.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView3.Width - raio, listView3.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView3.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView3.Region = new Region(path);
        } // Fim

        private void ArredondarListView4(ListView listView4, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView4.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView4.Width - raio, listView4.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView4.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView4.Region = new Region(path);
        } // Fim

        private void ArredondarListView5(ListView listView2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView2.Width - raio, listView2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView2.Region = new Region(path);
        } // Fim


        private void ArredondarControle(Control controle, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(controle.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(controle.Width - raio, controle.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, controle.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            controle.Region = new Region(path);
        } //Fim

        private void paginaPrincipal_Load(object sender, EventArgs e)
        {

         

            // Remove a borda do TextBox
            barraDeBusca.BorderStyle = BorderStyle.None;

            // Define o estilo do botão como FlatStyle

            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda

          

            button1.FlatAppearance.MouseDownBackColor = button1.BackColor; // Sem cor de fundo ao clic

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda

 

            button2.FlatAppearance.MouseDownBackColor = button2.BackColor; // Sem cor de fundo ao clic

            button3.FlatStyle = FlatStyle.Flat;

            button3.FlatAppearance.BorderSize = 0; // Remove a borda

         

            button3.FlatAppearance.MouseDownBackColor = button3.BackColor; // Sem cor de fundo ao clic

            button4.FlatStyle = FlatStyle.Flat;

            button4.FlatAppearance.BorderSize = 0; // Remove a borda

           

            button4.FlatAppearance.MouseDownBackColor = button4.BackColor; // Sem cor de fundo ao clic


            listView1.BorderStyle = BorderStyle.None; // Remove a borda
            listView3.BorderStyle = BorderStyle.None; // Remove a borda
            listView4.BorderStyle = BorderStyle.None; // Remove a borda
           




            ArredondarTextBox(barraDeBusca, 10);
            ArredondarBotao(button2, 10);
            ArredondarBotaoAdicionar(button3, 90);
            ArredondarBotaoLupa(button1, 10);
            ArredondarListView1(listView1, 20);
            ArredondarListView3(listView3, 20);
            ArredondarListView4(listView4, 20);


          




        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }//botao de pesquisar

        private void button2_Click(object sender, EventArgs e)
        {

        }//botao de filtrar

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarTarefa adi = new AdicionarTarefa();
            adi.ShowDialog();
        }//Botão adicionar Tarefas

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }//Botão ver todas Tarefas

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
