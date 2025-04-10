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
        
        DAO consul;
        public paginaPrincipal()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();//Configuro a estrutura da coluna e linha
            NomeColunas();//Nomeando as colunas
            AdicionarDados();//Adicionando os dados para visualizar
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }
        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Matéria";
            dataGridView1.Columns[2].Name = "Professor";
            dataGridView1.Columns[3].Name = "Data";
            dataGridView1.Columns[4].Name = "Conteúdo";
            dataGridView1.Columns[5].Name = "Status";
        }//fim do nomeColunas

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Não pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Não pode redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Não pode redimensionar as linhas

            dataGridView1.ColumnCount = 6;
        }//fim do método de configuração

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores c/dados do bd
            for (int i = 0; i < consul.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.materia[i], consul.professor[i], consul.dataa[i], consul.conteudo[i], consul.situacao[i]);
            }//fim do for
        }//fim do adicionarDados

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

        private void ArredondarBotaoMat(Button button5, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button5.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button5.Width - raio, button5.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button5.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button5.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoPor(Button button7, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button7.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button7.Width - raio, button7.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button7.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button7.Region = new Region(path);
        } // Fim
        private void ArredondarBotaoBio(Button button8, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button8.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button8.Width - raio, button8.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button8.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button8.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoHis(Button button9, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button9.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button9.Width - raio, button9.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button9.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button9.Region = new Region(path);
        } // Fim


        private void ArredondarBotaoGeo(Button button6, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button6.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button6.Width - raio, button6.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button6.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button6.Region = new Region(path);
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

        private void ArredondarListView2(ListView listView2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView2.Width - raio, listView2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView2.Region = new Region(path);
        } // Fim

        private void ArredondarListView5(ListView listView5, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView5.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView5.Width - raio, listView5.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView5.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView5.Region = new Region(path);
        } // Fim

        private void ArredondarListView7(ListView listView7, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView7.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView7.Width - raio, listView7.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView7.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView7.Region = new Region(path);
        } // Fim

        private void ArredondarListView6(ListView listView6, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView6.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView6.Width - raio, listView6.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView6.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView6.Region = new Region(path);
        } // Fim

        private void ArredondarListView8(ListView listView8, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(listView8.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(listView8.Width - raio, listView8.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, listView8.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            listView8.Region = new Region(path);
        } // Fim



        private void paginaPrincipal_Load(object sender, EventArgs e)
        {

         

            // Remove a borda do TextBox
            barraDeBusca.BorderStyle = BorderStyle.None;

            // Define o estilo do botão como FlatStyle

            button1.FlatStyle = FlatStyle.Flat;

            //button1.FlatAppearance.BorderSize = 0; // Remove a borda

          

            //button1.FlatAppearance.MouseDownBackColor = button1.BackColor; // Sem cor de fundo ao clic

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda

 

            //button2.FlatAppearance.MouseDownBackColor = button2.BackColor; // Sem cor de fundo ao clic

            button3.FlatStyle = FlatStyle.Flat;

            button3.FlatAppearance.BorderSize = 0; // Remove a borda

            button5.FlatStyle = FlatStyle.Flat;

            button5.FlatAppearance.BorderSize = 0; // Remove a borda
         



            //button3.FlatAppearance.MouseDownBackColor = button3.BackColor; // Sem cor de fundo ao clic

            button4.FlatStyle = FlatStyle.Flat;

            button4.FlatAppearance.BorderSize = 0; // Remove a borda

            button7.FlatStyle = FlatStyle.Flat;

            button7.FlatAppearance.BorderSize = 0; // Remove a borda

            button8.FlatStyle = FlatStyle.Flat;

            button8.FlatAppearance.BorderSize = 0; // Remove a borda

            button9.FlatStyle = FlatStyle.Flat;

            button9.FlatAppearance.BorderSize = 0; // Remove a borda

            button6.FlatStyle = FlatStyle.Flat;

            button6.FlatAppearance.BorderSize = 0; // Remove a borda



            //button4.FlatAppearance.MouseDownBackColor = button4.BackColor; // Sem cor de fundo ao clic


            listView1.BorderStyle = BorderStyle.None; // Remove a borda
            listView3.BorderStyle = BorderStyle.None; // Remove a borda
            listView4.BorderStyle = BorderStyle.None; // Remove a borda
            listView2.BorderStyle = BorderStyle.None; // Remove a borda
            listView5.BorderStyle = BorderStyle.None; // Remove a borda
            listView6.BorderStyle = BorderStyle.None; // Remove a borda
            listView7.BorderStyle = BorderStyle.None; // Remove a borda
            listView8.BorderStyle = BorderStyle.None; // Remove a borda





            ArredondarTextBox(barraDeBusca, 10);
            ArredondarBotao(button2, 10);
            ArredondarBotaoMat(button5, 10);
            ArredondarBotaoPor(button7, 10);
            ArredondarBotaoBio(button8, 10);
            ArredondarBotaoHis(button9, 10);
            ArredondarBotaoGeo(button6, 10);
            ArredondarBotaoAdicionar(button3, 90);
            ArredondarBotaoLupa(button1, 10);
            ArredondarListView1(listView1, 20);
            ArredondarListView3(listView3, 20);
            ArredondarListView4(listView4, 20);
            ArredondarListView2(listView2, 20);
            ArredondarListView5(listView5, 20);
            ArredondarListView6(listView6, 20);
            ArredondarListView7(listView7, 20);
            ArredondarListView8(listView8, 20);










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
            verTodas ver = new verTodas();
            ver.ShowDialog();
        }//Botão ver todas Tarefas

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultarMatematica conMat = new consultarMatematica();
            conMat.ShowDialog();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            consultarPortugues conPor = new consultarPortugues();
            conPor.ShowDialog();
        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            consultarBiologia conBio = new consultarBiologia();
            conBio.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            consultarHistoria conHis = new consultarHistoria();
            conHis.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do método

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Data")
            {
                DateTime dtVenci = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if ((dtVenci - DateTime.Today).TotalDays <= 3)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);

                }
            }

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            consultarGeografia conGeo = new consultarGeografia();
            conGeo.ShowDialog();
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        }
    }

