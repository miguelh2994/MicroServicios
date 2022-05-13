using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaServicios.Api.Libro2;
using TiendaServicios.Api.Libro2.Aplicacion;

namespace TiendaServicios.Api.Libro.Tests2
{
    public class MappingTest : Profile
    {
        public MappingTest()
        {
            CreateMap<LibreriaMaterial, LibroMaterialDto>();

        }
    }
}
