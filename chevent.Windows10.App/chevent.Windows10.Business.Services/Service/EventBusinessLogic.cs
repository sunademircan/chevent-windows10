using System;
using System.Collections.Generic;
using Autofac;
using chevent.Windows10.Business.Services.IService;
using chevent.Windows10.Data.Domain.Business;
using chevent.Windows10.Data.Domain.Entities;
using chevent.Windows10.Data.Repository.IRepository;
using chevent.Windows10.Data.Repository.Repository;
using chevent.Windows10.Infrastructure.Core.Extensions;

namespace chevent.Windows10.Business.Services.Service
{
    public partial class EventBusinessLogic : IEventBusinessLogic
    {
        private readonly IEventRepository _eventRepository;

        public EventBusinessLogic(IComponentContext components)
        {
            _eventRepository = components.Resolve<IEventRepository>();
        }

        partial void OnConstructor(IComponentContext components);

        public ServiceResult<List<EventEntity>> GetAllEvent()
        {
            var response = ServiceResult<List<EventEntity>>.Instance.ErroResult(ResponseCode.GenericError.ToInt());

            response.ResultValue = _eventRepository.GetAllEvent();
            if (String.IsNullOrEmpty(response.ResultValue.ToString()))
            {
                response.SuccessResult(response.ResultValue);
            }
            return response;
        }
    }
}
