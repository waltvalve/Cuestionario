using Datos.EF.Repositorios;
using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Servicio.WebAPI.Controllers
{
    public class RolController : ApiController
    {
        [System.Web.Http.Route("Roles")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Rol> Obtener_Roles()
        {
            IRepositorio<Rol> Repositorio = new Repositorio_Generico<Rol>();
            IEnumerable<Rol> Roles = Repositorio.ObtenerPorExpresion() as IEnumerable<Rol>;
            return Roles;
        }
        [System.Web.Http.Route("Roles/{IDRol:int}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Obtener_Roles_Codigo(int IDRol)
        {
            IRepositorio<Rol> Repositorio = new Repositorio_Generico<Rol>();
            Rol RolEspecifico = Repositorio.ObtenerPorCodigo(IDRol);
            if (RolEspecifico == null) return NotFound();
            return Ok(RolEspecifico);
        }
    }
}