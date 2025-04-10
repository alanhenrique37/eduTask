using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eduTask
{
    public partial class ExcluirTarefa : Form
    {
        DAO exc;
        public ExcluirTarefa()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void ExcluirTarefa_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0; // Remove a borda

            button2.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0; // Remove a borda
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedTextBox5.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
