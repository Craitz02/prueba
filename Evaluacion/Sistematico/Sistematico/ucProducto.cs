using Sistematico.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class ucProducto : UserControl
    {
        public Producto Producto { get; set; }
        public ucProducto()
        {
            InitializeComponent();
        }

        private void ucProducto_Load(object sender, EventArgs e)
        {
            pbImagenProducto.Image = Image.FromFile(Producto.Imagen);
            lblID.Text =Producto.Id+"."+Producto.Nombre;
            label2.Text = "("+Producto.Marca.ToString()+", "+Producto.Modelo.ToString()+")";
            textBox1.Text = Producto.Descripcion;
            //label1.Text = Producto.Descripcion;
            //lblMarca.Text = lblMarca.Text +" "+ Producto.Marca.ToString();
            //lblModelo.Text = lblModelo.Text +" "+ Producto.Modelo.ToString();
            lblExistencia.Text = lblExistencia.Text +" "+ Producto.Existencia;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LklblActu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.Productos = ;
            //frmProducto.dgvP = dgvCatalogo;
            frmProducto.LoadProducto(Producto);
            frmProducto.editable = true;
            _ = frmProducto.ShowDialog();
        }
    }
}
