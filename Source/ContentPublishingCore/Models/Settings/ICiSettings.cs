using System.Collections.Generic;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public interface ICiSettings
    {
        List<string> CiConfigFilePaths { get; set; }
        string CiRegEx { get; set; }
        bool CommitsEnabled { get; set; }
        string RepoBranch { get; set; }
        string RepoPath { get; set; }
        string SshKeyPath { get; set; }
    }
}