using AppiumFramework.Utilities;
using Flutters.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Flutters.Base
{
    public class TestStep : FirebaseExtension
    {
        public int GetNumberOfPosts()
        {
            Task<int> task = Task.Run<int>(async () => await GetNrPostsAsync());
            return task.Result;
        }
        private async Task<int> GetNrPostsAsync()
        {
            var calls = await FirebaseClient
                .Child("Posts")
                .OnceAsync<Post>();

            return calls.Count;
        }
    }
}
