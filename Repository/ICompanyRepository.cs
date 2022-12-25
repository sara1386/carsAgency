using Entities;

namespace Repository
{
    public interface ICompanyRepository
    {
        Task deleteCompany(Company Company);
        Task<IEnumerable<Company>> getAllCompanys();
        Task<Company> getCompanyByID(int id);
        Task updateCompany(Company Company);
        Task<Company> addCompany(Company company);
    }
}