using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2CodeBasedAssessment.Repositories;

namespace Week2CodeBasedAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController()
        {
            companyRepository = new CompanyRepository();
        }
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Company> companies = companyRepository.GetAll();
                return StatusCode(200,companies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetCompanyByCity/{city}")]
        public IActionResult GetCompanyByCity(string city)
        {
            try
            {

               List <Company> company = companyRepository.GetCompaniesByCity(city);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetCompanyId/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Company company = companyRepository.GetCompanyById(id);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
