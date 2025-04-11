using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGestionResiduos.Domain.Entities
{
    public class RecoleccionDTO
    {
        public RecoleccionDTO()
        {
            Fecha = DateTime.Now;
            PesoRecolectado = 0;
            TipoResiduo = ""; 
            Observaciones = ""; 
        }

        
