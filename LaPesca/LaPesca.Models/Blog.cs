﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaPesca.Models
{
    public class Blog
    {
		[Key]
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descripcion { get; set; }
		public string Post { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string Tipo { get; set; }
		public string Categoria { get; set; }
		public string Video { get; set; }
		public string Imagen { get; set; }
		public int Consultas { get; set; }
		public string Tags { get; set; }
		public string MetaKeys { get; set; }
		
		[ForeignKey("Usuarios")]
		public int? UsuarioId { get; set; }
		public bool Activo { get; set; }
		
		[ForeignKey("Hoteles")]
		public int? HotelId { get; set; }
		
		[ForeignKey("ServiciosExtras")]
		public int? ServicioId { get; set; }
		
		[ForeignKey("Habitaciones")]
		public int HabitacionId { get; set; }
	}
}
