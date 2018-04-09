using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public class GitHubSettings : IGitHubSettings
    {
        /// <summary>
        /// Indicates to enabled commits to Github
        /// </summary>
        public bool CommitsEnabled { get; set; }

        /// <summary>
        /// Indicates to first merge secondary content into master content
        /// </summary>
        public bool MergeSecondaryAndMaster { get; set; }
        public string MasterContentUrl { get; set; }
        public string MasterContentBranch { get; set; }

        public string SecondaryContentUrl { get; set; }
        public string SecondaryContentBranch { get; set; }

        public string SshKeyPath { get; set; }

    }
}
