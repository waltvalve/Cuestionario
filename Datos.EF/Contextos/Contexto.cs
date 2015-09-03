using Datos.EF.Mapeos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Contextos
{
    public class Contexto : DbContext
    {
        //public Contexto(string as_conexion) 
        //    : base(as_conexion)
        //{}
        public Contexto()
            : base("Conexion_SQL")
        {
        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Detalle_Cuestionario> Detalle_Cuestionarios { get; set; }
        public DbSet<Cuestionario> Cuestionarios { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Rol_Configuracion());
            modelBuilder.Configurations.Add(new Usuario_Configuracion());
            modelBuilder.Configurations.Add(new Cuestionario_Configuracion());
            modelBuilder.Configurations.Add(new Detalle_Cuestionario_Configuracion());
            modelBuilder.Configurations.Add(new Pregunta_Configuracion());
            modelBuilder.Configurations.Add(new Alternativa_Configuracion());
            base.OnModelCreating(modelBuilder);
        }
    }
}
