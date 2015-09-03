using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Cuestionario_Configuracion : EntityTypeConfiguration<Cuestionario>
    {
        public Cuestionario_Configuracion()
        {
            ToTable("Tbl_cuestionario"); 
            HasKey(k => k.IDCuestionario);
            Property(p => p.IDCuestionario).HasColumnName("cue_id").IsRequired();
            Property(p => p.IDUsuario).HasColumnName("usu_id").IsRequired();
            Property(p => p.Titulo).HasColumnName("cue_titulo").IsRequired();
            Property(p => p.Descripción).HasColumnName("cue_descripcion").IsRequired();
            Property(p => p.Estado).HasColumnName("cue_estado").IsRequired();
            Property(p => p.Abierto).HasColumnName("cue_abierto").IsRequired();
            Property(p => p.Realizado).HasColumnName("cue_realizado").IsRequired();
            Property(p => p.Hora_Emision).HasColumnName("cue_hora_emision").IsRequired();
            Property(p => p.Hora_Termino).HasColumnName("cue_hora_termino").IsRequired();
            Property(p => p.Dia_Emision).HasColumnName("cue_dia_emision").IsRequired();
            Property(p => p.Dia_Termino).HasColumnName("cue_dia_termino").IsRequired();
        }
    }
}
