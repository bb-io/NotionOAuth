using Apps.NotionOAuth.DataSourceHandlers;
using Apps.NotionOAuth.Models.Request.DataBase.Properties;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.NotionOAuth.Models.Request.Page.Properties.Getter;

public class PageStringPropertyRequest : StringPropertyRequest
{
    [Display("Page ID"), DataSource(typeof(PageDataHandler))]
    public string PageId { get; set; } = string.Empty;
}