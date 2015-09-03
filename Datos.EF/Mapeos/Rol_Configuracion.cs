using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Rol_Configuracion : EntityTypeConfiguration<Rol>
    {
        public Rol_Configuracion()
        {
            ToTable("Tbl_rol");
            HasKey(k => k.IDRol);
            Property(p => p.IDRol).HasColumnName("rol_id").IsRequired();
            Property(p => p.Descripcion).HasColumnName("rol_descripcion").IsRequired();
        } 
    }
}
