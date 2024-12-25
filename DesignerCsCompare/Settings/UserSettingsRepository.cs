using System.Text.Json;

namespace DesignerCsCompare.Settings;

internal class UserSettingsRepository : IUserSettingsRepository
{
    private readonly string _userSettingsDir = GetUserSettingsDir();
    private readonly string _userSettingsPath = GetUserSettingsPath();
    private readonly string _leftRecentTextPath = GetLeftRecentTextPath();
    private readonly string _rightRecentTextPath = GetRightRecentTextPath();

    public UserSettings GetSettings()
    {
        if (!File.Exists(_userSettingsPath))
        {
            SaveSettings(new UserSettings());
        }

        UserSettings deserializedSettings;
        using (var fs = File.OpenRead(_userSettingsPath))
        {
            deserializedSettings = JsonSerializer.Deserialize<UserSettings>(fs);
            if (deserializedSettings is null)
                throw new InvalidOperationException($"Can't deserialize user settings. Path: {_userSettingsPath}");
        }

        if (File.Exists(_leftRecentTextPath))
            deserializedSettings.LeftText = File.ReadAllText(_leftRecentTextPath) ?? "";

        if (File.Exists(_rightRecentTextPath))
            deserializedSettings.RightText = File.ReadAllText(_rightRecentTextPath) ?? "";
        
        return deserializedSettings;
    }

    public void SaveSettings(UserSettings userSettings)
    {
        if (!Directory.Exists(_userSettingsDir))
            Directory.CreateDirectory(_userSettingsDir);

        var serializerOptions = new JsonSerializerOptions();
        serializerOptions.WriteIndented = true;
        string jsonString  = JsonSerializer.Serialize(userSettings, serializerOptions);

        File.WriteAllText(_userSettingsPath, jsonString);
        File.WriteAllText(_leftRecentTextPath, userSettings.LeftText ?? "");
        File.WriteAllText(_rightRecentTextPath, userSettings.RightText ?? "");
    }

    private static string GetUserSettingsDir()
    {
        return AppDataUtils.GetAppDataDir();
    }

    private static string GetUserSettingsPath()
    {
        var settingsDir = GetUserSettingsDir();
        var settingsPath = Path.Combine(settingsDir, "userSettings.json");
        return settingsPath;
    }

    private static string GetLeftRecentTextPath()
    {
        var settingsDir = GetUserSettingsDir();
        var path = Path.Combine(settingsDir, "leftRecentText.txt");
        return path;
    }
    private static string GetRightRecentTextPath()
    {
        var settingsDir = GetUserSettingsDir();
        var path = Path.Combine(settingsDir, "rightRecentText.txt");
        return path;
    }
}