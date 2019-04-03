using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioInventario.Modelo;
using ServicioInventario.ViewModel;

namespace ServicioInventario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Stock" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Stock.svc or Stock.svc.cs at the Solution Explorer and start debugging.
    public class Stock : IStock
    {
        public Contexto db = new Contexto();
        public bool CrearCategoria(Categoria categoria)
        {
            try
            {
                db.categorias.Add(categoria);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool CrearProducto(Productos productos)
        {
            try
            {
                db.productos.Add(productos);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Categoria DetalleCategoria(int identificador)
        {
            var categoria = db.categorias.Find(identificador);
            return categoria;
        }

        public Productos DetalleProducto(int identificador)
        {
            var producto = db.productos.Find(identificador);
            return producto;
        }

        public bool EditarCategoria(Categoria categoria)
        {
            try
            {
                db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarProducto(Productos productos)
        {
            try
            {
                db.Entry(productos).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarCategoria(int identificador)
        {
            try
            {
                var categoria = db.categorias.Find(identificador);
                db.categorias.Remove(categoria);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarProducto(int identificador)
        {
            try
            {
                var producto = db.productos.Find(identificador);
                db.productos.Remove(producto);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Inventario> Filtro(string busqueda)
        {
            var productosCategoria = (
                    from categoria in db.categorias
                    join producto in db.productos on categoria.Id_Categoria equals producto.Id_Categoria
                    select new Inventario()
                    {
                        Id_Producto = producto.Id_Producto,
                        Nombre = producto.Nombre,
                        Precio = producto.Precio,
                        StockInventario = producto.Stock,
                        NombreCategoria = categoria.Nombre,
                        Descripcion = categoria.Descripcion
                    }
                ).ToList();
            return productosCategoria.Where(x=>x.Nombre.Contains(busqueda)).ToList();
        }

        public List<Categoria> MostrarCategoria()
        {
            var categoria = db.categorias;
            return categoria.ToList();
        }

        public List<Inventario> MostrarInventario()
        {
            var productosCategoria = (
                    from categoria in db.categorias
                    join producto in db.productos on categoria.Id_Categoria equals producto.Id_Categoria
                    select new Inventario()
                    {
                        Id_Producto = producto.Id_Producto,
                        Nombre = producto.Nombre,
                        Precio = producto.Precio,
                        StockInventario = producto.Stock,
                        NombreCategoria = categoria.Nombre,
                        Descripcion = categoria.Descripcion
                    }
                ).ToList();
            return productosCategoria;
        }

        public List<Productos> MostrarProductos()
        {
            var producto = db.productos.ToList();
            return producto;
        }
    }
}
