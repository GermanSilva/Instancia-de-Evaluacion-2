using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ListaMaterias
    {
        public DataTable Lista = new DataTable();

        public ListaMaterias()
        {
            Lista.TableName = "Materias";
            Lista.Columns.Add("Nombre", typeof(String));
            Lista.Columns.Add("A", typeof(Int32));
            Lista.Columns.Add("R", typeof(Int32));
            Lista.Columns.Add("G", typeof(Int32));
            Lista.Columns.Add("B", typeof(Int32));

            if (!System.IO.File.Exists("Materias.xml"))
            {
                Lista.WriteXml("Materias.xml");
            }
            Lista.ReadXml("Materias.xml");
        }

        public void Guardar(String nombre, int a, int r, int g, int b)
        {
            Lista.Rows.Add();
            Lista.Rows[Lista.Rows.Count - 1]["Nombre"] = nombre;
            Lista.Rows[Lista.Rows.Count - 1]["A"] = a;
            Lista.Rows[Lista.Rows.Count - 1]["R"] = r;
            Lista.Rows[Lista.Rows.Count - 1]["G"] = g;
            Lista.Rows[Lista.Rows.Count - 1]["B"] = b;
            Lista.WriteXml("Materias.xml");
        }

        public bool NoCoincide(string nombre) 
        {
            bool noCoincide = true;

            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                if (Lista.Rows[i]["Nombre"].ToString() == nombre)
                {
                    noCoincide = false;
                    i = Lista.Rows.Count;
                }
            }

            return noCoincide;
        }

        public bool Editar(string nombre, string nuevo, int a, int r, int g, int b) 
        {
            TablaNotas temp = new TablaNotas();
            bool cambioExitoso = true;


            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                if (Lista.Rows[i]["Nombre"].ToString() == nombre)
                {
                    for (int j = 0; j < Lista.Rows.Count; j++)
                    {
                        if (Lista.Rows[j]["Nombre"].ToString() == nuevo && nombre!=nuevo)
                        {
                            j = Lista.Rows.Count;
                            cambioExitoso = false;
                        }

                    }
                    if (cambioExitoso==true)
                    {
                        Lista.Rows[i]["Nombre"] = nuevo;
                        Lista.Rows[i]["A"] = a;
                        Lista.Rows[i]["R"] = r;
                        Lista.Rows[i]["G"] = g;
                        Lista.Rows[i]["B"] = b;
                        Lista.WriteXml("Materias.xml");

                        if (!System.IO.File.Exists(nombre + ".xml"))
                        {
                            temp.tabla.WriteXml(nuevo + ".xml");
                        }
                        else
                        {
                            temp.tabla.ReadXml(nombre + ".xml");
                            System.IO.File.Delete(nombre + ".xml");
                            temp.tabla.WriteXml(nuevo + ".xml");
                        }

                    }
                    i = Lista.Rows.Count;
                }
            }

            return cambioExitoso;
        }


        public bool Eliminar(string nombre)
            {
            bool confirmado = false;
            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                if (nombre==Lista.Rows[i]["Nombre"].ToString())
                {
                    Lista.Rows.RemoveAt(i);
                    Lista.WriteXml("Materias.xml");
                    if (System.IO.File.Exists(nombre+".xml"))
                    {
                        System.IO.File.Delete(nombre + ".xml");
                    }
                    confirmado = true;
                }
            }
            return confirmado;
            }
    }
    }
