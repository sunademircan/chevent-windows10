using System.Collections.Generic;
using chevent.Windows10.Data.Domain.Entities;

namespace chevent.Windows10.Data.Repository.IRepository
{
    public interface IEventRepository
    {
        List<EventEntity> GetAllEvent();

        EventEntity GetAEvent();
    }
}
