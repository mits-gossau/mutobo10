using Dit.Umb.Mutobo.ToolBox.Modules;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Dit.Umb.Mutobo.ToolBox.Interfaces;

public interface IFlyerService
{
    IEnumerable<Flyer> GetFlyer(HttpContext context, IPublishedContent node, bool firstPic = false);
}
