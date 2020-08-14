using AppiumFramework.Config;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace AppiumFramework.Utilities
{
    public class Firebase
    {
        public IFirebaseClient FirebaseClient { get; set; }

        public IFirebaseConfig Config()
        {
            return new FirebaseConfig
            {
                AuthSecret = Settings.AuthSecret,
                BasePath = Settings.BasePath
            };
        }
    }
}
