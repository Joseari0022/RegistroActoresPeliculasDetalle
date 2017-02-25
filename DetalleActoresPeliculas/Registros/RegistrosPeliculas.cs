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

namespace DetalleActoresPeliculas.Registros
{
    public partial class RegistrosPeliculas : Form
    {
        public RegistrosPeliculas()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        Peliculas pel = new Peliculas();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidId() && ValidBus())
                Pasar(PeliculasBll.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Pasar(Peliculas pl)
        {
            var p = PeliculasBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = pl.PeliculasId.ToString();
            NombretextBox.Text = pl.Nombres;
            ActoresdataGridView.DataSource = null;
            ActoresdataGridView.DataSource = pl.Actores;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ActoresdataGridView = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(pel);
            if (ValidTextB() && ValidExi(NombretextBox.Text))
            {
                PeliculasBll.Guardar(pel);
                MessageBox.Show("Guardado con exito!!!");
            }
        }

        private void LlenarClase(Peliculas pl)
        {
            pl.Nombres = NombretextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            PeliculasBll.Eliminar(u.StringToInt(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!");
        }

        private void LlenarCombo()
        {
            ActorescomboBox.DataSource = ActoresBll.GetLista();
            ActorescomboBox.ValueMember = "ActoresId";
            ActorescomboBox.DisplayMember = "Nombres";
        }

        private void RegistrosPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            pel.Actores.Add(new Actores((int)ActorescomboBox.SelectedValue, ActorescomboBox.Text));
            ActoresdataGridView.DataSource = null;
            ActoresdataGridView.DataSource = pel.Actores;
        }

        private bool ValidTextB()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                MessageBox.Show("Llenar todo los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                return false;
            }
            return true;
        }

        private bool ValidExi(string au)
        {
            if (PeliculasBll.GetListaNombre(au).Count() > 0)
            {
                MessageBox.Show("Este nombre existe");
                return false;
            }
            return true;
        }

        private bool ValidId()
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("Por Favor Ingrese El Id");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidBus()
        {
            if (PeliculasBll.Buscar(u.StringToInt(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este Grupo no existe");
                return false;
            }
            return true;
        }
    }
}
