using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                //gvCategoria.DataSource = ws.MostrarCategoria();
                //gvProductos.DataSource = ws.MostrarProductos();
            }
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                var datos = new WcfServicioInventario.Categoria()
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };
                ws.CrearCategoria(datos);
            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                var datos = new WcfServicioInventario.Categoria()
                {
                    Id_Categoria = Convert.ToInt32(txtIdCategoria.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };
                if (ws.EditarCategoria(datos))
                {
                    MessageBox.Show("Datos actualizados correctamente", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar datos","Error");
                }                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                int id = Convert.ToInt32(txtIdCategoria.Text);
                if (ws.EliminarCategoria(id))
                {
                    MessageBox.Show("Datos actualizados correctamente", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar datos", "Error");
                }
            }
        }

        private void btnCrearPro_Click(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                var datos = new WcfServicioInventario.Productos()
                {
                    Nombre = txtNombre.Text,
                    Precio = Convert.ToDouble(TxtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    Id_Categoria = Convert.ToInt32(txtIdCateg)
                    
                };
                ws.CrearProducto(datos);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            //{
            //    var datos = new WcfServicioInventario.Productos()
            //    {
            //        Nombre = txtNombre.Text,
            //        Precio = Convert.ToDouble(TxtPrecio.Text),
            //        Stock = Convert.ToInt32(txtStock.Text),
            //        Id_Categoria = Convert.ToInt32(txtIdCateg)

            //    };
            //    if (ws.EditarProducto(datos)
            //    {
            //        MessageBox.Show("Datos actualizados correctamente", "Mensaje");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ocurrió un error al actualizar datos", "Error");
            //    }
            //}
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            using (WcfServicioInventario.StockClient ws = new WcfServicioInventario.StockClient())
            {
                int id = Convert.ToInt32(txtIdProducto.Text);
                if (ws.EliminarProducto(id))
                {
                    MessageBox.Show("Datos actualizados correctamente", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar datos", "Error");
                }
            }
        }
    }
}
