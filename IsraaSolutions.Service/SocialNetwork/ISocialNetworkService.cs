using System.Collections.Generic;
using IsraaApp.Core.Entities; 

namespace IsraaApp.Service
{
    public interface ISocialNetworkService
    {
        SocialNetwork GetById(int id);
        IEnumerable<SocialNetwork> GetByEntity(int entityId, string entityName);
        IEnumerable<SocialNetwork> GetByEntity(string entityId, string entityName);

        bool Delete(SocialNetwork socialNetwork);
        bool Update(SocialNetwork socialNetwork);
        bool Insert(SocialNetwork socialNetwork);
        bool Save(SocialNetwork socialNetwork);
    }
}