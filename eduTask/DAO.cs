using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace eduTask
{
   class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] materia;
        public string[] professor;
        public string[] dataa;
        public string[] conteudo;
        public string[] situacao;
        public int i;
        public int contador;


        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=eduTask;Uid=root;password=");
            try
            {
                conexao.Open(); // já abre a conexão aqui
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }

        // Método que executa contagens genéricas
        public int Contar(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao contar: " + ex.Message);
                return 0;
            }
        }

        public string Inserir(int codigo, string materia, string professor, string dataa, string conteudo, string situacao)
        {
            string inserir = $"Insert into tarefas(codigo,materia, professor, dataa, conteudo,situacao) values('{codigo}','{materia}','{professor}', '{dataa}', '{conteudo}', '{situacao}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }//fim do método inserir

     

        public void PreencherVetor()
        {

            string query = "select * from tarefas";

            //instanciar vetores
            this.codigo = new int[100];
            this.materia = new string[100];
            this.professor = new string[100];
            this.dataa = new string[100];
            this.conteudo = new string[100];
            this.situacao = new string[100];


            //preparando comando para o banco

            MySqlCommand Sql = new MySqlCommand(query, conexao);
            //chamar o leitor do banco de dados
            MySqlDataReader leitura = Sql.ExecuteReader();

            i = 0;//instanciando o contador
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                materia[i] = leitura["materia"] + "";
                professor[i] = leitura["professor"] + "";
                dataa[i] = leitura["dataa"] + "";
                conteudo[i] = leitura["conteudo"] + "";
                situacao[i] = leitura["situacao"] + "";
                i++;//contador gira
                contador++;//conta quantos dados preenchem o vetor
            }//fim do while

            //encerrar processo de leitura
            leitura.Close();
        }//fim do método

        public int QuantidadeDeDados()
        {
            return contador;
        }//fim qntd de dados


        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update tarefas set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }//fim metodo atualizar

        public string Excluir(int conteudo)
        {
            string query = $"delete from tarefas where codigo = '{conteudo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Deletado";
            return resultado;
        }

        public string ConsultarPorMateria(int cod)
        {
            PreencherVetor();//Preenchendo o vetor com os dados do banco

            i = 0;//Instanciando o contador
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return Convert.ToString(i);
                }
                i++;//Contador gire
            }//fim do while

            return Convert.ToString(- 1);
        
        }//fim do método


        public string RetornarMateria(int cod)
        {
            int posicao = Convert.ToInt32(ConsultarPorMateria(cod));
            if (posicao > -1)
            {
                return materia[posicao];
            }
            return "Código digitado não é valido!";
        }//fim do métodoRetornarMateria

        public string RetornarProfessor(int cod)
        {
            int posicao = Convert.ToInt32(ConsultarPorMateria(cod));
            if (posicao > -1)
            {
                return professor[posicao];
            }
            return "Código digitado não é valido!";
        }//fim do métodoRetornarProfessor

        public string RetornarData(int cod)
        {
            int posicao = Convert.ToInt32(ConsultarPorMateria(cod));
            if (posicao > -1)
            {
                return dataa[posicao];
            }
            return "Código digitado não é valido!";
        }//fim do métodoRetornarData

        public string RetornarConteudo(int cod)
        {
            int posicao = Convert.ToInt32(ConsultarPorMateria(cod));
            if (posicao > -1)
            {
                return conteudo[posicao];
            }
            return "Código digitado não é valido!";
        }//fim do métodoRetornarConteudo

        public string RetornarSituacao(int cod)
        {
            int posicao = Convert.ToInt32(ConsultarPorMateria(cod));
            if (posicao > -1)
            {
                return situacao[posicao];
            }
            return "Código digitado não é valido!";
        }//fim do métodoRetornarConteudo


     







    }//fim class dao
}
