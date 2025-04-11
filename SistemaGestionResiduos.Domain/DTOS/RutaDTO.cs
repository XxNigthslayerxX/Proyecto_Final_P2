using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaGestionResiduos.Domain.Entities
{
    public class RutaDTO
    {
        public RutaDTO()
        {
            Contenedores = new List<Contenedor>();
            Nombre = string.Empty;
            Descripcion = string.Empty;
            DiasServicio = string.Empty;
            HoraInicio = TimeSpan.Zero;
            HoraFin = TimeSpan.Zero;
            Activo = true;
        }

        
}
