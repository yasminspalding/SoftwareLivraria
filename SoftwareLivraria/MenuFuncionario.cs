using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLivraria
{
    public partial class MenuFuncionario : Form
    {
        ConsultarTodasCompras CTCompras;
        ConsultarTodasReservas CTReservas;
        AtualizarExcluirLivro AELivro;
        AtualizarExcluirFunc AEFunc;
        CadastroLivro CadLivro;
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void consultarCompra_Click(object sender, EventArgs e)
        {
            CTCompras = new ConsultarTodasCompras();
            this.Visible = false;
            CTCompras.ShowDialog();
            this.Visible = true;
        }

        private void CadastrarLivro_Click(object sender, EventArgs e)
        {
            CadLivro = new CadastroLivro();
            this.Visible = false;
            CadLivro.ShowDialog();
            this.Visible = true;
        }

        private void excluirLivro_Click(object sender, EventArgs e)
        {
            AELivro = new AtualizarExcluirLivro();
            this.Visible = false;
            AELivro.ShowDialog();
            this.Visible = true;
        }

        private void consultarReserva_Click(object sender, EventArgs e)
        {
            CTReservas = new ConsultarTodasReservas();
            this.Visible = false;
            CTReservas.ShowDialog();
            this.Visible = true;
        }

        private void atualizarFuncionario_Click(object sender, EventArgs e)
        {
            AEFunc = new AtualizarExcluirFunc();
            this.Visible = false;
            AEFunc.ShowDialog();
            this.Visible = true;
        }
    }
}
