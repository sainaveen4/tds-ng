namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public interface IAkamaiSettings
    {
        bool PushEnabled { get; set; }
        string SshKeyPath { get; set; }
    }
}