using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Pregunta_Configuracion : EntityTypeConfiguration<Pregunta>
    {
        public Pregunta_Configuracion()
        {
            ToTable("Tbl_pregunta");
            HasKey(k => k.IDPregunta);
            Property(p => p.IDPregunta).HasColumnName("pre_id").IsRequired();
            Property(p => p.IDCuestionario).HasColumnName("cue_id").IsRequired();
            Property(p => p.Descripción).HasColumnName("pre_descripcion").IsRequired();
            Property(p => p.Estado).HasColumnName("pre_estado").IsRequired();
        }
    }
}
