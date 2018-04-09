using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public class SitecoreApiSettings : ISitecoreApiSettings
    {    
        public string ApiUrl { get; set; }
        public string ApiDatabase { get; set; }
    }
}
