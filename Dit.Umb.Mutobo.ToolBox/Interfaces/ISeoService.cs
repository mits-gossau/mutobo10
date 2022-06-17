using Dit.Umb.Mutobo.ToolBox.Constants;
using Dit.Umb.Mutobo.ToolBox.Models.Config;
using Dit.Umb.Mutobo.ToolBox.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;

namespace Dit.Umb.Mutobo.ToolBox.Interfaces
{
    public interface ISeoService
    {
        public SeoConfig GetSeoConfiguration();

     
    }
}
