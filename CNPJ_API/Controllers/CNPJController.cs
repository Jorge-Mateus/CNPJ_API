using CNPJ_Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CNPJ_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CNPJController : ControllerBase
    {
        private readonly IRoot _rootService;

        public CNPJController(IRoot rootService)
        {
            _rootService = rootService;
        }

        [HttpGet("busca/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCNPJ( string cnpj)
        {
            var response = await _rootService.BuscarCNPJ(cnpj);
            if (response.CodigoHttp == System.Net.HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetono);
            }
        }

      /*  [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AdcBuscarCNPJ(string cnpj)
        {
            try
            {
                var cnpjs = await _rootService.AdcBuscarCNPJ(cnpj);

                //if (cnpjs.ErroRetono == null) return NotFound("Não pode ser escrito null ou deixar em vazio, preencha corretamente!");

                if (cnpjs == null) return NoContent();

                return Ok(cnpjs);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar adicionar cnpj: {ex.Message}");
            }

        }*/

    }
}
