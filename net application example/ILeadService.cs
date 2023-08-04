using Models;
using System;
using System.Threading.Tasks;

public interface ILeadService
{
    Task<Guid> Create(LeadModel lead);
    Task<LeadModel> Get(Guid id);
    Task Update(LeadModel lead);
    Task Delete(Guid leadId);
}