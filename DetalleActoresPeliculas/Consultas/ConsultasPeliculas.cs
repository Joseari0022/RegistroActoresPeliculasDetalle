using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace DetalleActoresPeliculas.Consultas
{
    public partial class ConsultasPeliculas : Form
    {
        public ConsultasPeliculas()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        Peliculas pel = new Peliculas();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscaId(PeliculasBll.Buscar(u.StringToInt(FiltrotextBox.Text)));
        }

        private void BuscaId(Peliculas pe)
        {
            var peli = PeliculasBll.Buscar(u.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = pe.PeliculasId.ToString();
            NombretextBox.Text = pe.Nombres;
            ConsultaPeliculadataGridView.DataSource = null;
            ConsultaPeliculadataGridView.DataSource = peli.Actores;
        }

        private void ConsultasPeliculas_Load(object sender, EventArgs e)
        {
            LlenarFiltro();
        }

        private void LlenarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "PeliculasId");
            FiltrarcomboBox.Items.Insert(1, "Nombres");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = " Id";
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    IderrorProvider.SetError(FiltrotextBox, "Ingrese el campo....");

                    return false;
                }
                if (FiltrarcomboBox.SelectedIndex == 1 && PeliculasBll.GetListaNombre(FiltrotextBox.Text).Count == 0)
                {
                    MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                    return false;
                }
            }
            IderrorProvider.Clear();
            return true;
        }
    }
}
