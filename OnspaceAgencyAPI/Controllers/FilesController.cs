using Microsoft.AspNetCore.Mvc;
using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Files.Handlers;

namespace OnspaceAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFilesHandler _FilesHandler;
        public FilesController(IFilesHandler FilesHandler)
        {
            _FilesHandler = FilesHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _FilesHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _FilesHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FilesDto dto)
        {
            try
            {
                var entityToCreate = await _FilesHandler.Create(dto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] FilesDto dto)
        {
            try
            {
                await _FilesHandler.Update(dto);
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _FilesHandler.Delete(id);
            return Ok();
        }
    }
}
