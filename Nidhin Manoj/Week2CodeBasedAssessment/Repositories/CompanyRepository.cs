
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.IO;
using Week2CodeBasedAssessment.Model;

namespace Week2CodeBasedAssessment.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public static List<Company> companies = new List<Company>()
        {
            new Company() {CompanyId=1,Name="TCS",City="Trivandrum",Address="Tcs Technopark"},
            new Company() {CompanyId=2,Name="Infosys",City="Eranakulam",Address="Infosys Infopark"}
        };

      

        public List<Company> GetAll()
        {
            return companies;
        }



        public List<Company> GetCompaniesByCity(string City)
        {
            try
            {
                var companieslist = new List<Company>();
                foreach (var c in companies)
                {
                    if (c.City == City)
                    {
                        companieslist.Add(c);
                       
                    }
                }
                return companieslist;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Company GetCompanyById(int companyId)
        {
            
                try
                {
                    foreach (var company in companies)
                    {
                        if (company.CompanyId == companyId)
                            return company;
                    }
                    return null;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    
}

