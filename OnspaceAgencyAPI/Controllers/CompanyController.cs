using Microsoft.AspNetCore.Mvc;
using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Company.Handlers;

namespace OnspaceAgencyAPI.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class CompanyController : ControllerBase
        {
            private readonly ICompanyHandler _CompanyHandler;
            public CompanyController(ICompanyHandler CompanyHandler)
            {
                _CompanyHandler = CompanyHandler;
            }


            [HttpGet("{id}")]
            public async Task<IActionResult> Get([FromRoute] int id)
            {
                var entityToReturn = await _CompanyHandler.GetById(id);

                if (entityToReturn == null)
                    return NotFound();

                return Ok(entityToReturn);
            }
            [HttpGet]
            public async Task<IActionResult> GetAll([FromQuery] int top = 50)
            {
                var entitiesToReturn = await _CompanyHandler.Get(top);

                if (entitiesToReturn == null)
                    return NotFound();

                return Ok(entitiesToReturn);
            }

            [HttpPost]
            public async Task<IActionResult> Create([FromBody] CompanyDto dto)
            {
                try
                {
                    var entityToCreate = await _CompanyHandler.Create(dto);
                    return Ok(entityToCreate);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                    throw;
                }
            }

            [HttpPut]
            public async Task<IActionResult> Put([FromBody] CompanyDto dto)
            {
                try
                {
                    await _CompanyHandler.Update(dto);
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
                await _CompanyHandler.Delete(id);
                return Ok();
            }
        }
    
}
