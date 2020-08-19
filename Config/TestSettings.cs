using Newtonsoft.Json;

namespace AppiumFramework.Config
{
    public class TestSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("platformName")]
        public string PlatformName { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("appPath")]
        public string AppPath { get; set; }

        [JsonProperty("appPackage")]
        public string AppPackage { get; set; }

        [JsonProperty("appActivity")]
        public string AppActivity { get; set; }

        [JsonProperty("authSecret")]
        public string AuthSecret { get; set; }

        [JsonProperty("basePath")]
        public string BasePath { get; set; }
        [JsonProperty("threadSleepMultiplicator")]
        public int ThreadSleepMultiplicator { get; set; }

        [JsonProperty("deletePostFromDatabaseScriptPath")]
        public string DeletePostFromDatabaseScriptPath { get; set; }        
    }
}
