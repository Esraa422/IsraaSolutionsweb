using System.Collections.Generic;
using IsraaApp.Core.Entities;

namespace IsraaApp.Service
{
    public interface IContactService
    {
        Contact GetById(int Id);
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetDeletedContacts();

        bool Save(Contact contact);
    }
}