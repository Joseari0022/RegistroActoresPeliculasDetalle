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
    public partial class ConsultaActores : Form
    {
        public ConsultaActores()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        Actores act = new Actores();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarId(ActoresBll.Buscar(u.StringToInt(FiltrotextBox.Text)));
        }

        private void BuscarId(Actores acto)
        {
            var act = ActoresBll.Buscar(u.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = acto.ActoresId.ToString();
            NombretextBox.Text = acto.Nombres;
            ConsultaActoresdataGridView.DataSource = null;
            ConsultaActoresdataGridView.DataSource = act.Peliculas;
        }

        private void Llenar(string aux)
        {
            var ac = ActoresBll.GetListaNombre((FiltrotextBox.Text));
            FiltrotextBox.Text = act.Nombres;
            ConsultaActoresdataGridView.DataSource = null;
            ConsultaActoresdataGridView.DataSource = act.Peliculas;
        }

        private void ConsultaActores_Load(object sender, EventArgs e)
        {
            LlenarFiltro();
        }

        private void LlenarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "ActoresId");
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
