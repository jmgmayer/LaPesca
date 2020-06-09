using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaPesca.Models
{
	public class HotelesHabitacionesCaracteristicas
	{
		[Key]
		public int Id { get; set; }
		
		[ForeignKey("Hoteles")]
		public int HotelId { get; set; }
		
		[ForeignKey("Habitaciones")]
		public int? HabitacionId { get; set; }

		[ForeignKey("Cracteristicas")]
		public int CaracteristicaId { get; set; }
		public bool Activo { get; set; }
	}
}
