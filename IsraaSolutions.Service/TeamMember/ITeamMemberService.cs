using System.Collections.Generic;
using IsraaApp.Core.Entities;

namespace IsraaApp.Service
{
    public interface ITeamMemberService
    {
        IEnumerable<TeamMember> GetTeamMembers();
        TeamMember GetById(int id);
        bool Delete(TeamMember team);
        bool Insert(TeamMember team);
        bool Update(TeamMember team);
    }
}