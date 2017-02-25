using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetalleActoresPeliculas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosActores ra = new Registros.RegistrosActores();
            ra.MdiParent = this.MdiParent;
            ra.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosPeliculas rp = new Registros.RegistrosPeliculas();
            rp.MdiParent = this.MdiParent;
            rp.Show();
        }

        private void actoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaActores rp = new Consultas.ConsultaActores();
            rp.MdiParent = this.MdiParent;
            rp.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultasPeliculas rp = new Consultas.ConsultasPeliculas();
            rp.MdiParent = this.MdiParent;
            rp.Show();
        }
    }
}
