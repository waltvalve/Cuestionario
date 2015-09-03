using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Detalle_Cuestionario_Configuracion : EntityTypeConfiguration<Detalle_Cuestionario>
    {
        public Detalle_Cuestionario_Configuracion()
        {
            ToTable("Tbl_detalle_cuestionario");
            HasKey(k => k.IDDetalle_Cuestionario);
            Property(p => p.IDDetalle_Cuestionario).HasColumnName("det_id").IsRequired();
            Property(p => p.IDCuestionario).HasColumnName("cue_id").IsRequired();
            Property(p => p.IDUsuario).HasColumnName("usu_id").IsRequired();
        }
    }
}
