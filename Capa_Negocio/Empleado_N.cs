using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Empleado_N
    {
        EmpleadoCreate ejecutar = new EmpleadoCreate();

        public void guardarEmpleado(empleado empleado)
        {
            ejecutar.insertarEmpleado(empleado);
        }

        public List<empleado> mostrarEmpleado()
        {
            return ejecutar.ListaEmpleados();
        }
    }
}
