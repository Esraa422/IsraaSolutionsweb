using Microsoft.AspNet.Identity;
using IsraaApp.Core.Entities;

namespace IsraaApp.Service
{
    public class ApplicationRoleService : RoleManager<ApplicationRole>
    {
        #region Ctor

        public ApplicationRoleService(IRoleStore<ApplicationRole> store)
            : base(store)
        {
        }

        #endregion Ctor
    }
}