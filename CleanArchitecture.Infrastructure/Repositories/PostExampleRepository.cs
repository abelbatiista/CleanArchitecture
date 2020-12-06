//using CleanArchitecture.Core.Entities;
//using CleanArchitecture.Core.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CleanArchitecture.Infrastructure.Repositories
//{
//    public class PostExampleRepository : IPostRepository
//    {
//        public async Task<IEnumerable<Post>> GetPosts()
//        {
//            var posts = Enumerable.Range(1, 10).Select(x => new Post
//            {
//                PostId = x,
//                Description = $"Description Mongo{x}",
//                Date = DateTime.Now,
//                Image = $"https://misapis.com/{x}",
//                UserId = x * 2
//            });

//            await Task.Delay(10);

//            return posts;
//        }
//    }
//}
