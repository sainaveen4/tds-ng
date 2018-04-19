namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public interface ISitecoreApiSettings
    {
        string ApiDatabase { get; set; }
        string ApiUrl { get; set; }
    }
}