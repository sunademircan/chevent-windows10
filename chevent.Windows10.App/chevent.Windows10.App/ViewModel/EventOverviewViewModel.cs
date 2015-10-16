using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chevent.Windows10.Business.Services.IService;
using chevent.Windows10.Data.Domain.Entities;
using chevent.Windows10.Data.Repository.Repository;
using chevent.Windows10.Infrastructure.Core.Extensions;

namespace chevent.Windows10.App.ViewModel
{
    public class EventOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IEventBusinessLogic eventBusinessLogic;

        private void RaisePropertyChanged(string propertyName)
        {
            if (String.IsNullOrEmpty(PropertyChanged.ToString()))
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public EventOverviewViewModel(IEventBusinessLogic eventBusinessLogic)
        {
            this.eventBusinessLogic = eventBusinessLogic;

            LoadData();
        }

        private void LoadData()
        {
            EventItemEntitity entry = new EventItemEntitity();
            entry.Events = eventBusinessLogic.GetAllEvent().ResultValue.ToObservableCollection();
        }

        
    }
}
