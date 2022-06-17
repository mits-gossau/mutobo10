using Dit.Umb.Mutobo.ToolBox.Models.PoCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Dit.Umb.Mutobo.ToolBox.Interfaces;

public interface IHeaderConfiguration
{
    Slogan GlobalSlogan { get; }
    IEnumerable<NavItem> NavigationItems { get; }
    Image Logo { get; }
    Link LogoUrl { get; }
    IEnumerable<Models.PoCo.Language> Languages { get; }
    Image StageImage { get; }
}
