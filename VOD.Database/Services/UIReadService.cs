using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VOD.Common.Entities;

namespace VOD.Database.Services
{
    public class UIReadService : IUIReadService
    {
        private readonly IDbReadService _db;
        public UIReadService(IDbReadService db)
        {
            _db = db;
        }

        public async Task<Course> GetCourse(string userId, int courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Course>> GetCourses(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Video> GetVideo(string userId, int videoId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Video>> GetVideos(string userId, int moduleId = 0)
        {
            throw new NotImplementedException();
        }
    }
}
