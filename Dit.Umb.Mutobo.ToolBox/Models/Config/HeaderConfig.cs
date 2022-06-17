﻿using Dit.Umb.Mutobo.ToolBox.Constants;
using Dit.Umb.Mutobo.ToolBox.Interfaces;
using Dit.Umb.Mutobo.ToolBox.Models.PoCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Dit.Umb.Mutobo.ToolBox.Models.Config;

public class HeaderConfig : PublishedElementModel, IHeaderConfiguration
{
    public IEnumerable<NavItem> NavigationItems { get; set; }

    public Image Logo { get; set; }

    public Link LogoUrl => this.Value<Link>(ElementTypes.HeaderConfiguration.Link);

    public IEnumerable<Models.PoCo.Language> Languages { get; set; }

    public Image StageImage { get; set; }

    public Slogan GlobalSlogan => throw new NotImplementedException();

    public HeaderConfig(IPublishedElement content, IPublishedValueFallback publishedValueFallback) : base(content, null)
    {



    }
}
