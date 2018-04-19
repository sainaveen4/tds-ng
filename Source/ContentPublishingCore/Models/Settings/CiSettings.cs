using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public class CiSettings : ICiSettings
    {
        public bool CommitsEnabled { get; set; }
        public string RepoPath { get; set; }
        public string RepoBranch { get; set; }
        public string CiRegEx { get; set; }
        public List<string> CiConfigFilePaths { get; set; }
        public string SshKeyPath { get; set; }
    }
}
