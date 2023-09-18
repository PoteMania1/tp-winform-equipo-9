using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo_9
{
    public partial class frmPrincipal : Form
    {
        private List<Imagen> listaImagen = new List<Imagen>();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            /*NegocioArticulo negocio = new NegocioArticulo();
            dgvArticulo.DataSource = negocio.Listar();*/
            Cargar();
        }

        private void Cargar()
        {
            NegocioArticulo negocio = new NegocioArticulo();
            dgvArticulo.DataSource = negocio.Listar();

            pictureBoxImagenArticulo.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagenArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenArticulo.Load("https://xmeme-fe.netlify.app/src/placeholder-xmeme.jpg");
        }


        /*private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
        Imagen seleccionado = (Imagen)dgvArticulo.CurrentRow.DataBoundItem;
        cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
        try
        {
            pictureBoxImagenArticulo.Load(imagen);
        }
        catch (Exception ex)
        {
            pictureBoxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
        }
        }*/
    }


}

