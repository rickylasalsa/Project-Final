using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class EmpleadoCreate
    {
        RecursosHumanosEntities db = new RecursosHumanosEntities();
        
        public void insertarEmpleado(empleado emplead)
        {
            db.empleado.Add(emplead);
            db.SaveChanges();
        }

        public List<empleado> ListaEmpleados()
        {
            return db.empleado.ToList();
        }
        
    }
}
