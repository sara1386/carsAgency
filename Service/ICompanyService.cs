using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service
{
    public interface ICompanyService
    {
        Task<Company> addCompany(Company company);
        Task deleteCompany(Company company);
        Task<IEnumerable<Company>> getAllCompanys();
        Task<Company> getCompanyByID(int id);
        Task updateCompany(Company company);
    }
}
