using Dit.Umb.Mutobo.ToolBox.Constants;
using Dit.Umb.Mutobo.ToolBox.Interfaces;
using Dit.Umb.Mutobo.ToolBox.Modules;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Extensions;

namespace Dit.Umb.Mutobo.ToolBox.Services;

public class CallToActionService : BaseService, ICallToActionService
{
    public CallToActionService(
        ILogger<CallToActionService> logger,
        IUmbracoContextAccessor contextAccessor) : base(logger, contextAccessor)
    {


    }

    public CallToActionButton GetCtaButton(IPublishedContent content)
    {
        List<IPublishedContent> pages = content
            .AncestorsOrSelf()
            .ToList();

        CallToActionButton ctaButton = null;
        var index = 0;


        if (pages != null)
        {
            do
            {
                ctaButton = pages[index].HasValue(DocumentTypes.BasePage.Fields.CallToActionButton)
                    ? new CallToActionButton(pages[index].Value<IEnumerable<IPublishedElement>>(DocumentTypes.BasePage.Fields.CallToActionButton).FirstOrDefault(), null) : null;
                index++;

            } while (index < pages.Count() && ctaButton == null);
        }

        return ctaButton;
    }
}
