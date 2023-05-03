using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Domain.Interfaces.Service;


namespace Dev_Email_Management.Domain.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly IBusinessService _businessService;

        public BusinessService(
            IBusinessService businessService)
        {
            _businessService = businessService;
        }

        public IEnumerable<Business> BusinessEspec(IEnumerable<Business> businesses)
        {
            return businesses.Where(b => b.BusinessEspec(b));
        }

        public IEnumerable<Business> GetByName(string name)
        {
            return _businessService.GetByName(name);
        }
    }
}
