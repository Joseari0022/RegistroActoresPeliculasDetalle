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
    public partial class RegistrosActores : Form
    {
        public RegistrosActores()
        {
            InitializeComponent();
        }
        Utilidades u = new Utilidades();
        Actores acto = new Actores();
        private void Idbutton_Click(object sender, EventArgs e)
        {
           Pasar(ActoresBll.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Pasar(Actores act)
        {
            var es = ActoresBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = act.ActoresId.ToString();
            NombretextBox.Text = act.Nombres;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(acto);
            ActoresBll.Guardar(acto);
            MessageBox.Show("Guardado con exito!!!");
        }

        private void LlenarClase(Actores actore)
        {
            actore.Nombres = NombretextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ActoresBll.Eliminar(u.StringToInt(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!");
        }
    }
}
