using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Modelo;

namespace WebApplication3.Aplicacion
{
    public class AutorDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string AutorLibroGuid { get; set; }

    }
}
