﻿using AppiumFramework.Config;
using Firebase.Database;
using System.Threading.Tasks;

namespace AppiumFramework.Utilities
{
    public class FirebaseExtension
    {
        public FirebaseClient FirebaseClient
        {
            get
            {
                return new FirebaseClient(
                Settings.BasePath,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Settings.AuthSecret)
                });
            }
        }
    }
}
