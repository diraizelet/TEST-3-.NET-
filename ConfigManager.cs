using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public sealed class ConfigurationManager
    {
        // Step 1: Use a private static field to hold the single instance of the class
        private static readonly Lazy<ConfigurationManager> _instance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Step 2: Use a private constructor to prevent instantiation from outside the class
        private ConfigurationManager()
        {
            // Initialize configuration settings here
        }

        // Step 3: Use a public static property to provide access to the single instance
        public static ConfigurationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        // Example configuration property
        public string ApplicationName { get; set; } = "My Application";

        // Example method to demonstrate functionality
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
        }
    }
}
