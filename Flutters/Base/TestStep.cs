using AppiumFramework.Utilities;
using Flutters.Database.Models;
using Firebase.Database.Query;
using Firebase.Database;
using System.Threading.Tasks;
using System.Threading;
using Dynamitey.DynamicObjects;
using System.Collections.Generic;
using System.Collections;

namespace Flutters.Base
{
    public class TestStep : FirebaseExtension
    {
        
        public Post GetPostTable()
        {
            Thread.Sleep(5000);
            Task<Post> task = Task.Run<Post>(async () => await GetPostIdAsync());
            return task.Result;
        }
        private async Task<Post> GetPostIdAsync()
        {
            Post post = new Post();
            var calls = await FirebaseClient
                .Child("Posts").OrderByKey().LimitToLast(1)
                .OnceAsync<Post>();

            foreach (var call in calls)
            {

                post = call.Object;
            }

            return post;
            
        }
    }
}
