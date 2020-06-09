using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace LaPesca.Models
{
    public class DataContextLP : DbContext

    {

        public DataContextLP(DbContextOptions<DataContextLP> options) : base(options)
        {

        }

        public DbSet<Blog> Blog {get; set;}
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Cracteristicas> Cracteristicas { get; set; }
        public DbSet<Habitaciones> Habitaciones { get; set; }
        public DbSet<Hoteles> Hoteles { get; set; }
        public DbSet<HotelesHabitacionesCaracteristicas> HotelesHabitacionesCaracteristicas { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<ServiciosExtras> ServiciosExtras { get; set; }
        public DbSet<Suscripciones> Suscripciones { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }
}
