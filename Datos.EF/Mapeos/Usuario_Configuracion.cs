using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Mapeos
{
    public class Usuario_Configuracion : EntityTypeConfiguration<Usuario>
    {
        public Usuario_Configuracion()
        {
            ToTable("Tbl_usuario");
            HasKey(k => k.IDUsuario);
            Property(p => p.IDUsuario).HasColumnName("usu_id").IsRequired();
            Property(p => p.IDRol).HasColumnName("rol_id").IsRequired();
            Property(p => p.Apellido).HasColumnName("usu_apellido").IsRequired();
            Property(p => p.Nombre).HasColumnName("usu_nombre").IsRequired();
            Property(p => p.User).HasColumnName("usu_usuario").IsRequired();
            Property(p => p.Password).HasColumnName("usu_password").IsRequired();
            Property(p => p.Estado).HasColumnName("usu_estado").IsRequired();
            Property(p => p.Foto).HasColumnName("usu_foto").IsRequired();
        }
    }
}
