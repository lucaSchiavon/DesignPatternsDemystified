using System.Collections.Generic;



namespace DesignPatternsDemystified.CreationalPatterns.Singleton
{
    public class AppSettings
    {
        private Dictionary<string, string> settings;

        // Instantiate the Singleton when the class is loaded.
        private static readonly AppSettings instance = new AppSettings();

        // Private constructor to avoid creating external instances.
        private AppSettings()
        {
            // Initialize settings with default values.
            settings = new Dictionary<string, string>
        {
            { "BackgroundColor", "White" },
            { "FontColor", "Black" },
            { "FontSize", "12pt" }
        };
        }

        // Property for accessing the Singleton instance.
        public static AppSettings Instance
        {
            get { return instance; }
        }

        // Method to get the value of a specific setting.
        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
            {
                return null;// Return null if the key does not exist.
            }
        }

        // Method for setting the value of a specific setting.
        public void SetSetting(string key, string value)
        {
            if (settings.ContainsKey(key))
            {
                settings[key] = value;
            }
            else
            {
                settings.Add(key, value);
            }
        }
    }

}


