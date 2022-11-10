using VirtoCommerce.Contracts.Data.Repositories.Common;

namespace VirtoCommerce.Contracts.Data.Repositories
{
    public class ContractRepository : ContractRepositoryCommon<ContractDbContext>
    {
        public ContractRepository(ContractDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
