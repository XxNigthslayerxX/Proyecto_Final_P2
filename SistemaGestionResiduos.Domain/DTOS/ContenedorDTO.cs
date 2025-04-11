using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGestionResiduos.Domain.Entities
{
    public class ContenedorDTO
    {
        public ContenedorDTO()
        {
            Recolecciones = new List<Recoleccion>();
            UltimaRecoleccion = DateTime.Now;
            Ubicacion = string.Empty;
            TipoResiduo = string.Empty;
            Capacidad = 0;
            NivelLlenado = 0;
            RutaId = 0;
        }

        
