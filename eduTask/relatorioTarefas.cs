using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace eduTask
{
    public partial class relatorioTarefas : Form
    {
     


        public relatorioTarefas()
        {
            InitializeComponent();
         

        }



  

        private void relatorioTarefas_Load(object sender, EventArgs e)
        {
            listView2.BorderStyle = BorderStyle.None; // Remove a borda
            listView1.BorderStyle = BorderStyle.None; // Remove a borda
            listBox2.BorderStyle = BorderStyle.None; // Remove a borda

            //button1.FlatAppearance.MouseDownBackColor = button1.BackColor; // Sem cor de fundo ao clic
            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda



            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda


            ArredondarBotaoGerar(button1, 10);
            ArredondarBotaoVoltar(button2, 10);







            ArredondarListView2(listView2, 20);
        }


        private void ArredondarBotaoGerar(System.Windows.Forms.Button button1, int raio)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            DAO dao = new DAO();

            int total = dao.Contar("SELECT COUNT(*) FROM tarefas");
            int feitas = dao.Contar("SELECT COUNT(*) FROM tarefas WHERE situacao = 'feito'");
            int pendentes = dao.Contar("SELECT COUNT(*) FROM tarefas WHERE situacao = 'pendente'");

            listView1.Items.Add(" RELATÓRIO DE TAREFAS ");
            listBox2.Items.Add($"Total: {total}");
            listBox2.Items.Add($"Feitas: {feitas}");
            listBox2.Items.Add($"Pendentes: {pendentes}");

            string[] materias = { "matemática", "português", "história", "geografia", "biologia" };

            foreach (string materia in materias)
            {
                int qtd = dao.Contar($"SELECT COUNT(*) FROM tarefas WHERE materia = '{materia}'");
                listBox2.Items.Add($"{char.ToUpper(materia[0]) + materia.Substring(1)}: {qtd}");
            }

            int outras = dao.Contar("SELECT COUNT(*) FROM tarefas WHERE materia NOT IN ('matemática','português','história','geografia','biologia')");
            listBox2.Items.Add($"Outras matérias: {outras}");
        }

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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
    }

