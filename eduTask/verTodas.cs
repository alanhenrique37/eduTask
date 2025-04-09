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
    public partial class verTodas : Form
    {
        DAO consul;
        public verTodas()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();//Configuro a estrutura da coluna e linha
            NomeColunas();//Nomeando as colunas
            AdicionarDados();//Adicionando os dados para visualizar
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Matéria";
            dataGridView1.Columns[2].Name = "Professor";
            dataGridView1.Columns[3].Name = "Data";
            dataGridView1.Columns[4].Name = "Conteúdo";
        }//fim do nomeColunas

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Não pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Não pode redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Não pode redimensionar as linhas

            dataGridView1.ColumnCount = 5;
        }//fim do método de configuração

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores c/dados do bd
            for (int i = 0; i < consul.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.materia[i], consul.professor[i], consul.dataa[i], consul.conteudo[i]);
            }//fim do for
        }//fim do adicionarDados

        private void verTodas_Load(object sender, EventArgs e)
        {
           

            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda

            ArredondarBotaoEditar(button1, 10);

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda

            ArredondarBotaoExcluir(button2, 10);
        }

        private void ArredondarBotaoEditar(Button button1, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button1.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button1.Width - raio, button1.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button1.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        } // Fim

        private void ArredondarBotaoExcluir(Button button2, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(button2.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(button2.Width - raio, button2.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, button2.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            button2.Region = new Region(path);
        } // Fim

        private void button1_Click(object sender, EventArgs e)
        {
            EditarTarefa edi = new EditarTarefa();
            edi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirTarefa exc = new ExcluirTarefa();
            exc.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ajustando a largura de todas as colunas
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 200;  // Largura de todas as colunas
            }

            // Ajustando a altura das linhas
            dataGridView1.RowTemplate.Height = 80;  // Tamanho das linhas

            // Aumentando o tamanho da fonte dos cabeçalhos das colunas
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);  // Fonte dos cabeçalhos das colunas

        }
    }
}
