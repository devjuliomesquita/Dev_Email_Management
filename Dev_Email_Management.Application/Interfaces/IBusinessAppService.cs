using Dev_Email_Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Application.Interfaces
{
    public interface IBusinessAppService : IAppServiceBase<Business>
    {
        IEnumerable<Business> GetByName(string name);
        IEnumerable<Business> BusinessEspec(IEnumerable<Business> businesses);
    }
}
