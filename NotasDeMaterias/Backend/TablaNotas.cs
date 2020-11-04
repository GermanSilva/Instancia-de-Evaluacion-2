using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class TablaNotas
    {
        public DataTable tabla = new DataTable();
        DataTable nuevoOrden = new DataTable();

        public TablaNotas()
        {
            tabla.TableName = "Notas";
            tabla.Columns.Add("Detalles", typeof(string));
            tabla.Columns.Add("Fecha", typeof(string));

            nuevoOrden.TableName = "Notas";
            nuevoOrden.Columns.Add("Detalles", typeof(string));
            nuevoOrden.Columns.Add("Fecha", typeof(string));
        }


        public DataTable CargarTabla(string nombre) 
        {
            if (!System.IO.File.Exists(nombre + ".xml"))
            {
                tabla.WriteXml(nombre + ".xml");
            }
            tabla.ReadXml(nombre + ".xml");
            return tabla;
        }

        public void AñadirNota(string detalle, string fecha, string nombre) 
        {
            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1]["Detalles"] = detalle;
            tabla.Rows[tabla.Rows.Count - 1]["Fecha"] = fecha;
            tabla.WriteXml(nombre + ".xml");
        }

        public void GuardarNota(int index, string detalle, string fecha, string nombre) 
        {
            tabla.Rows[index]["Detalles"] = detalle;
            tabla.Rows[index]["Fecha"] = fecha;
            tabla.WriteXml(nombre + ".xml");
        }

        public void EliminarNota(int indice, string nombre) 
        {
            tabla.Rows.RemoveAt(indice);
            tabla.WriteXml(nombre + ".xml");
        }

        public void ReordenarNotas(string detalle, string fecha) 
        {
            nuevoOrden.Rows.Add();
            nuevoOrden.Rows[nuevoOrden.Rows.Count - 1]["Detalles"] = detalle;
            nuevoOrden.Rows[nuevoOrden.Rows.Count - 1]["Fecha"] = fecha;
        }

        public void FinReorden(string nombre) 
        {
            nuevoOrden.WriteXml(nombre + ".xml");
            nuevoOrden.Rows.Clear();
            tabla.Rows.Clear();
            tabla.ReadXml(nombre + ".xml");
        }
    }
}
