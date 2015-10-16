using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using chevent.Windows10.Data.Domain.Entities;
using chevent.Windows10.Data.Repository.IRepository;

namespace chevent.Windows10.Data.Repository.Repository
{
    public class EventRepository : IEventRepository
    {

        private const string eventKey = "item";
        private const string nameKey = "event_name";


        private static List<EventEntity> events;

        public EventRepository()
        { }

        public EventEntity GetAEvent()
        {
            if (events == null)
            {
                LoadEvents();
            }
            return events.FirstOrDefault();
        }

        public List<EventEntity> GetAllEvent()
        {
            if (events == null)
            {
                LoadEvents();
            }
            return events;
        }

        private async void LoadEvents()
        {
            const string BaseUri = "http://apifn.com/api/v1/events/";

            HttpClient client = new HttpClient();
            string jsonString = await client.GetStringAsync(BaseUri);

            JsonObject jsonObject = JsonObject.Parse(jsonString);

            foreach (IJsonValue jsonValue in jsonObject.GetNamedArray(eventKey, new JsonArray()))
            {
                if (jsonValue.ValueType == JsonValueType.Object)
                {
                    events = new List<EventEntity>()
                    {
                        new EventEntity()
                        {
                            Name = jsonObject.GetNamedString(nameKey)
                        }
                    };

                }
            }
        }       
    }
}
