using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaPesca.Models
{
	public class Imagenes
	{
		[Key]
		public int Id { get; set; }
		public string Imagen { get; set; }
		public string Nombre { get; set; }
		
		[ForeignKey("Hoteles")]
		public int? HotelId { get; set; }
		
		[ForeignKey("Habitaciones")]
		public int? HabitacionId { get; set; }
		
		[ForeignKey("Cracteristicas")]
		public int? ServicioId { get; set; }
		
		[ForeignKey("Blog")]
		public int? BlogId { get; set; }
		public bool? Activo { get; set; }
	}
}
