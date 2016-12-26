using System.Collections.Generic;

namespace iSeeker2017.Models
{
    public interface IEventRepository
    {
        void Add(Event evt);
        IEnumerable<Event> GetAll();
        Event Find(int ID);
        Event Remove(int ID);
        void Update(Event evt);
    }
}
