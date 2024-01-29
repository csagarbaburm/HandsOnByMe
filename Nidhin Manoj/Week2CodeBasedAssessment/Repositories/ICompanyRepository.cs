namespace Week2CodeBasedAssessment.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAll();

        List<Company> GetCompaniesByCity(string subject);

        Company GetCompanyById(int companyId);

       
    }
}
