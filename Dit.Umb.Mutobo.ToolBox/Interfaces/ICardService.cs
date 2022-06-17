using Dit.Umb.Mutobo.ToolBox.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Dit.Umb.Mutobo.ToolBox.Interfaces
{
    public interface ICardService
    {
        IEnumerable<Card> GetCards(IPublishedElement element, string fieldName);
    }
}
