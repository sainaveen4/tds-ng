using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.XM.ContentPublishingCore.Models.Settings
{
    public class AkamaiSettings : IAkamaiSettings
    {
        
        public bool PushEnabled { get; set; }
        public string SshKeyPath { get; set; }

    }
}
