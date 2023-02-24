﻿using TareasMVP.Models;

namespace TareasMVP.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task Borrar(string ruta, string contenedor);
        Task<AlmacenarArchivoResultado[]> Almacenar(string contenedor, 
            IEnumerable<IFormFile> archivos);
    }
}
