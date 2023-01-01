using System.Collections.Generic;
using IsraaApp.Core.Entities;

namespace IsraaApp.Service
{
    public interface IPostTagService
    {
        bool Save( string tagName);
        bool Delete(string tagName);

        bool Save(int postId, string tagName);
        bool Delete(int postId, string tagName);

        PostTag GetByName(string tagName);

        IEnumerable<PostTag> GetAllTags();
        IEnumerable<PostTag> GetTagsByPostId(int postId);
    }
}