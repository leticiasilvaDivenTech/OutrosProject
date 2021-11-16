using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos.Usuario;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Api.Controllers.Usuario
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioConroller : Controller
    {
        private readonly IApplicationServiceUsuario applicationServiceUsuario;

        public UsuarioConroller(IApplicationServiceUsuario applicationServiceUsuario)
        {
            this.applicationServiceUsuario = applicationServiceUsuario;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceUsuario.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceUsuario.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UsuarioDto usuarioDTO)
        {
            try
            {
                if (usuarioDTO == null)
                    return NotFound();


                applicationServiceUsuario.Add(usuarioDTO);
                return Ok("O Usuario foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UsuarioDto usuarioDTO)
        {
            try
            {
                if (usuarioDTO == null)
                    return NotFound();

                applicationServiceUsuario.Update(usuarioDTO);
                return Ok("O Usuario foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UsuarioDto usuarioDTO)
        {
            try
            {
                if (usuarioDTO == null)
                    return NotFound();

                applicationServiceUsuario.Remove(usuarioDTO);
                return Ok("O Usuario foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
