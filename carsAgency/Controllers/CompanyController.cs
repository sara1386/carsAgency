using Microsoft.AspNetCore.Mvc;
 using Entities;
    using Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carsAgency.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService companyService;
        private Company res;


        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IEnumerable<Company>> GetAll()
        {
            IEnumerable<Company> res = await companyService.getAllCompanys();
            return res;
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {
            res = await companyService.getCompanyByID(id);
            return res;
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task Post([FromBody] Company company)
        {
            res = await companyService.addCompany(company);


        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Company company)
        {
            await companyService.updateCompany(company);
            return Ok();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Company company)
        {
            await companyService.deleteCompany(company);
            return Ok();


        }
    }
}