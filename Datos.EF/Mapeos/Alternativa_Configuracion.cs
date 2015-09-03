using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Alternativa_Configuracion : EntityTypeConfiguration<Alternativa>
    {
        public Alternativa_Configuracion()
        {
            ToTable("Tbl_alternativa");
            HasKey(k => k.IDPregunta);
            Property(p => p.IDAlternativa).HasColumnName("alt_id").IsRequired();
            Property(p => p.IDPregunta).HasColumnName("pre_id").IsRequired();
            Property(p => p.Descripción).HasColumnName("alt_descripcion").IsRequired();
            Property(p => p.Respuesta).HasColumnName("alt_respuesta").IsRequired();
        }
    }
}
