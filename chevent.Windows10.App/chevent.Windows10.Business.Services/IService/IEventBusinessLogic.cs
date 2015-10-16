using System.Collections.Generic;
using chevent.Windows10.Data.Domain.Business;
using chevent.Windows10.Data.Domain.Entities;

namespace chevent.Windows10.Business.Services.IService
{
    public interface IEventBusinessLogic
    {
        ServiceResult<List<EventEntity>> GetAllEvent();
    }
}
