using Microsoft.AspNetCore.Mvc;
using OnspaceAgency.Application.Portfolio.Handlers;

namespace OnspaceAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioHandler _PortfolioHandler;
        public PortfolioController(IPortfolioHandler PortfolioHandler)
        {
            _PortfolioHandler = PortfolioHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _PortfolioHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _PortfolioHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PortfolioDto dto)
        {
            try
            {
                var entityToCreate = await _PortfolioHandler.Create(dto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PortfolioDto dto)
        {
            try
            {
                await _PortfolioHandler.Update(dto);
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
            await _PortfolioHandler.Delete(id);
            return Ok();
        }
    }
}
