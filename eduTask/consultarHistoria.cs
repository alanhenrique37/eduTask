using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduTask
{
    public partial class consultarHistoria : Form
    {
        DAO consul;
        public consultarHistoria()
        {
            InitializeComponent();
            consul = new DAO();
            ConfigurarDataGrid();//configura a estrutura da coluna e linhas
            NomeColunas();//nomeando as colunas
            adicionardados();//adicionando os dados para vizualizar
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

        public void adicionardados()
        {
            consul.PreencherVetor(); // Preencher os vetores com dados do banco

            // Percorrer todos os dados
            for (int i = 0; i < consul.QuantidadeDeDados(); i++)
            {
                // Remover acentos e transformar para minúsculas

                string materiaSemAcento = RemoverAcentos(consul.materia[i]).ToLower();

                // Verificar se a matéria é Matemática
                if (materiaSemAcento == "historia") // ou se a comparação for com "Matemática"
                {
                    // Adicionar a linha somente se a matéria for Matemática
                    dataGridView1.Rows.Add(consul.codigo[i], consul.materia[i], consul.professor[i], consul.dataa[i], consul.conteudo[i], consul.situacao[i]);
                }
            } // fim do for
        } // fim do adicionar dados

        private string RemoverAcentos(string texto)
        {
            string normalizedString = texto.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void ArredondarBotaoAtu(Button button1, int raio)
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

        private void consultarHistoria_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda

            ArredondarBotaoAtu(button1, 10);
            ArredondarBotaoExcluir(button2, 10);
        }

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
    }
}
