using Datos.EF.Repositorios;
using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Servicio.WebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        [System.Web.Http.Route("Usuarios")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Usuario> Obtener_Usuarios()
        {
            IRepositorio<Usuario> Repositorio = new Repositorio_Generico<Usuario>();
            IEnumerable<Usuario> Usuarios = Repositorio.ObtenerPorExpresion() as IEnumerable<Usuario>;
            return Usuarios;
        }

        [System.Web.Http.Route("Usuarios/{IDUsuario:int}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Obtener_Usuarios_Codigo(int IDUsuario)
        {
            IRepositorio<Usuario> Repositorio = new Repositorio_Generico<Usuario>();
            Usuario UsuarioEspecifico = Repositorio.ObtenerPorCodigo(IDUsuario);
            if (UsuarioEspecifico == null) return NotFound();
            return Ok(UsuarioEspecifico);
        }

        [System.Web.Http.Route("Acceso/{Usuario}/{Password}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Acceso(string Usuario, string Password)
        {
            IRepositorio<Usuario> Repositorio = new Repositorio_Generico<Usuario>();

            // Expression<Func<Usuario, bool>> Nombre = TbUsuario => TbUsuario.User == Usuario & TbUsuario.Password == Password;

            IEnumerable<Usuario> Usuarios = Repositorio.ObtenerPorExpresion(p => p.User == Usuario && p.Password == Password) as IEnumerable<Usuario>;
            if (Usuarios == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Usuarios);
            }
        }
    }
}