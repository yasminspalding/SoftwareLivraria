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
    public partial class MenuCliente : Form
    {
        CompraCliente comp;
        ConsultarCompraCliente consuCompra;
        ReservaCliente reser;
        ConsultarReservaCliente consuReserva;
        AtualizaeEexcluirDadosCliente AED;

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void Compra_Click(object sender, EventArgs e)
        {
            comp = new CompraCliente();
            this.Visible = false;
            comp.ShowDialog();
            this.Visible = true;
        }

        private void consultarCompra_Click(object sender, EventArgs e)
        {
            consuCompra = new ConsultarCompraCliente();
            this.Visible = false;
            consuCompra.ShowDialog();
            this.Visible = true;
        }

        private void Reserva_Click(object sender, EventArgs e)
        {
            reser = new ReservaCliente();
            this.Visible = false;
            reser.ShowDialog();
            this.Visible = true;
        }

        private void consultarReserva_Click(object sender, EventArgs e)
        {
            consuReserva = new ConsultarReservaCliente();
            this.Visible = false;
            consuReserva.ShowDialog();
            this.Visible = true;
        }

        private void AtualizarDados_Click(object sender, EventArgs e)
        {
            AED = new AtualizaeEexcluirDadosCliente();
            this.Visible = false;
            AED.ShowDialog();
            this.Visible = true;
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
