using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Business
{
    public class BProducto
    {
        private DProducto DProducto = null;
        public List<Producto> Listar(int IdProducto)
        {
            List<Producto> productos = null;
            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return categorias;
        }
        public bool Insertar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Insertar(categoria);
            }
            catch (Exception ex)
            {
                // Escribir en el log
                result = false;
            }
            return result;
        }
        public bool Actualizar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Actualizar(categoria);
            }
            catch (Exception ex)
            {
                // Escribir en el log
                result = false;
            }
            return result;
        }
        public bool Eliminar(int IdCategoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Eliminar(IdCategoria);
            }
            catch (Exception ex)
            {
                // Escribir en el log
                result = false;
            }
            return result;
        }
    }
}