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
        //private List<Articulo> listaArticulo;
        private int contClick = 0;
        private int maxImg = 0;
        private int pivot = 0;
        private int _pictureIndex = 0;

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
            imagenLoad();

            /*pictureBoxImagenArticulo.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagenArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenArticulo.Load("https://pbs.twimg.com/profile_images/1612285524735148033/1zMtxkWb_400x400.jpg");*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar();
            frm.ShowDialog();
        }
        private void imagenLoad()
        {

            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            List<Marca> listaMarca = new List<Marca>();
            List<Categoria> listaCategoria = new List<Categoria>();
            List<Articulo> listaArticulo = new List<Articulo>();
            listaMarca = negocioMarca.ListarMarcas();
            listaCategoria = negocioCategoria.ListarCategorias();
            listaArticulo = negocioArticulo.Listar();

            NegocioImagen negocioImagen = new NegocioImagen();
            List<Imagen> listadoImagen = new List<Imagen>();
            listadoImagen = negocioImagen.ListarImagenes();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            Articulo actualId = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            if (pivot == seleccionado.Id)
            {

            }
            else
            {
                foreach (Articulo articulo in listaArticulo)
                {
                    if (articulo.Id == seleccionado.Id)
                    {
                        cmbArticulo.Text = articulo.Descripcion;
                        foreach (Marca item in listaMarca)
                        {
                            if (item.Id == articulo.IdMarcas)
                            {
                                cmbMarca.Text = item.Descripcion;
                            }
                        }
                        foreach (Categoria item in listaCategoria)
                        {
                            if (item.Id == articulo.IdCategorias)
                            {
                                cmbCategoria.Text = item.Descripcion;
                            }
                        }
                    }
                }
                maxImg = 0;
                contClick = 0;
                pivot = seleccionado.Id;
                List<Imagen> listadoImagenx = new List<Imagen>();
                

                try
                {
                    foreach (Imagen item in listadoImagen)
                    {
                        if (actualId.Id == seleccionado.Id)
                        {
                            pictureBoxImagenArticulo.Load(listadoImagen[seleccionado.Id].ImagenUrl);

                            /*listadoImagenx.Add(item);
                            maxImg++;*/
                        }
                    }
                    /*if (maxImg != 0)
                    {
                        pictureBoxImagenArticulo.Load(listadoImagen[seleccionado.Id].ImagenUrl);
                        //contClick++;
                    }
                    else
                    {
                        pictureBoxImagenArticulo.Load("https://cloudfront-us-east-1.images.arcpublishing.com/infobae/BLZJHTB27ZHUPKK3A7GXTMIEQA.jpg");
                    }*/

                }
                catch (Exception)
                {

                    MessageBox.Show("Problemas al cargar imagen, intente nuevamente");
                    pictureBoxImagenArticulo.Load("https://cloudfront-us-east-1.images.arcpublishing.com/infobae/BLZJHTB27ZHUPKK3A7GXTMIEQA.jpg");
                }
            }

        }

        private void dgvArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            imagenLoad();
        }
    }
}
            /*NegocionImagen imagenes = new NegocionImagen();
            listaImagen = imagenes.ListarImagenes();
            dgvArticulo.DataSource = listaImagen;
            cargarImagen(listaImagen[0].ImagenUrl);*/


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