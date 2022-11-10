using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VirtoCommerce.Contracts.Data.Repositories.MySql
{
    public class DesignTimeMySqlDbContextFactory : IDesignTimeDbContextFactory<ContractMySqlDbContext>
    {
        public ContractMySqlDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContractMySqlDbContext>();

            builder.UseMySql("server=localhost;user=root;password=virto;database=VirtoCommerce3_test1;", new MySqlServerVersion(new Version(5, 7)));
            return new ContractMySqlDbContext(builder.Options);
        }
    }
}
