using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;



namespace Repository
{
    public class CompanyRepository : ICompanyRepository

    {
        private CompanyAgentContext dbContext;

        public CompanyRepository(CompanyAgentContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Company> getCompanyByID(int id)
        {
            return await dbContext.Companys.FindAsync(id);
        }

        public async Task<IEnumerable<Company>> getAllCompanys()
        {
            return await dbContext.Companys.ToListAsync();

        }
        public async Task<Company> addCompany(Company company)
        {
            await dbContext.Companys.AddAsync(company);
            await dbContext.SaveChangesAsync();
            return company;

        }

        public async Task updateCompany(Company company)
        {
            dbContext.Companys.Update(company);
            await dbContext.SaveChangesAsync();
        }
        public async Task deleteCompany(Company company)
        {
            dbContext.Companys.Remove(company);
            await dbContext.SaveChangesAsync();
        }

    
    }
}
