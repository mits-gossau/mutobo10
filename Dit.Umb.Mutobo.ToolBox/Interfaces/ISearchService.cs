using Dit.Umb.Mutobo.ToolBox.Models.PoCo;
using System.Collections.Generic;

namespace Dit.Umb.Mutobo.ToolBox.Interfaces
{
    public interface ISearchService
    {
        ISearchResultsModel PerformSearch(string term);

        IEnumerable<SearchResult> Search(string term);
    }
}
