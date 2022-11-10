using VirtoCommerce.Contracts.Data.Repositories.Common;

namespace VirtoCommerce.Contracts.Data.Repositories.MySql
{
    public class ContractMySqlRepository : ContractRepositoryCommon<ContractMySqlDbContext>
    {
        public ContractMySqlRepository(ContractMySqlDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
