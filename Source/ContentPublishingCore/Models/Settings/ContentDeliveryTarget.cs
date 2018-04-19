using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public class ContentDeliveryTarget
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public IAkamaiSettings AkamaiSettings { get; set; }
        public ICiSettings CiSettings { get; set; }
        public IGitHubSettings GitHubSettings   { get; set; }
        public ISitecoreApiSettings SitecoreApiSettings { get; set; }

    }
}
