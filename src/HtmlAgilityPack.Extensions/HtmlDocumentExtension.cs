using System;
using System.Collections.Generic;
using System.Linq;

namespace HtmlAgilityPack.Extensions
{
    public static class HtmlDocumentExtension
    {
        public static IList<HtmlNode> GetElementsByClass(this HtmlDocument htmlDocument, String className)
        {
            return htmlDocument.DocumentNode.Descendants()
                .Where(d => d.Attributes.Contains("class") &&
                d.Attributes["class"].Value.Contains(className)).ToList();
        }

        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlDocument htmlDocument, String name)
        {
            return htmlDocument.DocumentNode.Descendants()
                .Where(d => d.Attributes.Contains("name") &&
                d.Attributes["name"].Value.Contains(name));
        }


        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string name)
        {
            return parent.Descendants().Where(node => node.Name == name);
        }

        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlNode parent, string name)
        {
            return parent.Descendants(name);
        }
    }
}
