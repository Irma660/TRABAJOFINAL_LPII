using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Común
{
    public class AtributtesEstudiantes
    {
        private string id;
        private string primer_nombre;
        private string segundo_nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private string telefono;
        private string nivel;
        private string grado;
        private string seccion;
        private string direccion;
        private string sexo;
        private string fecha_nac;
        private string observaciones;
        private string dni;

        public string Id { get => id; set => id = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Seccion { get => seccion; set => seccion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}
