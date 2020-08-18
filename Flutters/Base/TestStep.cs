using AppiumFramework.Utilities;
using Flutters.Database.Models;
using Firebase.Database.Query;
using Firebase.Database;
using System.Threading.Tasks;
using System.Threading;

namespace Flutters.Base
{
    public class TestStep : FirebaseExtension
    {
        public string GetPostForId(string id)
        {
            Thread.Sleep(5000);
            Task<string> task = Task.Run<string>(async () => await GetPostForIdAsync(id));
            return task.Result;
        }

        public Post GetLastPostTable()
        {
            Thread.Sleep(5000);
            Task<Post> task = Task.Run<Post>(async () => await GetLastPostTableAsync());
            return task.Result;
        }

        public void DeleteLastPostTable(string id)
        {
            Thread.Sleep(10000);
            Task task = Task.Run(async () => await DeleteLastPostTableAsync(id));
        }
        private async Task<Post> GetLastPostTableAsync()
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

        private async Task<string> GetPostForIdAsync(string id)
        {
            Post post = new Post();
            dynamic calls = await FirebaseClient
                .Child("Posts").Child(id)
                .OnceAsync<object>();

            var hardCodedNullChildCall = calls.ToString();
            if (hardCodedNullChildCall == "Firebase.Database.FirebaseObject`1[System.Object][]")
                return string.Empty;
            return calls[1].Object;
        }

        private async Task DeleteLastPostTableAsync(string id)
        {
            await FirebaseClient
                .Child("Posts").Child(id)
                .DeleteAsync();
        }
    }
}
