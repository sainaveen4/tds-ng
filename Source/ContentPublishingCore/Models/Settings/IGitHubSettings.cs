namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public interface IGitHubSettings
    {
        bool CommitsEnabled { get; set; }
        string MasterContentBranch { get; set; }
        string MasterContentUrl { get; set; }
        bool MergeSecondaryAndMaster { get; set; }
        string SecondaryContentBranch { get; set; }
        string SecondaryContentUrl { get; set; }
        string SshKeyPath { get; set; }
    }
}