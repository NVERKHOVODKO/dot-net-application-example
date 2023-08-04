using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

public interface IOrderAnalyticService
{
    Task<int> GetAmountByCompany(Guid companyId);
    Task<int> GetQuantityByCompany(Guid companyId);
    Task<Dictionary<Guid, LeadModel>> SortOrderLeadsByCompany(Guid companyId);
}