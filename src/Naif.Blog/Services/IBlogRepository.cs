﻿using Naif.Blog.Models;
using System.Collections.Generic;

namespace Naif.Blog.Services
{
    public interface IBlogRepository
    {
        IEnumerable<Models.Blog> GetBlogs();

        Dictionary<string, int> GetCategories(string blogId);

        Dictionary<string, int> GetTags(string blogId);

        void SaveBlogs(IEnumerable<Models.Blog> blogs);

        string SaveMedia(string blogid, MediaObject media);
    }
}
