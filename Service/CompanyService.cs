using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;
//using Controllers;

namespace Service
{

    public class CompanyService : ICompanyService
    {
        private ICompanyRepository companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public async Task<Company> getCompanyByID(int id)
        {
            return await companyRepository.getCompanyByID(id);
        }

        public async Task<IEnumerable<Company>> getAllCompanys()
        {
            return await companyRepository.getAllCompanys();
        }
        public async Task<Company> addCompany(Company company)
        {
            return await companyRepository.addCompany(company);
        }

        public async Task updateCompany(Company company)
        {
            await companyRepository.updateCompany(company);
        }
        public async Task deleteCompany(Company company)
        {
            await companyRepository.deleteCompany(company);
        }
    }
}
    
