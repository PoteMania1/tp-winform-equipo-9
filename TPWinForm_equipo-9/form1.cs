using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            NegocioArticulo negocio = new NegocioArticulo();
            dgvArticulo.DataSource = negocio.Listar();


        }
       

}
}
