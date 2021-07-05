using AngleSharp.Html.Dom;

namespace HtmlParserTest.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
