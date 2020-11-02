using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RegistroMS //Registro de materia seleccionada
    {
        public DataTable registro = new DataTable();

        public RegistroMS()
        {
            registro.TableName = "RegistroTemporal";
            registro.Columns.Add("Materia", typeof(string));

            if (!System.IO.File.Exists("RTMA.xml"))
            {
                registro.WriteXml("RTMA.xml");
            }
            registro.ReadXml("RTMA.xml");
        }

        public void ActivarRegistro(string materia)
        {
            registro.Rows.Add();
            registro.Rows[0]["Materia"] = materia;
            registro.WriteXml("RTMA.xml");
        }

        public string Nombre()
        {
            string materiaActiva = registro.Rows[0]["Materia"].ToString();
            return materiaActiva;
        }
        
    }
}
