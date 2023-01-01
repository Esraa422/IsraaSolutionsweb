using System.Collections.Generic;
using IsraaApp.Core.Entities; 

namespace IsraaApp.Service
{
    public interface ISubscriberService
    {
        Subscriber GetById(int id);
        IEnumerable<Subscriber> GetSubscribers(); 
        bool Save(Subscriber socialNetwork);
        bool Delete(Subscriber subscriber);
        Subscriber GetByEmail(string email);
    }
}